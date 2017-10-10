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
        public string name;
        Employee worker = new Employee();

        List<Adopter> adopterList = new List<Adopter>();

    public void DetermineUser(Adopter adopter)
        {
            Console.WriteLine("Welcome to the humane society! What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Are you an employee or a customer? Enter 1 if you are an employee or 2 if you are a customer.");
            userInput = Console.ReadLine();
            if (userInput == "1")
            {
                userInput = employed;
                employee = true;
                worker.EmployeeWork(adopter, adopterList);
            }
            else if (userInput == "2")
            {
                userInput = customer;
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
