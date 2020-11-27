using System;
using System.Text;

namespace FinalProjectCBSExam
{
    public class Case 
    {
        int CaseId { get; set; }
        int ClientId { get; set; }
        ESpecialization CaseType { get; set; }
        DateTime StartDate { get; set; }
        public double totalcharges;
        int LawyerId { get; set; }

        public Case(int caseId, int clientId, int lawyerId, ESpecialization caseType, DateTime startDate, double totalCharges)
        {
            CaseId = caseId;
            ClientId = clientId;
            CaseType = caseType;
            StartDate = startDate;
            TotalCharges = totalCharges;
            LawyerId = lawyerId;
        }

        public double TotalCharges
        {
            get
            {
                return totalcharges;
            }
            set
            {
                if (value < 200)
                {
                    Console.WriteLine("*** ERROR | Charged amount must be greater than 200. Please try again: ");
                    totalcharges = int.Parse(Console.ReadLine());
                }
                totalcharges = value;
            }
        }

        public override string ToString()
        {
            StringBuilder textOutput = new StringBuilder();
            textOutput.AppendLine($"\nCase ID: {CaseId}");
            textOutput.AppendLine($"\nClient ID: {ClientId}");
            textOutput.AppendLine($"\nLawyer ID: {LawyerId}");
            textOutput.AppendLine($"\nCase type: {CaseType}");
            textOutput.AppendLine($"\nStart date: {StartDate}");
            textOutput.AppendLine($"\nTotal charges: €{TotalCharges}");
            return textOutput.ToString();
        }
    }
}
