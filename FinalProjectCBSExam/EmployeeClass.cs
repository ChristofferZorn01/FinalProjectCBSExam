using System;
namespace FinalProjectCBSExam
{
    public abstract class EmployeeClass
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        DateTime DateJoined { get; set; }

        public EmployeeClass(int id, string firstName, string lastName, DateTime dateJoined)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            DateJoined = dateJoined;
        }
    }
}
