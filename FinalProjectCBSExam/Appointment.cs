using System;
using System.Text;

namespace FinalProjectCBSExam
{
    public class Appointment
    {
        int AppId { get; set; }
        int ClientId { get; set; }
        int LawyerId { get; set; }
        DateTime Date { get; set; }
        EMeetingRoom MeetingRoom { get; set; }
        int MeetingParticipants { get; set; }

        public Appointment(int appId, int clientId, int lawyerId, DateTime date, EMeetingRoom meetingRoom, int meetingParticipants)
        {
            AppId = appId;
            ClientId = clientId;
            LawyerId = lawyerId;
            Date = date;
            MeetingRoom = meetingRoom;
            MeetingParticipants = meetingParticipants;
        }

        public override string ToString()
        {
            StringBuilder textOutput = new StringBuilder();
            textOutput.AppendLine($"\nAppointment ID: {AppId}");
            textOutput.AppendLine($"\nClient ID: {ClientId}");
            textOutput.AppendLine($"\nLawyer ID: {LawyerId}");
            textOutput.AppendLine($"\nCase date: {Date}");
            textOutput.AppendLine($"\nMeeting room: {MeetingRoom}");
            textOutput.AppendLine($"\nNumber of meeting participants: {MeetingParticipants}");
            return textOutput.ToString();
        }
    }
}
