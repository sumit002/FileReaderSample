using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReaderConsoleApp
{
    public sealed class CSVReader
    {
        private readonly string filePath = null;
        public CSVReader()
        {
            string dir = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            filePath = dir + @"\DataFiles\sample_data.csv";
        }

        /// <summary>
        /// Read CSV Data
        /// </summary>
        public List<string> ReadCSVData()
        {
            using (var reader = new StreamReader(this.filePath))
            {
                List<string> searchList = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    Console.WriteLine(line);
                    searchList.Add(line);
                }
                return searchList;
            }
        }
    }
}
