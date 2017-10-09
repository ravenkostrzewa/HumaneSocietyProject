using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyProject
{
    class CSVReader
    {
        public CSVReader(string csvPath)

        {
            using (var reader = new StreamReader(csvPath))
            {
                List<string> StreamReader = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    Array[]
                    //add each item from array to the list in 17
                }
            }
        }
    }
}