using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class Adopter
    {
        public string adopterName;
        public string adopterId;
        public string adopterBirthDate;
        public int phoneNumber;
        public string residenceType;
        public bool petsPermitted;
        public string userInput;
        public string streetAddress;
        public string cityState;
        public int zipCode;
        public string occupation;
        public int hoursHomePerDay;
        public bool children;
        public string adopterNotes;
        public string petId;
        public string petGender;
        public string animal;
        public string breedColor;
        public string petName;
        public string energyLevel;
        public string behaviorReport;
        public string acceptedDate;
        public string petNotes;
        public string petAge;
        public string familyPet;
        public string diet;
        public bool shots;
        public string roomNumber;
        public bool adoptAPet;
        public bool adoptionStatus;
        public int adoptionFeeCollected;
        public string employeeName;

        public void SearchAdopterId()
        {
            Console.WriteLine("Potential adopter, do you have an ID number? Enter yes or no.");
            userInput = Console.ReadLine();
            if (userInput == "yes")
            {
                Console.WriteLine("Enter your ID number.");
                adopterId = Console.ReadLine();
                Console.WriteLine("Would you like to look at the pets? Enter 1 to view the pets or 2 to leave the humane society.");
                userInput = Console.ReadLine();
                if (userInput == "1")
                {
                    SearchMenu();
                }
                else if (userInput == "2")
                {
                    EndProgram();
                }
                else
                {
                    Console.WriteLine("Sorry, that is an invalid response.");
                    SearchAdopterId();
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
            

        public void CompleteApplication()
        {
            Console.WriteLine("Thank you for your interest in adopting a new pet! What is your name?");
            adopterName = Console.ReadLine();
            Console.WriteLine("What is your date of birth? Enter your birthdate using numbers, not backslashes or other symbols.");
            adopterBirthDate = Console.ReadLine();
            Console.WriteLine("Enter your phone number using numbers, omit dashes or other symbols.");
            phoneNumber = Int32.Parse(Console.ReadLine());
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
            else
            {
                while (userInput != "yes" && userInput != "no")
                {
                    Console.WriteLine("Sorry, that is an invalid response. Are you allowed to have pets there? Enter yes or no.");
                    userInput = Console.ReadLine();
                    if (userInput == "yes")
                    {
                        petsPermitted = true;
                    }
                    else if (userInput == "no")
                    {
                        petsPermitted = false;
                    }
                }
            } 
            Console.WriteLine("What is your street address?");
            streetAddress = Console.ReadLine();
            Console.WriteLine("What city and state do you live in? Enter them in the following format: City, State");
            cityState = Console.ReadLine();
            Console.WriteLine("What is your zip code?");
            zipCode = Int32.Parse(Console.ReadLine());
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
            else
            {
                while (userInput != "yes" && userInput != "no")
                {
                    Console.WriteLine("Sorry, that is an invalid response. Are there any children living with you? Enter yes or no.");
                    userInput = Console.ReadLine();
                    if (userInput == "yes")
                    {
                        children = true;
                    }
                    else if (userInput == "no")
                    {
                        children = false;
                    }
                }
            }
            Console.WriteLine("What is your occupation?");
            occupation = Console.ReadLine();
            Console.WriteLine("How many hours are you home per day?");
            hoursHomePerDay = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Notes: ");
            adopterNotes = Console.ReadLine();
            SearchMenu();
        }

        public void SearchMenu()
        {
            Console.WriteLine("Would you like to search for your new pet by ID number, name, species, or breed/color? Enter 1 to search by ID number, 2 to search by name, 3 to search by species, 4 to search by the breed/color, or 5 to leave the humane society.");
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
            else
            {
                Console.WriteLine("Sorry, that is an invalid response.");
                SearchMenu();
            }
        }

        public void SearchByID()
        {
            Console.WriteLine("What is the ID number of the pet for which you are searching?");
            userInput = Console.ReadLine();
            if (userInput == petId)
            {
                Console.WriteLine("Your search returned the following: Species: " + animal + " Name: " + petName + " Adoption Status: " + adoptionStatus + " Gender: " + petGender + " Breed/Color: " + breedColor + " Age: " + petAge + " Room Number: " + roomNumber + " Energy Level: " + energyLevel + " Behavior Report: " + behaviorReport + " Shots: " + shots + " Diet: " + diet + " Notes: " + petNotes + " At the Humane Society Since: " + acceptedDate);
                Adopt();
            }
            else if (userInput != petId)
            {
                Console.WriteLine("Sorry, your search did not return any results. Enter 1 to look at the pets or 2 to leave the humane society.");
                userInput = Console.ReadLine();
                if (userInput == "1")
                {
                    SearchMenu();
                }
                else if (userInput == "2")
                {
                    EndProgram();
                }
                else
                {
                    Console.WriteLine("Sorry, that is an invalid response.");
                    SearchByID();
                }
            }
            else
            {
                Console.WriteLine("Sorry, that is an invalid response.");
                SearchByID();
            }
        }

        public void SearchByAnimal()
        {
            Console.WriteLine("What kind of animal are you searching for? (Eg. dog, cat, lizard, bird");
            userInput = Console.ReadLine();
            if (userInput == animal)
            {
                Console.WriteLine("Your search returned the following: Species: " + animal + "Breed/Color: " + breedColor + " Name: " + petName + " ID: " + petId + " You can see the full profile of a pet by searching its ID number.");
                SearchByID();
            }
            else if (userInput != animal)
            {
                Console.WriteLine("Sorry, your search did not return any results. Enter 1 to search by species again, 2 to look at the pets, or 3 to leave the humane society.");
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
                else
                {
                    Console.WriteLine("Sorry, that is an invalid response.");
                    SearchByAnimal();
                }
            }
            else
            {
                Console.WriteLine("Sorry, that is an invalid response.");
                SearchByAnimal();
            }
        }

        public void SearchByBreedColor()
        {
            Console.WriteLine("What is the breed or color of the pet for which you are searching? Enter either the breed or the color.");
            userInput = Console.ReadLine();
            if (userInput == breedColor)
            {
                Console.WriteLine("Your search returned the following: Species: " + animal + "Breed/Color: " + breedColor + " Name: " + petName + " ID: " + petId + " You can see the full profile of a pet by searching its ID number.");
                SearchByID();
            }
            else if (userInput != breedColor)
            {
                Console.WriteLine("Sorry, your search did not return any results. Enter 1 to search by breed or color again, 2 to look at the pets, or 3 to leave the humane society.");
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
                Console.WriteLine("Your search returned the following: Species: " + animal + "Breed/Color:" + breedColor + " Name: " + petName + " ID: " + petId + " You can see the full profile of a pet by searching its ID number.");
                SearchByID();
            }
            else if (userInput != petName)
            {
                Console.WriteLine("Sorry, your search did you return any results. Enter 1 to search by name again, 2 to look at the pets, or 3 to leave the humane society.");
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
                else
                {
                    Console.WriteLine("Sorry, that is an invalid response.");
                    SearchMenu();
                }
            }
        }

        public void Adopt()
        {
            Console.WriteLine(adopterName + ", would you like to adopt " + petName + " for $200? Enter yes or no.");
            userInput = Console.ReadLine();
            if (userInput == "yes")
            {
                Console.WriteLine(employeeName + ", is this adoption in " + petName + "'s best interest? Enter yes to approve the adoption or no to deny it.");
                userInput = Console.ReadLine();
                if (userInput == "yes")
                {
                    adoptAPet = true;
                    adoptionStatus = true;
                    Console.WriteLine("Congratulations " + adopterName + "! The adoption has been approved!");
                    adoptionFeeCollected = adoptionFeeCollected + 200;
                }
                else if (userInput == "no")
                {
                    adoptAPet = false;
                    adoptionStatus = false;
                    Console.WriteLine("Sorry" + adopterName + ". The adoption has been denied. Enter 1 to look at other pets or 2 to leave the humane society.");
                    userInput = Console.ReadLine();
                    if (userInput == "1")
                    {
                        SearchMenu();
                    }
                    else if (userInput == "2")
                    {
                        EndProgram();
                    }
                    else
                    {
                        Console.WriteLine("Sorry, that is an invalid response.");
                        SearchMenu();
                    }
                }
            }
            else if (userInput == "no")
            {
                adoptAPet = false;
                adoptionStatus = false;
                SearchMenu();
            }
            else
            {
                Adopt();
            }
        }

        public void EndProgram()
        {
            Console.WriteLine("Have a great day! Goodbye!");
        }
    }
}