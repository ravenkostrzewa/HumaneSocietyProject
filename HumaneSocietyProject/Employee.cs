using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Employee
    {
        public string employeeName;
        public int collectedAdoptionFee;
        public string userInput;
        public int userResponse;
        public int petId;
        public string animal;
        public int roomNumber = 101;
        public bool adoptionStatus;
        public string petName;
        public string breedColor;
        public string petGender;
        public string petAge;
        public string familyPet;
        public string acceptedDate;
        public string energyLevel;
        public string behaviorReport;
        public bool shots;
        public string diet;
        public string petNotes;
        public bool employee;
        public string customer;
        public string employed;

        List<Adopter> adopterList = new List<Adopter>();

        public void EmployeeWork(Adopter adopter, List<Adopter>adopters)
        {
            Console.WriteLine("What is your next task? Enter 1 to create a new pet profile, 2 to see if a pet has been adopted yet, 3 to see if a pet has had its shots, or 4 to assist a customer.");
            userInput = Console.ReadLine();
            if (userInput == "1")
            {
                CreateNewPetProfile(adopter, adopters);
            }
            else if (userInput == "2")
            {
                CheckAdoptionStatus(adopter, adopters);
            }
            else if (userInput == "3")
            {
                CheckShotStatus(adopter, adopters);
            }
            else if (userInput == "4")
            {
                adopter.GetAdopterId(adopter, adopters);
            }
            else
            {
               EmployeeWork(adopter, adopters);
            }
        }

        public void CreateNewPetProfile(Adopter adopter, List<Adopter>adopters)
        {
            //petId is created automatically since it is the primary key
            adoptionStatus = false;
            Console.WriteLine("What kind of animal is this? (Eg. dog, cat, lizard, bird)");
            animal = Console.ReadLine();
            animal.ToLower();
            Console.WriteLine("What is the " + animal + "'s name?");
            petName = Console.ReadLine();
            roomNumber = roomNumber + 1;
            Console.WriteLine("Room " + roomNumber + " has been prepared for " + petName + "!");
            Console.WriteLine("What breed or color is " + petName + "?");
            breedColor = Console.ReadLine();
            breedColor.ToLower();
            Console.WriteLine("What gender is " + petName + "? Enter male or female.");
            userInput = Console.ReadLine();
            userInput.ToLower();
            if (userInput == "male")
            {
                petGender = "male";
            }
            else if (userInput == "female")
            {
                petGender = "female";
            }
            else
            {
                while (userInput != "male" && userInput != "female")
                {
                    Console.WriteLine("What gender is " + petName + "? Enter male or female.");
                    userInput = Console.ReadLine();
                    if (userInput == "male")
                    {
                        petGender = "male";
                    }
                    else if (userInput == "female")
                    {
                        petGender = "female";
                    }
                }
            }
            Console.WriteLine("When was " + petName + " first brought to the humane society? Enter the month and year in the following format: 08/2017");
            acceptedDate = Console.ReadLine();
            Console.WriteLine("Do you know " + petName + "'s date of birth? Enter yes or no.");
            userInput = Console.ReadLine();
            userInput.ToLower();
            if (userInput == "yes")
            {
                Console.WriteLine("Enter " + petName + "'s date of birth. Use numbers, avoid backslashes or other symbols.");
                petAge = Console.ReadLine();
            }
            else if (userInput == "no")
            {
                Console.WriteLine("How old would you estimate that " + petName + " is? Estimate in years, months, or weeks accordingly.");
                petAge = Console.ReadLine();
            }
            else
            {
                while (userInput != "yes" && userInput != "no")
                    {
                    Console.WriteLine("Do you know " + petName + "'s date of birth?");
                    if (userInput == "yes")
                    {
                        Console.WriteLine("Enter " + petName + "'s date of birth. Use numbers, avoid backslashes or other symbols.");
                        petAge = Console.ReadLine();
                    }
                    else if (userInput == "no")
                    {
                        Console.WriteLine("How old would you estimate that " + petName + " is? Estimate in years, months, or weeks accordingly.");
                        petAge = Console.ReadLine();
                    }
                }
            }
            Console.WriteLine("Would " + petName + " make a good family pet? Enter yes, no, or, if you think it has potential, enter with training.");
            familyPet = Console.ReadLine();
            familyPet.ToLower();
            Console.WriteLine("Describe " + petName + "'s energy level?");
            energyLevel = Console.ReadLine();
            Console.WriteLine("Describe " + petName + "'s behavior.");
            behaviorReport = Console.ReadLine();
            Console.WriteLine("Has " + petName + " had its shots? Enter yes or no.");
            userInput = Console.ReadLine();
            userInput.ToLower();
            if (userInput == "yes")
            {
                shots = true;
            }
            else if (userInput == "no")
            {
                shots = false;
            }
            else
            {
                while (userInput != "yes" && userInput != "no")
                {
                    Console.WriteLine("Sorry, that is an invalid response. Has " + petName + " had its shots? Enter yes or no.");
                    userInput = Console.ReadLine();
                    userInput.ToLower();
                    if (userInput == "yes")
                    {
                        shots = true;
                    }
                    else if (userInput == "no")
                    {
                        shots = false;
                    }
                }
            }
            Console.WriteLine("What does " + petName + " eat? How much? How often?");
            diet = Console.ReadLine();
            Console.WriteLine("Notes:");
            petNotes = Console.ReadLine();
            EmployeeWork(adopter, adopters);
        }

        public void CheckAdoptionStatus(Adopter adopter, List<Adopter>adopters)
        {
            Console.WriteLine("Enter the ID of the pet for which you would like to check the adoption status.");
            userResponse = Int32.Parse(Console.ReadLine());
            if (userResponse == petId)
            {
                if (adoptionStatus == true)
                {
                    Console.WriteLine(petId + " has already been adopted!");
                }
                else if (adoptionStatus == false)
                {
                    Console.WriteLine(petId + " has not been adopted yet.");
                }
            }
            else if (userResponse != petId)
            {
                Console.WriteLine("Sorry, that ID does not belong to any of the pets in the database. Enter 1 to try searching again, 2 to move on to a different task, or 3 to clock out.");
                userInput = Console.ReadLine();
                if (userInput == "1")
                {
                    CheckAdoptionStatus(adopter, adopters);
                }
                else if (userInput == "2")
                {
                    EmployeeWork(adopter, adopters);
                }
                else if (userInput == "3")

                {
                    adopter.EndProgram(adopter, adopters);
                }
                else
                {
                    Console.WriteLine("Sorry, that is an invalid response.");
                    CheckAdoptionStatus(adopter, adopters);
                }
            }
        }

        public void CheckShotStatus(Adopter adopter, List<Adopter>adopters)
        {
            Console.WriteLine("To check to see if a pet has had its shots yet, enter its ID number.");
            userResponse = Int32.Parse(Console.ReadLine());
            if (petId == userResponse)
            {
                if (shots == true)
                {
                    Console.WriteLine(petId + " has had its shots.");
                }
                else if (shots == false)
                {
                    Console.WriteLine(petId + " has not had its shots yet. Would you like to take it to the veterinarian so that it can have its shots? Enter yes or no.");
                    userInput = Console.ReadLine();
                    if (userInput == "yes")
                    {
                        shots = true;
                        Console.WriteLine(petName + " got its shots. Great work!");
                    }
                    else if (userInput == "no")
                    {
                        shots = false;
                    }
                    else
                    {
                        while (userInput != "yes" && userInput != "no")
                        {
                            Console.WriteLine("Sorry, that is an invalid response.");
                            Console.WriteLine("Has " + petName + " had its shots? Enter yes or no.");
                            userInput = Console.ReadLine();
                            userInput.ToLower();
                            if (userInput == "yes")
                            {
                                shots = true;
                            }
                            else if (userInput == "no")
                            {
                                shots = false;
                            }
                        }
                    }
                }
                }
                else if (petId != userResponse)
                {
                    Console.WriteLine("Sorry, that ID does not belong to any of the pets in the database. Enter 1 to try searching again, 2 to move on to a different task, or 3 to clock out.");
                    userInput = Console.ReadLine();
                    if (userInput == "1")
                    {
                        CheckShotStatus(adopter, adopters);
                    }
                    else if (userInput == "2")
                    {
                        EmployeeWork(adopter, adopters);
                    }
                    else if (userInput == "3")
                    {
                       Adopter adopt = new Adopter();
                       adopter.EndProgram(adopter, adopters);
                    }
                    else
                    {
                        CheckShotStatus(adopter, adopters);
                    }
                }
            }
        }
    }