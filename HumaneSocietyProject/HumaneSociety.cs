using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class HumaneSociety
    {
        public string userInput;
        public string employed;
        public string customer;
        public bool employee;
        public string employeeName;
        public string adopterName;
        public string name;
        Employee worker = new Employee();

        List<Adopter> adopterList = new List<Adopter>();

    public void DetermineUser(Adopter adopter)
        {
            Console.WriteLine("Welcome to the humane society! Are you an employee or a customer? Enter 1 if you are an employee or 2 if you are a customer.");
            userInput = Console.ReadLine();
            if (userInput == "1")
            {
                employee = true;
                Console.WriteLine("Welcome to work! Enter your name to clock in.");
                employeeName = Console.ReadLine();
                worker.EmployeeWork(adopter, adopterList);
            }
            else if (userInput == "2")
            {
                employee = false;
                adopter.GetAdopterId(adopter, adopterList);
            }
            else
            {
                Console.WriteLine("Sorry, that is an invalid response.");
                DetermineUser(adopter);
            }
        }
    }
}
