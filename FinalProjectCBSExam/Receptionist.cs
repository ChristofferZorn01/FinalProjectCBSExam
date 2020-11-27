using System;
namespace FinalProjectCBSExam
{
    public class Receptionist : EmployeeClass
    {
        public Receptionist(int id, string firstName, string lastName, DateTime dateJoined) : base (id, firstName, lastName, dateJoined)
        {
        }
        // Method to show the possible user features for Receptionist.
        public static void FeaturesReceptionist()
        {
            Console.WriteLine("Which feature do you want to perform?\n1. Add new client\n2. List all clients\n3. Add new appointment\n4. List all appointments\n5. Quit application");
        }
    }
}
