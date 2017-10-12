using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyProject
{
    public class CSVReader
    {
        public string petId;
        public string adoptionStatus;
        public string animal;
        public string roomNumber;
        public string breedColor;
        public string petName;
        public string petGender;
        public string petAge;
        public string familyPet;
        public string energyLevel;
        public string behaviorReport;
        public string diet;
        public string shots;
        public string petNotes;

        List<List<string>> csvData = new List<List<string>>();

        public CSVReader(string csvPath)
        {
            using (var reader = new StreamReader(csvPath))
            {
                List<string> StreamReader = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    string[] values = line.Split(',');
                    List<string> csvLine = new List<string>();
                    // int i = 0;
                    //  string[] newArray = new string[15];
                    foreach (string value in values)
                    {
                        csvLine.Add(value);
                        // newArray[i] = value;
                        // i++;
                    }
                    csvData.Add(csvLine);
                }
            }
        }

        //    public void ReadCsvFile()
        //{
        //    using (var reader = new StreamReader = new List<string>();
        //    var line = reader.ReadLine(csvData);
        //    var value = line.Split(',');

        //    foreach (lines in csvFile)
        //    {
        //        line.column[0]();
        //        foreach (values in line)
        //        {
        //            value.index[0]();
        //            index++;
        //        }
        //        column++;
        //    }

        //split up the data in the file var values = lines.Select(l => new { FirstColumn = l.Split(',').First(), Values = l.Split(',').Skip(1).Select(v => int.Parse(v)) });
        //sort the data  foreach (var value in csvData)

        //put the data into a column    Console.WriteLine(string.Format(Column '{0}'()));
        //make another column and do it again    Column++;
    }
}
