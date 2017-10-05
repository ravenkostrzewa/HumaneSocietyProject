using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Adopter
    {
        int adopterId;
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
        int petId;

        public void CompleteApplication()
        {
            // id = math
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
            //view pets    and search by traits method
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
    }
}