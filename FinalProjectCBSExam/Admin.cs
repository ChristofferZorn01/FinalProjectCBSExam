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

        Admin admin1 = new Admin(1, "John", "Doe", new DateTime(1980 / 10 / 10), "Admin");
        Admin admin2 = new Admin(2, "John", "Hansen", new DateTime(1981 / 9 / 10), "Co-Admin");
        Admin admin3 = new Admin(3, "John", "Jensen", new DateTime(1982 / 15 / 10), "Intern");

        // Method to show the possible user features for Admin.
        public void FeaturesAdmin()
        {
            Console.WriteLine("Which feature do you want to perform?\n1. List all cases\n2. List all appointments\n3. Quit application");
        }

    }
}
