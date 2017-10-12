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
        public int adopterId = 100000;
        public string residenceType;
        public bool petsPermitted;
        public string userInput;
        public string cityState;
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
        public string employed;
        public string customer;
        
        public void GetAdopterId(Adopter adopter, List<Adopter>adopters)
        {
            Console.WriteLine("Potential adopter, what is your name?");
            adopterName = Console.ReadLine();
            Console.WriteLine(adopterName + ", do you have an ID number? Enter yes or no.");
            userInput = Console.ReadLine().ToLower();
            if (userInput == "yes")
            {
                Console.WriteLine("Enter your ID number.");
                adopterId = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Would you like to look at the pets? Enter 1 to view the pets or 2 to leave the humane society.");
                userInput = Console.ReadLine();
                if (userInput == "1")
                {
                    SearchMenu(adopter, adopters);
                }
                else if (userInput == "2")
                {
                    EndProgram(adopter, adopters);
                }
                else
                {
                    Console.WriteLine("Sorry, that is an invalid response.");
                    GetAdopterId(adopter, adopters);
                }
            }
            else if (userInput == "no")
            {
                CompleteApplication(adopter, adopters);
            }
            else
            {
                Console.WriteLine("Sorry, that is an invalid response.");
                GetAdopterId(adopter, adopters);
            }
        }  

        public void CompleteApplication(Adopter adopter, List<Adopter>adopters)
        {
            Console.WriteLine(adopterName + ", thank you for your interest in adopting a new pet!");
            Console.WriteLine("Do you live in a house, apartment, or condo? Enter other if you do not reside in one of those residence types.");
            residenceType = Console.ReadLine();
            residenceType.ToLower();
            if (residenceType == "other")
            {
                Console.WriteLine("Describe your home.");
                residenceType = Console.ReadLine();
            }
            else if (residenceType != "house" && residenceType != "apartment" && residenceType != "condo" && residenceType != "other")
            {
                while (residenceType != "house" && residenceType != "apartment" && residenceType != "condo" && residenceType != "other")
                {
                    Console.WriteLine("Sorry, that is an invalid response. Do you live in a house, apartment, condo, or studio? Enter other if you do not reside in one of those residence types and specify your residence type.");
                    residenceType = Console.ReadLine();
                    residenceType.ToLower();
                }
                if (residenceType == "other")
                {
                    Console.WriteLine("Describe your home.");
                    residenceType = Console.ReadLine();
                }
            }
            Console.WriteLine("Are you allowed to have pets there? Enter yes or no.");
            userInput = Console.ReadLine().ToLower();
            if (userInput == "yes")
            {
                petsPermitted = true;
            }
            else if (userInput == "no")
            {
                petsPermitted = false;
                Console.WriteLine("Sorry, you are not a good fit for any of the pets if they are prohibitted from your home.");
                EndProgram(adopter, adopters);
            }
            else
            {
                while (userInput != "yes" && userInput != "no")
                {
                    Console.WriteLine("Sorry, that is an invalid response. Are you allowed to have pets there? Enter yes or no.");
                    userInput = Console.ReadLine().ToLower();
                    if (userInput == "yes")
                    {
                        petsPermitted = true;
                    }
                    else if (userInput == "no")
                    {
                        petsPermitted = false;
                        Console.WriteLine("Sorry, you are not a good fit for any of the pets if they are prohibitted from your home.");
                        EndProgram(adopter, adopters);
                    }
                }
            } 
            Console.WriteLine("What city and state do you live in? Enter them in the following format: City, State");
            cityState = Console.ReadLine();
            Console.WriteLine("Are there any children living with you? Enter yes or no.");
            userInput = Console.ReadLine().ToLower();
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
                    userInput = Console.ReadLine().ToLower();
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
            Console.WriteLine("How many hours are you home per day? Round to the nearest whole number and enter your response with numbers.");
            hoursHomePerDay = Int32.Parse(Console.ReadLine());
            while (hoursHomePerDay > 24 || hoursHomePerDay < 0)
            {
                Console.WriteLine(hoursHomePerDay + "?! That's impossible. Really though, how many hours are you home per day?");
                hoursHomePerDay = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter any other information you would like to share about yourself and your lifestyle and if there are any other animals living at your home. Notes: ");
            adopterNotes = Console.ReadLine();
            adopterId = adopterId + 1;
            SearchMenu(adopter, adopters);
        }

        public void SearchMenu(Adopter adopter, List<Adopter>adopters)
        {
            Console.WriteLine("Would you like to search for your new pet by ID number, name, species, or breed/color? Enter 1 to search by ID number, 2 to search by name, 3 to search by species, 4 to search by the breed/color, or 5 to leave the humane society.");
            userInput = Console.ReadLine();
            if (userInput == "1")
            {
                SearchByID(adopter, adopters);
            }
            else if (userInput == "2")
            {
                SearchByName(adopter, adopters);
            }
            else if (userInput == "3")
            {
                SearchByAnimal(adopter, adopters);
            }
            else if (userInput == "4")
            {
                SearchByBreedColor(adopter, adopters);
            }
            else if (userInput == "5")
            {
                EndProgram(adopter, adopters);
            }
            else
            {
                Console.WriteLine("Sorry, that is an invalid response.");
                SearchMenu(adopter, adopters);
            }
        }

        public void SearchByID(Adopter adopter, List<Adopter>adopters)
        {
            Console.WriteLine("What is the ID number of the pet for which you are searching?");
            userInput = Console.ReadLine();
            if (userInput == petId)
            {
                Console.WriteLine("Your search returned the following: Species: " + animal + " Name: " + petName + " Adoption Status: " + adoptionStatus + " Gender: " + petGender + " Breed/Color: " + breedColor + " Age: " + petAge + " Room Number: " + roomNumber + " Energy Level: " + energyLevel + " Behavior Report: " + behaviorReport + " Shots: " + shots + " Diet: " + diet + " Notes: " + petNotes + " At the Humane Society Since: " + acceptedDate);
                Adopt(adopter, adopters);
            }
            else if (userInput != petId)
            {
                Console.WriteLine("Sorry, your search did not return any results. Enter 1 to look at the pets or 2 to leave the humane society.");
                userInput = Console.ReadLine();
                if (userInput == "1")
                {
                    SearchMenu(adopter, adopters);
                }
                else if (userInput == "2")
                {
                    EndProgram(adopter, adopters);
                }
                else
                {
                    Console.WriteLine("Sorry, that is an invalid response.");
                    SearchByID(adopter, adopters);
                }
            }
            else
            {
                Console.WriteLine("Sorry, that is an invalid response.");
                SearchByID(adopter, adopters);
            }
        }

        public void SearchByAnimal(Adopter adopter, List<Adopter>adopters)
        {
            Console.WriteLine("What kind of animal are you searching for? (Eg. dog, cat, lizard, bird");
            userInput = Console.ReadLine();
            userInput.ToLower();
            if (userInput == animal)
            {
                Console.WriteLine("Your search returned the following: Species: " + animal + "Breed/Color: " + breedColor + " Name: " + petName + " ID: " + petId + " You can see the full profile of a pet by searching its ID number.");
                SearchByID(adopter, adopters);
            }
            else if (userInput != animal)
            {
                Console.WriteLine("Sorry, your search did not return any results. Enter 1 to search by species again, 2 to look at the pets, or 3 to leave the humane society.");
                userInput = Console.ReadLine();
                if (userInput == "1")
                {
                    SearchByAnimal(adopter, adopters);
                }
                else if (userInput == "2")
                {
                    SearchMenu(adopter, adopters);
                }
                else if (userInput == "3")
                {
                    EndProgram(adopter, adopters);
                }
                else
                {
                    Console.WriteLine("Sorry, that is an invalid response.");
                    SearchByAnimal(adopter, adopters);
                }
            }
            else
            {
                Console.WriteLine("Sorry, that is an invalid response.");
                SearchByAnimal(adopter, adopters);
            }
        }

        public void SearchByBreedColor(Adopter adopter, List<Adopter>adopters)
        {
            Console.WriteLine("What is the breed or color of the pet for which you are searching? Enter either the breed or the color.");
            userInput = Console.ReadLine().ToLower();
            if (userInput == breedColor)
            {
                Console.WriteLine("Your search returned the following: Species: " + animal + "Breed/Color: " + breedColor + " Name: " + petName + " ID: " + petId + " You can see the full profile of a pet by searching its ID number.");
                SearchByID(adopter, adopters);
            }
            else if (userInput != breedColor)
            {
                Console.WriteLine("Sorry, your search did not return any results. Enter 1 to search by breed or color again, 2 to look at the pets, or 3 to leave the humane society.");
                userInput = Console.ReadLine();
                if (userInput == "1")
                {
                    SearchByBreedColor(adopter, adopters);
                }
                else if (userInput == "2")
                {
                    SearchMenu(adopter, adopters);
                }
                else if (userInput == "3")
                {
                    EndProgram(adopter, adopters);
                }
                else
                {
                    SearchByBreedColor(adopter, adopters);
                }
            }
        }

        public void SearchByName(Adopter adopter, List<Adopter>adopters)
        {
            Console.WriteLine("What is the name of the pet for which you are searching?");
            userInput = Console.ReadLine().ToLower();
            if (userInput == petName)
            {
                Console.WriteLine("Your search returned the following: Species: " + animal + "Breed/Color:" + breedColor + " Name: " + petName + " ID: " + petId + " You can see the full profile of a pet by searching its ID number.");
                SearchByID(adopter, adopters);
            }
            else if (userInput != petName)
            {
                Console.WriteLine("Sorry, your search did you return any results. Enter 1 to search by name again, 2 to look at the pets, or 3 to leave the humane society.");
                userInput = Console.ReadLine();
                if (userInput == "1")
                {
                    SearchByName(adopter, adopters);
                }
                else if (userInput == "2")
                {
                    SearchMenu(adopter, adopters);
                }
                else if (userInput == "3")
                {
                    EndProgram(adopter, adopters);
                }
                else
                {
                    Console.WriteLine("Sorry, that is an invalid response.");
                    SearchMenu(adopter, adopters);
                }
            }
        }

        public void Adopt(Adopter adopter, List<Adopter>adopters)
        {
            Console.WriteLine(adopterName + ", would you like to adopt " + petName + " for $200? Enter yes or no.");
            userInput = Console.ReadLine().ToLower();
            if (userInput == "yes")
            {
                Console.WriteLine(employeeName + ", is this adoption in " + petName + "'s best interest? Enter yes to approve the adoption or no to deny it.");
                userInput = Console.ReadLine().ToLower();
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
                    Console.WriteLine("Sorry" + adopterName + ", the adoption has been denied. Enter 1 to look at other pets or 2 to leave the humane society.");
                    userInput = Console.ReadLine();
                    if (userInput == "1")
                    {
                        SearchMenu(adopter, adopters);
                    }
                    else if (userInput == "2")
                    {
                        EndProgram(adopter, adopters);
                    }
                    else
                    {
                        Console.WriteLine("Sorry, that is an invalid response.");
                        SearchMenu(adopter, adopters);
                    }
                }
            }
            else if (userInput == "no")
            {
                adoptAPet = false;
                adoptionStatus = false;
                SearchMenu(adopter, adopters);
            }
            else
            {
                Adopt(adopter, adopters);
            }
        }

        public void EndProgram(Adopter adopter, List<Adopter> adopters)
        {
            Console.WriteLine("Thank you and have a great day! Goodbye!");
            Environment.Exit(0);
        }
    }
}