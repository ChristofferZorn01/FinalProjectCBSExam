using System;
namespace FinalProjectCBSExam
{
    public class Lawyer : EmployeeClass
    {
        DateTime DoB { get; set; }
        int Seniority { get; set; }
        ESpecialization SpecializationArea { get; set; }
        List<Case> caseList = new List<Case>();


        public Lawyer(int id, string firstName, string lastName, DateTime dob, int seniority, ESpecialization specializationArea, DateTime dateJoined) : base(id, firstName, lastName, dateJoined)
        {
            DoB = dob;
            Seniority = seniority;
            SpecializationArea = specializationArea;
        }


        public void FeaturesLawyer()
        {
            Console.WriteLine("Which feature do you want to perform?\n1. Add new case\n2. List all cases \n3. List appointsments \n4. Quit application");
        }

        public void AddNewCase()
        {
            int caseId;
            int clientId;
            ESpecialization caseType;
            DateTime startDate;
            int totalCharges;
            int lawyerId;

            Console.WriteLine("\n*** ENTER CASE DATA BELOW ***\n");
            Console.WriteLine("Case ID: ");
            try
            {
                caseId = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("*** ERROR *** | Input must be an integer. \nPlease try again ");
                clientId = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Lawyer ID: ");
            try
            {
                lawyerId = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("*** ERROR *** | Input must be an integer. \nPlease try again: ");
                lawyerId = int.Parse(Console.ReadLine());


                // Find out the exception handling for invalid enums
                Console.WriteLine("Case type (Corporate = 0 | Family = 1 | Criminal = 2): ");
                caseType = (ESpecialization)
        }

    }
}
