using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace FinalProjectCBSExam
{
    public class Lawyer : EmployeeClass, ILawyer
    {
        DateTime DoB { get; set; }
        int Seniority { get; set; }
        ESpecialization SpecializationArea { get; set; }
        static List<Lawyer> lawyerList = new List<Lawyer>();


        public Lawyer(int id, string firstName, string lastName, DateTime dob, int seniority, ESpecialization specializationArea, DateTime dateJoined) : base(id, firstName, lastName, dateJoined)
        {
            DoB = dob;
            Seniority = seniority;
            SpecializationArea = specializationArea;
        }

        private static void AddNewLawyer()
        {
            // 21 Junior Lawyers
            Lawyer juniorL1 = new Lawyer(1, "John", "Doe", new DateTime(1980 / 10 / 10), 10, ESpecialization.Corporate, new DateTime(2010 / 01 / 01));
            Lawyer juniorL2 = new Lawyer(2, "Vincent", "Olivers", new DateTime(1998 / 20 / 07), 12, ESpecialization.Corporate, new DateTime(2008 / 07 / 01));
            Lawyer juniorL3 = new Lawyer(3, "John", "Doe", new DateTime(1980 / 10 / 10), 10, ESpecialization.Corporate, new DateTime(2010 / 01 / 01));
            Lawyer juniorL4 = new Lawyer(4, "Vincent", "Olivers", new DateTime(1998 / 20 / 07), 12, ESpecialization.Corporate, new DateTime(2008 / 07 / 01));
            Lawyer juniorL5 = new Lawyer(5, "John", "Doe", new DateTime(1980 / 10 / 10), 10, ESpecialization.Corporate, new DateTime(2010 / 01 / 01));
            Lawyer juniorL6 = new Lawyer(6, "Vincent", "Olivers", new DateTime(1998 / 20 / 07), 12, ESpecialization.Corporate, new DateTime(2008 / 07 / 01));
            Lawyer juniorL7 = new Lawyer(7, "John", "Doe", new DateTime(1980 / 10 / 10), 10, ESpecialization.Corporate, new DateTime(2010 / 01 / 01));
            Lawyer juniorL8 = new Lawyer(8, "Vincent", "Olivers", new DateTime(1998 / 20 / 07), 12, ESpecialization.Corporate, new DateTime(2008 / 07 / 01));
            Lawyer juniorL9 = new Lawyer(9, "John", "Doe", new DateTime(1980 / 10 / 10), 10, ESpecialization.FamilyCase, new DateTime(2010 / 01 / 01));
            Lawyer juniorL10 = new Lawyer(10, "Vincent", "Olivers", new DateTime(1998 / 20 / 07), 12, ESpecialization.FamilyCase, new DateTime(2008 / 07 / 01));
            Lawyer juniorL11 = new Lawyer(11, "John", "Doe", new DateTime(1980 / 10 / 10), 10, ESpecialization.FamilyCase, new DateTime(2010 / 01 / 01));
            Lawyer juniorL12 = new Lawyer(12, "Vincent", "Olivers", new DateTime(1998 / 20 / 07), 12, ESpecialization.FamilyCase, new DateTime(2008 / 07 / 01));
            Lawyer juniorL13 = new Lawyer(13, "John", "Doe", new DateTime(1980 / 10 / 10), 10, ESpecialization.FamilyCase, new DateTime(2010 / 01 / 01));
            Lawyer juniorL14 = new Lawyer(14, "Vincent", "Olivers", new DateTime(1998 / 20 / 07), 12, ESpecialization.FamilyCase, new DateTime(2008 / 07 / 01));
            Lawyer juniorL15 = new Lawyer(15, "John", "Doe", new DateTime(1980 / 10 / 10), 10, ESpecialization.FamilyCase, new DateTime(2010 / 01 / 01));
            Lawyer juniorL16 = new Lawyer(16, "Vincent", "Olivers", new DateTime(1998 / 20 / 07), 12, ESpecialization.FamilyCase, new DateTime(2008 / 07 / 01));
            Lawyer juniorL17 = new Lawyer(17, "John", "Doe", new DateTime(1980 / 10 / 10), 10, ESpecialization.CriminalCase, new DateTime(2010 / 01 / 01));
            Lawyer juniorL18 = new Lawyer(18, "Vincent", "Olivers", new DateTime(1998 / 20 / 07), 12, ESpecialization.CriminalCase, new DateTime(2008 / 07 / 01));
            Lawyer juniorL19 = new Lawyer(19, "John", "Doe", new DateTime(1980 / 10 / 10), 10, ESpecialization.CriminalCase, new DateTime(2010 / 01 / 01));
            Lawyer juniorL20 = new Lawyer(20, "Vincent", "Olivers", new DateTime(1998 / 20 / 07), 12, ESpecialization.CriminalCase, new DateTime(2008 / 07 / 01));
            Lawyer juniorL21 = new Lawyer(21, "John", "Doe", new DateTime(1980 / 10 / 10), 10, ESpecialization.CriminalCase, new DateTime(2010 / 01 / 01));

            // 5 Senior Lawyers
            Lawyer seniorL1 = new Lawyer(22, "Harvey", "Specter", new DateTime(1972 / 03 / 01), 20, ESpecialization.CriminalCase, new DateTime(1990 / 01 / 01));
            Lawyer seniorL2 = new Lawyer(23, "Louis", "Litt", new DateTime(1972 / 03 / 01), 20, ESpecialization.CriminalCase, new DateTime(1990 / 01 / 01));
            Lawyer seniorL3 = new Lawyer(24, "Harvey", "Specter", new DateTime(1972 / 03 / 01), 20, ESpecialization.CriminalCase, new DateTime(1990 / 01 / 01));
            Lawyer seniorL4 = new Lawyer(25, "Louis", "Litt", new DateTime(1972 / 03 / 01), 20, ESpecialization.CriminalCase, new DateTime(1990 / 01 / 01));
            Lawyer seniorL5 = new Lawyer(26, "Harvey", "Specter", new DateTime(1972 / 03 / 01), 20, ESpecialization.CriminalCase, new DateTime(1990 / 01 / 01));

            lawyerList.Add(juniorL1);
            lawyerList.Add(juniorL2);
            lawyerList.Add(juniorL3);
            lawyerList.Add(juniorL4);
            lawyerList.Add(juniorL5);
            lawyerList.Add(juniorL6);
            lawyerList.Add(juniorL7);
            lawyerList.Add(juniorL8);
            lawyerList.Add(juniorL9);
            lawyerList.Add(juniorL10);
            lawyerList.Add(juniorL11);
            lawyerList.Add(juniorL12);
            lawyerList.Add(juniorL13);
            lawyerList.Add(juniorL14);
            lawyerList.Add(juniorL15);
            lawyerList.Add(juniorL16);
            lawyerList.Add(juniorL17);
            lawyerList.Add(juniorL18);
            lawyerList.Add(juniorL19);
            lawyerList.Add(juniorL20);
            lawyerList.Add(juniorL21);
            lawyerList.Add(seniorL1);
            lawyerList.Add(seniorL2);
            lawyerList.Add(seniorL3);
            lawyerList.Add(seniorL4);
            lawyerList.Add(seniorL5);
        }

        public void FeaturesLawyer()
        {
            Console.WriteLine("Which feature do you want to perform?\n1. Add new case\n2. List all cases \n3. List appointsments \n4. Quit application");
        }

        public void AddNewCase()
        {
            // NEW (Add the lawyers data to the system's memory)
            AddNewLawyer();

            int caseId;
            int clientId;
            ESpecialization caseType;
            DateTime startDate;
            int totalCharges;
            int lawyerId;


            // CHECK ON TRY/CATCH BLOCKS, THEY ALLOW FOR REPITITION WHICH IS NOT DESIRABLE !!!
            Console.WriteLine("\n*** ENTER CASE DATA BELOW ***\n");

            Console.WriteLine("Case ID: ");
            while (!int.TryParse(Console.ReadLine(), out caseId))
            {
                Console.WriteLine("*** ERROR *** | Input must be an integer.\nPlease try again: ");
            }

            /*try
            {
                 caseId = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {

                Console.WriteLine("*** ERROR *** | Input must be an integer.\nPlease try again: ");
                caseId = int.Parse(Console.ReadLine());
            }*/


            Console.WriteLine("Client ID: ");
            while (!int.TryParse(Console.ReadLine(), out clientId))
            {
                Console.WriteLine("*** ERROR *** | Input must be an integer.\nPlease try again: ");
            }

            /*try
            {
                clientId = int.Parse(Console.ReadLine());
            }
            
            catch (FormatException)
            {
                Console.WriteLine("*** ERROR *** | Input must be an integer.\nPlease try again: ");
                clientId = int.Parse(Console.ReadLine());
            }*/


            Console.WriteLine("Lawyer ID: ");
            while (!int.TryParse(Console.ReadLine(), out lawyerId))
            {
                Console.WriteLine("*** ERROR *** | Input must be an integer.\nPlease try again: ");
            }
            /*try
            {
                lawyerId = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("*** ERROR *** | Input must be an integer.\nPlease try again: ");
                lawyerId = int.Parse(Console.ReadLine());
            }*/

            // NEW
            while (lawyerId == 0 || lawyerId > 26)
            {
                Console.WriteLine("Invalid ID. Please try again: ");
                lawyerId = int.Parse(Console.ReadLine());
            }

            // NEW (changed "if" to "while" loop)
            Console.WriteLine("Case type (Corporate = 0 | Family = 1 | Criminal = 2): ");
            caseType = (ESpecialization)int.Parse(Console.ReadLine());
            while (caseType != ESpecialization.Corporate && caseType != ESpecialization.CriminalCase && caseType != ESpecialization.FamilyCase)
            {
                Console.WriteLine("Invalid. Please try again: ");
                caseType = (ESpecialization)int.Parse(Console.ReadLine());
            }

            // NEW (bonus question)
            foreach (Lawyer lawyer in lawyerList)
            {
                if (lawyer.Id == lawyerId)
                {
                    while (lawyer.SpecializationArea != caseType)
                    {
                        Console.WriteLine($"This case type does not correspond with the lawyer's (ID = {lawyerId}) specialization area ({lawyer.SpecializationArea}). Please try again: ");
                        caseType = (ESpecialization)int.Parse(Console.ReadLine());
                    }
                }
                // Statement below not necessary but just for clarity on how the loop works.
                else
                {
                    continue;
                }
            }

            Console.WriteLine("Start date [DD-MM-YYYY]: ");
            while (!DateTime.TryParseExact(Console.ReadLine(), "dd-MM-yyyy", null, DateTimeStyles.None, out startDate))
            {
                Console.WriteLine("*** ERROR *** | Input must be in the right date format [DD-MM-YYYY].\nPlease try again: ");
            }
            /*try
            {
                startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);
            }
            catch (FormatException)
            {
                Console.WriteLine("*** ERROR *** | Input must be in the right date format [DD-MM-YYYY].\nPlease try again: ");
                startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);
            }*/




            Console.WriteLine("Total charges (in €): ");
            while (!int.TryParse(Console.ReadLine(), out totalCharges))
            {
                Console.WriteLine("*** ERROR *** | Input must be an integer.\nPlease try again: ");
            }
            /*try
            {
                totalCharges = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("*** ERROR *** | Input must be an integer.\nPlease try again: ");
                totalCharges = int.Parse(Console.ReadLine());
            }*/


            Case newCase = new Case(caseId, clientId, lawyerId, caseType, startDate, totalCharges);
            caseList.Add(newCase);
            Console.WriteLine("\n*** CASE SUCCESSFULLY ADDED TO THE SYSTEM ***\n");

        }

        public override string ToString()
        {
            StringBuilder textOutput = new StringBuilder();
            textOutput.Append(base.ToString());
            textOutput.AppendLine($"Date of birth: {DoB}");
            textOutput.AppendLine($"Seniority: {Seniority}");
            textOutput.AppendLine($"Specialization: {SpecializationArea}");
            return textOutput.ToString();
        }


    }
}



