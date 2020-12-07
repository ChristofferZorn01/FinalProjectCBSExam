using System;
using System.Collections.Generic;
using FinalProject_Individual;

namespace FinalProjectCBSExam
{
    public class Processor : IProcessor
    {
        // Variables 
        private string Username;
        private string Password;
        private string UserNameInSystem = "admin";
        private string PasswordInSystem = "123";
        private int userInput;
        private int featureChoice;

        // Starting Screen with user prompts
        public void StartScreen()
        {
            Console.WriteLine($"*** {TimeBasedGreeting()}! Welcome to the administration system of LegalX! ***\n");
            Console.WriteLine("What employee type are you?\n1. Lawyer\n2. Admin\n3. Receptionist");
            while (!int.TryParse(Console.ReadLine(), out userInput))
            {
                Console.WriteLine("*** ERROR *** | Input must be an integer.\nPlease try again: ");
            }
        }

        // Method to greet the user based on the time of the day the application is accessed.
        public string TimeBasedGreeting()
        {
            DateTime now = DateTime.Now;
            int nowHours = now.Hour;
            int morning = 4;
            int afternoon = 12;
            int evening = 17;
            int night = 23;
            string greeting = String.Empty;


            if (nowHours >= morning && nowHours < afternoon && nowHours < evening && nowHours <= night)
            {
                greeting = "Good morning";
            }
            else if (nowHours >= afternoon && nowHours >= morning && nowHours < evening && nowHours <= night)
            {
                greeting = "Good afternoon";
            }
            else if (nowHours >= morning && nowHours >= afternoon && nowHours >= evening && nowHours <= night)
            {
                greeting = "Good evening";
            }
            else if (nowHours <= morning && nowHours <= afternoon && nowHours <= evening && nowHours <= night)
            {
                greeting = "Good night";
            }
            return greeting;
        }

        public bool LoginSystem()
        {
            Console.WriteLine("\nPlease provide username: ");
            Username = Console.ReadLine();
            Console.WriteLine("\nPlease provide password: ");
            Password = Console.ReadLine();

            while(Username != UserNameInSystem || Password != PasswordInSystem)
            {
                Console.WriteLine("\nYou are not authorized to access this system. Please contact an administrator or try again: ");
                Console.WriteLine("\nPlease provide username: ");
                Username = Console.ReadLine();
                Console.WriteLine("\nPlease provide password: ");
                Password = Console.ReadLine();
            }
            Console.WriteLine("\n*** ACCES GRANTED ***\n");
            return true;

            
        }


        public void AppProcessor()
        {
            StartScreen();
            if (userInput == 1)
            {
                if (LoginSystem() == true)
                {
                    while (featureChoice != 4)
                    {
                        Lawyer newLawyer = new Lawyer(1, "John", "Doe", new DateTime(1980 / 10 / 10), 10, ESpecialization.Corporate, new DateTime(2010 / 01 / 01));
                        newLawyer.FeaturesLawyer();
                        featureChoice = int.Parse(Console.ReadLine());
                        switch (featureChoice)
                        {
                            case 1:
                                newLawyer.AddNewCase();
                                break;
                            case 2:
                                newLawyer.ListAllCases();
                                break;
                            case 3:
                                newLawyer.ListOfAppointments();
                                break;
                        }
                    }
                }
            }
            else if (userInput == 2)
            {
                if (LoginSystem() == true)
                {
                    while (featureChoice != 3)
                    {
                        Admin newAdmin = new Admin(2, "Jens", "Hansen", new DateTime(1982 / 10 / 08), "Intern");
                        newAdmin.FeaturesAdmin();
                        featureChoice = int.Parse(Console.ReadLine());
                        switch (featureChoice)
                        {
                            case 1:
                                newAdmin.ListAllCases();
                                break;
                            case 2:
                                newAdmin.ListOfAppointments();
                                break;
                        }
                    }
                }
            }
            else if (userInput == 3)
            {
                if (LoginSystem() == true)
                {
                    while (featureChoice != 5)
                    {
                        Receptionist newReceptionist = new Receptionist(3, "Mie", "Jensen", new DateTime(1981 / 10 / 01));
                        newReceptionist.FeaturesReceptionist();
                        featureChoice = int.Parse(Console.ReadLine());
                        switch (featureChoice)
                        {
                            case 1:
                                newReceptionist.AddNewClient();
                                break;
                            case 2:
                                newReceptionist.ListOfClients();
                                break;
                            case 3:
                                newReceptionist.AddNewAppointment();
                                break;
                            case 4:
                                newReceptionist.ListOfAppointments();
                                break;
                        }
                    }
                }
            }
            else
            {
                while (userInput != 1 | userInput != 2 | userInput != 3)
                {
                    Console.WriteLine("\nThis is an invalid employee type. Choose either 1, 2, or 3: \n");
                    AppProcessor();
                    userInput = int.Parse(Console.ReadLine());
                }
                
            }
        }

    }

}
