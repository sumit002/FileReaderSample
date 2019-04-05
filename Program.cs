using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReaderConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CSVReader csvReader = new CSVReader();
            List<string> asd = csvReader.ReadCSVData();

            Console.ReadLine();
        }
    }
}
