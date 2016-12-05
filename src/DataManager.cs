using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace ScannerProject
{
    /// <summary>
    /// Static class, used for any/all data management methods
    /// </summary>
    internal static partial class DataManager
    {
        // Enum of periods throughout the day with their respective values
        public enum Period
        {
            Period1 = 0,
            Period2,
            Period3,
            Period4,
            Period5,
            Break = -1,
            Spare = -1,
            Noperiod = -1
        }

        // String of the file location which is used to let people log in
        public static string LoginFile { get; } = "Logins.lbs";

        public static int DefaultGraceTime { get; } = 30;

        /// <summary>
        /// Rowbottoms method
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="fields"></param>
        /// <returns></returns>
        public static int[] findIndices(string fileName, string[] fields)
        {
            StreamReader reader = new StreamReader(fileName);
            string rawData;
            string[] header;
            int[] indices = new int[fields.Length];

            //get the file header
            rawData = reader.ReadLine(); //done in two steps for clarity
            header = rawData.Split(','); //this contains the headers
            for (int i = 0; i < header.Length; i++)
            {
                header[i] = header[i].ToUpper(); //just to remove the possibility of problems due to case
                for (int j = 0; j < fields.Length; j++)
                {
                    fields[j] = fields[j].ToUpper();
                    if (header[i].Contains(fields[j]))
                    {
                        indices[j] = i;
                    }
                }
            }
            reader.Close();

            return indices;
        }

        /// <summary>
        /// Called when data is needed to be read from a file and stored in a string array
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static string[] ReadAllData(string fileName)
        {
            //if (File.Exists(fileName)) return File.ReadAllLines(fileName);

            //File.Create(fileName);
            return File.ReadAllLines(fileName);
        }

        public static string[] ReadAllData(string fileName, bool ignoreFirstLine)
        {
            var data = File.ReadLines(fileName).ToList();

            if(ignoreFirstLine) data.RemoveAt(0);

            return data.ToArray();
        }

        public static string ReadLine(string fileName, int lineNumber)
        {
            var data = ReadAllData(fileName);

            if(lineNumber > data.Length) throw new IndexOutOfRangeException(); 

            return data[lineNumber];
        }

        public static void CreateCourses(string[] courseNames)
        {
            for (var i = 0; i < courseNames.Length; i++)
            {
                courseNames[i] += ".lbs";
            }

            foreach (var c in courseNames)
            {
                if (File.Exists(c)) continue;
  
                var myFile = File.Create(c);

                var firstLine = DefaultGraceTime;
                myFile.Close();
                SaveAllData(c, firstLine.ToString());

                myFile.Close();
            }
        }
        
        /// <summary>
        /// Called when data is needed to be loaded into a list box
        /// </summary>
        /// <param name="data"></param>
        /// <param name="listBox"></param>
        public static void LoadAllData(string[] data, ListBox listBox)
        {
            var i = 0;

            foreach (var s in data)
            {
                if (i == 0)
                {
                    i++;
                    continue;
                }

                var strb = new StringBuilder(s);

                data[i] = strb.ToString();
                listBox.Items.Add(data[i]);

                i++;
            }
        }

        /// <summary>
        /// Called when a string of data is needed to be appended to a new line in a file 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="data"></param>
        public static void SaveAllData(string fileName, string data)
        {
            if (!File.Exists(fileName)) File.Create(fileName);

            TextWriter writer = new StreamWriter(fileName, append: true);

            writer.WriteLine(data);

            writer.Close();
        }

        /// <summary>
        /// Called when a string array of data is needed to be written to a file, overwrites everything in the file!
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="data"></param>
        public static void SaveAllData(string fileName, string[] data)
        {
            //var writer = File.AppendText(fileName);
            var writer = new StreamWriter(fileName);

            foreach (var s in data)
            {
                writer.WriteLine(s);
            }

            writer.Close();
        }

        public static void GetScannerInput(Timer timer, TextBox textBox)
        {
            if (timer.Enabled || textBox.Text.Length != 0) return;

            textBox.Clear();
            timer.Start();
        }

        public static void SendMail(Student std)
        {
            try
            {
                var lateMail = new MailMessage();
                var smtpServer = new SmtpClient("smtp.gmail.com");

                lateMail.From = new MailAddress("scannerprojectics4u@gmail.com");

                lateMail.To.Add(std.ParentEmail);
                lateMail.Body = "Your child " + std.FirstName + " was late to one or more of their classes today " + "";

                lateMail.Subject = "CKSS Late Student";

                smtpServer.Port = 587;
                smtpServer.Credentials = new System.Net.NetworkCredential("scannerprojectics4u", "scannerproject");
                smtpServer.EnableSsl = true;

                smtpServer.Send(lateMail);

                MessageBox.Show("Message Sent To " + lateMail.To);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static void SendMail(List<Student> students)
        {
            foreach (var s in students) SendMail(s);
        }
    }
}
