using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ScannerProject
{
    internal static partial class DataManager
    {
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

        public static void SaveAllData(string fileName, string[] data)
        {
            var writer = new StreamWriter(fileName);

            foreach (var s in data)
            {
                writer.WriteLine(s);
            }

            writer.Close();
        }
    }
}
