using System;
namespace FinalProjectCBSExam
{
    public class Admin : EmployeeClass
    {
        string Role { get; set; }
        public Admin(int id, string firstName, string lastName, DateTime dateJoined, string role) : base (id, firstName,lastName,dateJoined)
        {
            Role = role;
        }

        // Method to show the possible user features for Admin.
        public void FeaturesAdmin()
        {
            Console.WriteLine("Which feature do you want to perform?\n1. List all cases\n2. List all appointments\n3. Quit application");
        }

    }
}
