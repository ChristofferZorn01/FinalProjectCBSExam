using System;
using System.Collections.Generic;

namespace FinalProjectCBSExam
{
    public class Processor
    {
        // Variables 
        private string Username;
        private string Password;
        private string UserNameInSystem = "admin";
        private string PasswordInSystem = "123";
        private int userInput;
        private int featureChoice;

        // Lists
        List<Client> clientList = new List<Client>();
        List<Appointment> appointmentList = new List<Appointment>();

        // Starting Screen with user prompts
        public void StartScreen()
        {
            Console.WriteLine($"*** {TimeBasedGreeting()}! Welcome to the administration system of LegalX! ***\n");
            Console.WriteLine("What employee type are you?\n1. Lawyer\n2. Admin\n3. Receptionist");
            userInput = int.Parse(Console.ReadLine());
        }

        // Method to greet the user based on the time of the day the application is accessed.
        public static string TimeBasedGreeting()
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

            if (Username == UserNameInSystem && Password == PasswordInSystem)
            {
                Console.WriteLine("\n*** Access granted ***\n");
                return true;
            }
            else
            {
                Console.WriteLine("You are not authorized to access this system. Please contact an administrator");
                return false;
            }
        }

        // Method to add a new client.
        public void AddNewClient()
        {
            int clientId;
            string firstName;
            string lastName;
            ESpecialization caseType;
            string street;
            int zipCode;
            string city;

            Console.WriteLine("\n*** ENTER CLIENT DATA BELOW ***\n");
            Console.WriteLine("Client ID: ");
            clientId = int.Parse(Console.ReadLine());
            Console.WriteLine("First name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Last name: ");
            lastName = Console.ReadLine();
            Console.WriteLine("Case type (Corporate = 0 | Family = 1 | Criminal = 2): ");
            caseType = (ESpecialization)int.Parse(Console.ReadLine());
            Console.WriteLine("Street address: ");
            street = Console.ReadLine();
            Console.WriteLine("Zip code: ");
            zipCode = int.Parse(Console.ReadLine());
            Console.WriteLine("City: ");
            city = Console.ReadLine();

            Client newClient = new Client(clientId, firstName, lastName, caseType, street, zipCode, city);
            clientList.Add(newClient);
            Console.WriteLine("\n*** CLIENT SUCCESSFULLY ADDED TO THE SYSTEM ***\n");
        }

        public void ListOfAppointments()
        {
            foreach (object appointment in appointmentList)
            {
                Console.WriteLine(appointment);
            }
            Console.WriteLine($"\nThere is/are {appointmentList.Count} registered appointsment(s)\n");
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
                        Lawyer newLawyer = new Lawyer(1, "John", "Doe", new DateTime(1980 / 10 / 10), 10, ESpecialization.Coporate, new DateTime(2010 / 01 / 01));
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
                                ListOfAppointments();
                                break;
                        }
                    }
                }
            } /*
            else if (userInput == 2)
            {
                if (LoginSystem() == true)
                {
                    while (featureChoice != 3)
                    {
                        FeaturesAdmin();
                        featureChoice = int.Parse(Console.ReadLine());
                        switch (featureChoice)
                        {
                            case 1:
                                Console.WriteLine("Test");
                                break;
                            case 2:
                                ListOfAppointments();
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
                        FeaturesReceptionist();
                        featureChoice = int.Parse(Console.ReadLine());
                        switch (featureChoice)
                        {
                            case 1:
                                AddNewClient();
                                break;
                            case 2:
                                ListOfClients();
                                break;
                            case 3:
                                AddNewAppointment();
                                break;
                            case 4:
                                ListOfAppointments();
                                break;
                        }
                    }
                }
            } */
        }

    }

}
