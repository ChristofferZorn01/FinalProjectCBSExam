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
        int TotalCharges { get; set; }
        int LawyerId { get; set; }

        public Case(int caseId, int clientId, int lawyerId, ESpecialization caseType, DateTime startDate, int totalCharges)
        {
            CaseId = caseId;
            ClientId = clientId;
            CaseType = caseType;
            StartDate = startDate;
            TotalCharges = totalCharges;
            LawyerId = lawyerId;
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
