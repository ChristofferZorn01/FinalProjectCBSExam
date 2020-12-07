using System;
using System.Collections.Generic;
using System.Globalization;

namespace FinalProjectCBSExam
{
    public class Receptionist : EmployeeClass, IReceptionist
    {
        List<string> invalidChars = new List<string>() { "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "1", "2", "3", "4", "5", "6","7","8","9","0" };
        public Receptionist(int id, string firstName, string lastName, DateTime dateJoined) : base (id, firstName, lastName, dateJoined)
        {
        }

        Receptionist receptionist1 = new Receptionist(1, "John", "Doe", new DateTime(1980 / 10 / 10));
        // Method to show the possible user features for Receptionist.
        public void FeaturesReceptionist()
        {
            Console.WriteLine("Which feature do you want to perform?\n1. Add new client\n2. List all clients\n3. Add new appointment\n4. List all appointments\n5. Quit application");
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
            while (!int.TryParse(Console.ReadLine(), out clientId))
            {
                Console.WriteLine("*** ERROR *** | Input must be an integer.\nPlease try again: ");
            }

            Console.WriteLine("First name: ");
            firstName = Console.ReadLine();
            foreach (string s in invalidChars)
            {
                while (firstName.Contains(s))
                {
                    Console.WriteLine("*** ERROR *** | Input must be a string. \nPlease try again ");
                    firstName = Console.ReadLine();
                }
            }

            Console.WriteLine("Last name: ");
            lastName = Console.ReadLine();
            foreach (string s in invalidChars)
            {
                while (lastName.Contains(s))
                {
                    Console.WriteLine("*** ERROR *** | Input must be a string. \nPlease try again ");
                    lastName = Console.ReadLine();
                }
            }

            Console.WriteLine("Case type (Corporate = 0 | Family = 1 | Criminal = 2): ");
            caseType = (ESpecialization)int.Parse(Console.ReadLine());
            while (caseType != ESpecialization.Corporate && caseType != ESpecialization.CriminalCase && caseType != ESpecialization.FamilyCase)
            {
                Console.WriteLine("Invalid. Please try again");
                caseType = (ESpecialization)int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Street address: ");
            street = Console.ReadLine();
            foreach (string s in invalidChars)
            {
                while (street.Contains(s))
                {
                    Console.WriteLine("*** ERROR *** | Input must be a string. \nPlease try again ");
                    street = Console.ReadLine();
                }
            }

            Console.WriteLine("Zip code: ");
            while (!int.TryParse(Console.ReadLine(), out zipCode))
            {
                Console.WriteLine("*** ERROR *** | Input must be an integer.\nPlease try again: ");
            }

            Console.WriteLine("City: ");
            city = Console.ReadLine();
            foreach (string s in invalidChars)
            {
                while (city.Contains(s))
                {
                    Console.WriteLine("*** ERROR *** | Input must be a string. \nPlease try again ");
                    city = Console.ReadLine();
                }
            }


            Client newClient = new Client(clientId, firstName, lastName, caseType, street, zipCode, city);
            clientList.Add(newClient);
            Console.WriteLine("\n*** CLIENT SUCCESSFULLY ADDED TO THE SYSTEM ***\n");
        }

        // Method to add a new appointment.
        public void AddNewAppointment()
        {
            int appId;
            int clientId;
            int lawyerId;
            DateTime date;
            EMeetingRoom meetingRoom;
            int meetingParticipants;

            Console.WriteLine("\n*** ENTER APPOINTMENT DATA BELOW ***\n");
            Console.WriteLine("Appointment ID: ");
            while (!int.TryParse(Console.ReadLine(), out appId))
            {
                Console.WriteLine("*** ERROR *** | Input must be an integer. \nPlease try again ");
            }

            Console.WriteLine("Client ID: ");
            while (!int.TryParse(Console.ReadLine(), out clientId))
            {
                Console.WriteLine("*** ERROR *** | Input must be an integer. \nPlease try again ");
            }

            Console.WriteLine("Lawyer ID: ");
            while (!int.TryParse(Console.ReadLine(), out lawyerId))
            {
                Console.WriteLine("*** ERROR *** | Input must be an integer. \nPlease try again ");
            }

            while (lawyerId == 0 || lawyerId > 26)
            {
                Console.WriteLine("Invalid ID. Please try again");
                lawyerId = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Appointment date and time [dd-MM-yyyy HH:mm]: ");

            while (!DateTime.TryParseExact(Console.ReadLine(), "dd-MM-yyyy HH:mm", null, DateTimeStyles.None, out date))
            {
                Console.WriteLine("*** ERROR *** | Input must be in the right date format [DD-MM-YYYY].\nPlease try again: ");
            }

            Console.WriteLine("Meeting room (Aquarium = 1 | Cube = 2 | Cave = 3): ");

            // NEW (changed "if" to "while" loop)
            meetingRoom = (EMeetingRoom)int.Parse(Console.ReadLine());
            while (meetingRoom != EMeetingRoom.Aquarium && meetingRoom != EMeetingRoom.Cube && meetingRoom != EMeetingRoom.Cave)
            {
                Console.WriteLine("Invalid. Pleas try again");
                meetingRoom = (EMeetingRoom)int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Number of meeting participants: ");
            meetingParticipants = int.Parse(Console.ReadLine());
            if (meetingRoom == EMeetingRoom.Aquarium)
            {
                while (meetingParticipants < 0 || meetingParticipants > 20)
                {
                    Console.WriteLine($"*** ERROR *** | This meeting room ({EMeetingRoom.Aquarium}) has a maximum capacity of 20.\nPlease try again: ");
                    meetingParticipants = int.Parse(Console.ReadLine());
                }
            }
            else if (meetingRoom == EMeetingRoom.Cube)
            {
                while (meetingParticipants < 0 || meetingParticipants < 10)
                {
                    Console.WriteLine($"*** ERROR *** | This meeting room ({EMeetingRoom.Cube}) has a maximum capacity of 10.\nPlease try again: ");
                    meetingParticipants = int.Parse(Console.ReadLine());
                }
            }
            else if (meetingRoom == EMeetingRoom.Cave)
            {
                while (meetingParticipants < 0 || meetingParticipants < 8)
                {
                    Console.WriteLine($"*** ERROR *** | This meeting room ({EMeetingRoom.Cave}) has a maximum capacity of 8.\nPlease try again: ");
                    meetingParticipants = int.Parse(Console.ReadLine());
                }
            }


            Appointment newAppointment = new Appointment(appId, clientId, lawyerId, date, meetingRoom, meetingParticipants);
            appointmentList.Add(newAppointment);
            Console.WriteLine("\n*** APPOINTMENT SUCCESSFULLY ADDED TO THE SYSTEM ***\n");
        }

        public void ListOfClients()
        {
            foreach (object client in caseList)
            {
                Console.WriteLine(client);
            }
            Console.WriteLine($"\nThere is/are {clientList.Count} registered client(s)\n");
        }
    }
}
