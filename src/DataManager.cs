using System.IO;
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
        public enum Period { Period1 = 1, Period2, Period3, Period4, Period5, Break = 0, Spare = 0, Noperiod = -1 }

        // String of the file location which is used to let people log in
        public static string LoginFile { get; } = "Logins.lbs";

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
            rawData = reader.ReadLine();//done in two steps for clarity
            header = rawData.Split(',');//this contains the headers
            for (int i = 0; i < header.Length; i++)
            {
                header[i] = header[i].ToUpper();//just to remove the possibility of problems due to case
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
            try
            {
                return File.ReadAllLines(fileName);
            }
            catch
            {
                throw new System.ArgumentException("An error occured while reading your file!" +
                                          "\n Please make sure you type the .extention of your file!",
                                          "original");
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
            TextWriter writer = new StreamWriter(fileName, append:true);

            writer.WriteLine("\n" + data);

            writer.Close();
        }

        /// <summary>
        /// Called when a string array of data is needed to be written to a file, overwrites everything in the file!
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="data"></param>
        public static void SaveAllData(string fileName, string[] data)
        {
            var writer = File.AppendText(fileName);
            //var writer = new StreamWriter(fileName);

            foreach (var s in data)
            {
                writer.WriteLine(s);
            }

            writer.Close();
        }
    }
}
