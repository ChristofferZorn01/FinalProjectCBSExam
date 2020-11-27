using System;
namespace FinalProjectCBSExam
{
    public class Receptionist : EmployeeClass
    {
        public Receptionist(int id, string firstName, string lastName, DateTime dateJoined) : base (id, firstName, lastName, dateJoined)
        {
        }
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
            try
            {
                clientId = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("*** ERROR *** | Input must be an integer. \nPlease try again ");
                clientId = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("First name: ");
            try
            {
                firstName = Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("*** ERROR *** | Input must be a string. \nPlease try again ");
                firstName = Console.ReadLine();
            }

            Console.WriteLine("Last name: ");
            try
            {
                lastName = Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("*** ERROR *** | Input must be a string. \nPlease try again ");
                lastName = Console.ReadLine();
            }
         
            Console.WriteLine("Case type (Corporate = 0 | Family = 1 | Criminal = 2): ");
            caseType = (ESpecialization)int.Parse(Console.ReadLine());

            Console.WriteLine("Street address: ");
            try
            {
                street = Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("*** ERROR *** | Input must be a string. \nPlease try again ");
                street = Console.ReadLine();
            }
            
            Console.WriteLine("Zip code: ");
            try
            {
                zipCode = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("*** ERROR *** | Input must be an integer. \nPlease try again ");
                zipCode = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("City: ");
            try
            {
                city = Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("*** ERROR *** | Input must be a string. \nPlease try again ");
                city = Console.ReadLine();
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

            Console.WriteLine("\n*** ENTER APPOINTMENT DATA BELOW ***\n");
            Console.WriteLine("Appointment ID: ");
            appId = int.Parse(Console.ReadLine());
            Console.WriteLine("Client ID: ");
            clientId = int.Parse(Console.ReadLine());
            Console.WriteLine("Lawyer ID: ");
            lawyerId = int.Parse(Console.ReadLine());
            Console.WriteLine("Appointment date and time [DD-MM-YYYY HH-mm]: ");
            date = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy HH:mm", null);
            Console.WriteLine("Meeting room (Aquarium = 1 | Cube = 2 | Cave = 3): ");
            meetingRoom = (EMeetingRoom)int.Parse(Console.ReadLine());

            Appointment newAppointment = new Appointment(appId, clientId, lawyerId, date, meetingRoom);
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
