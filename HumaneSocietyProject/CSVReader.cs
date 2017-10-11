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

        public CSVReader(string csvPath)
        {
            using (var reader = new StreamReader(csvPath))
            {
                List<string> StreamReader = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    string[] values = line.Split(',');
                    int i = 0;
                    string[] newArray = new string[15];
                    foreach (string value in values)
                    {
                        newArray[i] = value;
                        i++;
                    }
                }
            }
        }
    }
}