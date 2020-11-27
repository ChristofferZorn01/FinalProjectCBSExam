using System;
using System.Text;

namespace FinalProjectCBSExam
{
    public class Client
    {
        int ClientId{ get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        ESpecialization CaseType { get; set; }
        string Street { get; set; }
        int ZipCode { get; set; }
        string City { get; set; }

        public Client(int clientId, string firstName, string lastName, ESpecialization caseType, string street, int zipCode, string city)
        {
            ClientId = clientId;
            FirstName = firstName;
            LastName = lastName;
            CaseType = caseType;
            Street = street;
            ZipCode = zipCode;
            City = city;
        }

        public override string ToString()
        {
            StringBuilder textOutput = new StringBuilder();
            textOutput.AppendLine($"\nClient ID: {ClientId}");
            textOutput.AppendLine($"\nFirst name: {FirstName}");
            textOutput.AppendLine($"\nLast name: {LastName}");
            textOutput.AppendLine($"\nCase type: {CaseType}");
            textOutput.AppendLine($"\nStreet: {Street}");
            textOutput.AppendLine($"\nZip code: {ZipCode}");
            textOutput.AppendLine($"\nCity: {City}");
            return textOutput.ToString();
        }
    }
}
