using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Adopter
    {
        string adopterId;
        string adopterName;
        string birthDate;
        string phoneNumber;
        string residenceType;
        bool petsPermitted;
        string userInput;
        int userResponse;
        string streetAddress;
        string city;
        string state;
        string zipCode;
        string occupation;
        int hoursHomePerDay;
        bool children;
        string notes;
        bool adoptAPet;
        bool adoptionStatus;
        int adoptionFeeCollected;
        string petId;
        string petName;
        string breedColor;
        string animal;

        public void SearchAdopterId()
        {
            Console.WriteLine("Do you have an ID number? Enter yes or no.");
            userInput = Console.ReadLine();
            if (userInput == "yes")
            {
                Console.WriteLine("Enter your ID number.");
                if (adopterId == userInput)
                {
                    Console.WriteLine("Would you like to view the pets? Enter 1 to view the pets, 2 to go to the main search menu,  or 3 to exit.");
                    userInput = Console.ReadLine();
                    if (userInput == "1")
                    {
                        ViewPets();
                    }
                    else if (userInput == "2")
                    {
                        SearchMenu();
                    }
                    else if (userInput == "3")
                    {
                        EndProgram();
                    }
                }
                else if (userInput == "no")
                {
                    CompleteApplication();
                }
                else
                {
                    Console.WriteLine("Sorry, that is an invalid response.");
                    SearchAdopterId();
                }
            }
        }

        public void CompleteApplication()
        {
            Console.WriteLine("Thank you for your interest in adoption! What is your name?");
            adopterName = Console.ReadLine();
            Console.WriteLine("What is your date of birth? Enter your birthdate in the following format: 01/01/1990");
            birthDate = Console.ReadLine();
            Console.WriteLine("Enter your phone number in the following format: 121-212-1212");
            phoneNumber = Console.ReadLine();
            Console.WriteLine("Do you live in a house, apartment, condo, or studio? Enter other if you do not reside in one of those residence types and specify your residence type.");
            residenceType = Console.ReadLine();
            Console.WriteLine("Are you allowed to have pets there? Enter yes or no.");
            userInput = Console.ReadLine();
            if (userInput == "yes")
            {
                petsPermitted = true;
            }
            else if (userInput == "no")
            {
                petsPermitted = false;
            }
            Console.WriteLine("What is your street address?");
            streetAddress = Console.ReadLine();
            Console.WriteLine("What city do you live in?");
            city = Console.ReadLine();
            Console.WriteLine("What state do you live in?");
            state = Console.ReadLine();
            Console.WriteLine("What is your zip code?");
            zipCode = Console.ReadLine();
            Console.WriteLine("Are there any children living with you? Enter yes or no.");
            userInput = Console.ReadLine();
            if (userInput == "yes")
            {
                children = true;
            }
            else if (userInput == "no")
            {
                children = false;
            }
            Console.WriteLine("Notes: ");
            notes = Console.ReadLine();
        }

        ViewPets()
        {
            Console.WriteLine("Would you like to search the pets by ID number? Enter yes or no.");
            if (userInput == "yes")
            {
                SearchByID();
            }
            else if (userInput == "no")
            {
            }
            else if (userInput != "yes" && userInput != "no")
            {
                Console.WriteLine("Sorry, that is an invalid response.");
                ViewPets();
            }
        }

        public void SearchMenu()
        {
            Console.WriteLine("Would you like to search for your new pet by ID number, name, type of animal, or breed/color? Emter 1 to search by ID number, 2 to search by name, 3 to search by the type of animal, 4 to search by the breed/color, or 5 to exit.");
            userInput = Console.ReadLine();
            if (userInput == "1")
            {
                SearchByID();
            }
            else if (userInput == "2")
            {
                SearchByName();
            }
            else if (userInput == "3")
            {
                SearchByAnimal();
            }
            else if (userInput == "4")
            {
                SearchByBreedColor();
            }
            else if (userInput == "5")
            {
                EndProgram();
            }
        }

        public void SearchByID()
        {
            Console.WriteLine("What is the ID number of the pet for which you are searching?");
            userInput = Console.ReadLine();
            if (userInput == petId)
            {
                Console.WriteLine("Your search returned the following: "); //go to all information"
            }
            else if (userInput != petId)
            {
                Console.WriteLine("Sorry, your search did not return any results. Enter 1 to search by ID again, 2 to return to the search main menu, or 3 to exit.");
                userInput = Console.ReadLine();
                if (userInput == "1")
                {
                    SearchByAnimal();
                }
                else if (userInput == "2")
                {
                    SearchMenu();
                }
                else if (userInput == "3")
                {
                    EndProgram();
                }
            }
        }

        public void SearchByAnimal()
        {
            Console.WriteLine("What kind of animal are you searching for? (Eg. dog, cat, lizard, bird");
            userInput = Console.ReadLine();
            if (userInput == animal)
            {
                Console.WriteLine("Your search returned the following: "); //show results; 
            }
            else if (userInput != animal)
            {
                Console.WriteLine("Sorry, your search did not return any results. Enter 1 to search by animal again, 2 to return to the search menu, or 3 to exit.");
                userInput = Console.ReadLine();
                if (userInput == "1")
                {
                    SearchByAnimal();
                }
                else if (userInput == "2")
                {
                    SearchMenu();
                }
                else if (userInput == "3")
                {
                    EndProgram();
                }
            }
        }

        public void SearchByBreedColor()
        {
            Console.WriteLine("What is the breed or color of the pet for which you are searching? Enter either the breed or the color.");
            userInput = Console.ReadLine();
            if (userInput == breedColor)
            {
                Console.WriteLine("Your search returned the following: " + breedColor + animal + petName + petId + ".");
                SearchByID();
            }
            else if (userInput != breedColor)
            {
                Console.WriteLine("Sorry, your search did not return any results. Enter 1 to search by breed or color again, 2 to return to the search menu, or 3 to exit.");
                userInput = Console.ReadLine();
                if (userInput == "1")
                {
                    SearchByBreedColor();
                }
                else if (userInput == "2")
                {
                    SearchMenu();
                }
                else if (userInput == "3")
                {
                    EndProgram();
                }
                else
                {
                    SearchByBreedColor();
                }
            }
        }

        public void SearchByName()
        {
            Console.WriteLine("What is the name of the pet for which you are searching?");
            userInput = Console.ReadLine();
            if (userInput == petName)
            {
                Console.WriteLine("Your search returned the following: " + petName + petId + animal + ".");
                SearchByID();
            }
            else if (userInput != petName)
            {
                Console.WriteLine("Sorry, your search did you return any results. Enter 1 to search by name again, 2 to return the search menu, or 3 to exit.");
                userInput = Console.ReadLine();
                if (userInput == "1")
                {
                    SearchByName();
                }
                else if (userInput == "2")
                {
                    SearchMenu();
                }
                else if (userInput == "3")
                {
                    EndProgram();
                }
            }
        }

        public void Adopt()
        {
            Console.WriteLine("Would you like to adopt " + petId + "? Enter yes or no.");
            userInput = Console.ReadLine();
            if (userInput == "yes")
            {
                adoptAPet = true;
                adoptionStatus = true;
                adoptionFeeCollected = adoptionFeeCollected + 200;
            }
            else if (userInput == "no")
            {
                adoptAPet = false;
                adoptionStatus = false;
                ViewPets();
            }
            else
            {
                Adopt();
            }
        }

        public void EndProgram()
        {
            Console.WriteLine("Thank you for visiting the humane society!");
        }
    }
}