using System;
using System.Collections.Generic;

namespace FinalProjectCBSExam
{
    public abstract class EmployeeClass
    {
        public int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        DateTime DateJoined { get; set; }
        public static List<Case> caseList = new List<Case>();
        public static List<Appointment> appointmentList = new List<Appointment>();
        public static List<Client> clientList = new List<Client>(); 

        public EmployeeClass(int id, string firstName, string lastName, DateTime dateJoined)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            DateJoined = dateJoined;
        }

        public void ListAllCases()
        {
            foreach (object lcase in caseList)
            {
                Console.WriteLine(lcase);
            }
            Console.WriteLine($"\nThere is/are {caseList.Count} registered case(s)\n");
        }

        public void ListOfAppointments()
        {
            foreach (object appointment in appointmentList)
            {
                Console.WriteLine(appointment);
            }
            Console.WriteLine($"\nThere is/are {appointmentList.Count} registered appointsment(s)\n");
        }

    }
}
