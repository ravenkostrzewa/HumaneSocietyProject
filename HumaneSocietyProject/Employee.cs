using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Employee
    {
        string employeeName;
        int employeeId;
        int collectedAdoptionFee;
        string adopterName;
        string adopterBirthDate;
        string phoneNumber;
        string residenceType;
        bool petsPermitted;
        string userInput;
        string streetAddress;
        string city;
        string state;
        string zipCode;
        string occupation;
        string hoursHomePerDay;
        bool children;
        string adopterNotes;
        string petId;
        string animal;
        string roomNumber;
        bool adoptionStatus;
        string petName;
        string breedColor;
        string petBirthDate;
        string familyPet;
        string acceptedDate;
        string energyLevel;
        string behaviorReport;
        bool shots;
        string diet;
        int cost;
        string petNotes;

        public void CreateNewPetProfile()
        {
            Console.WriteLine("Create a unique ID number for the new pet. You can use letters and/or numbers.");
            userInput = Console.ReadLine();     //work around
            userInput = petId;      //work around
            if (petId == userInput)     //work around
            {
                Console.WriteLine("What is " + petId + "'s name?");
                petName = Console.ReadLine();
                Console.WriteLine("Has " + petId + " been adopted yet? Enter yes or no.");
                userInput = Console.ReadLine();
                if (userInput == "yes")
                {
                    adoptionStatus = true;
                }
                else if (userInput == "no")
                {
                    adoptionStatus = false;
                }
            }
            Console.WriteLine("What kind of animal is this? (Eg. dog, cat, lizard, bird)");
            animal = Console.ReadLine();
            Console.WriteLine("What room number is " + petId + "occupying?");
            roomNumber = Console.ReadLine();
            Console.WriteLine("What color and breed is " + petId + " ?");
            Console.WriteLine("Do you know " + petId + "'s date of birth? Enter yes or no.");
            if (userInput == "yes")
            {
                Console.WriteLine("Enter " + petId + "'s date of birth. Use the following format: 01/01/1990");
                petBirthDate = Console.ReadLine();
            }

            else if (userInput == "no")
            {
                Console.WriteLine("How old would you guess that " + petId + " is? Guess in years, months, or weeks accordingly.");
                petBirthDate = Console.ReadLine();
            }
            Console.WriteLine("Would " + petId + " make a good family pet? Enter yes, no, or with training.");
            familyPet = Console.ReadLine();
            Console.WriteLine("When was " + petId + " first brought to the humane society? Enter the month and year in the following format: 08/2017");
            acceptedDate = Console.ReadLine();
            Console.WriteLine("On a scale of 1-10 with 1 being lazy all the time and 10 being endlessly hyper, how would you rate " + petId + "'s energy level?");
            energyLevel = Console.ReadLine();
            Console.WriteLine("Describe " + petId + "'s behavior.");
            behaviorReport = Console.ReadLine();
            Console.WriteLine("Has " + petId + " had its shots? Enter yes or no.");
            userInput = Console.ReadLine();
            if (userInput == "yes")
            {
                shots = true;
            }
            else if (userInput == "no")
            {
                shots = false;
            }
            Console.WriteLine("What does " + petId + " eat? How much? How often?");
            diet = Console.ReadLine();
            Console.WriteLine("Notes:");
            petNotes = Console.ReadLine();
        }


        public void CheckAdoptionStatus()
        {
            Console.WriteLine("Enter the ID of the pet for which you would like to check the adoption status.");
            userInput = Console.ReadLine();
            if (userInput == petId)
            {
                if (userInput == "yes")
                {
                    adoptionStatus = true;
                    Console.WriteLine(petId + " has been adopted!");
                }
                else if (userInput == "no")
                {
                    adoptionStatus = false;
                    Console.WriteLine(petId + " has not been adopted yet.");
                }
            }
            else if (userInput != petId)
            {
                Console.WriteLine("Sorry, that ID does not belong to any of the pets in the database. Enter search to try searching again or exit to exit the search.");
                userInput = Console.ReadLine();
                if (userInput == "search")
                {
                    CheckAdoptionStatus();
                }
                else if (userInput == "exit")
                {
                    EndProgram();
                }
            }
        }

        public void CheckShotStatus()
        {
            Console.WriteLine("Enter the ID of the pet for which you would like to check the shot status.");
            userInput = Console.ReadLine();
            if (petId == userInput)
            {
                if (shots == true)
                {
                    Console.WriteLine(petId + " has had its shots.");
                }
                else if (shots == false)
                {
                    Console.WriteLine(petId + " has not had its shots yet.");
                }
                else if (petId != userInput)
                {
                    Console.WriteLine("Sorry, that ID does not belong to any of the pets in the database. Enter search to try searching again or exit to exit the search.");
                    userInput = Console.ReadLine();
                    if (userInput == "search")
                    {
                        CheckShotStatus();
                    }
                    else if (userInput == "exit")
                    {
                        EndProgram();
                    }
                }
            }
        }           
               
            public void EndProgram()
        {
            Console.WriteLine("Thank you for visiting the humane society!");
        }
    }
}