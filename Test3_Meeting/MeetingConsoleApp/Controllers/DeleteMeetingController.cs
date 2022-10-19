namespace MeetingConsoleApp.Controllers
{
    public class DeleteMeetingController
    {
        public static void Execute()
        {
            var meetings = Storage.Meetings;
            if (meetings.Any())
            {
                PrintController.PrintMeetings(meetings);
                PrintController.Execute("Введите ID встречи, которую желаете удалить");
                var meetingId = ReadController.ReadInt();
                var meeting = meetings.FirstOrDefault(x => x.MeetingId == meetingId);
                if (meeting != null)
                {
                    Storage.Meetings.Remove(meeting);
                    ClearController.Clear();
                    PrintController.Execute("Встреча удалена");
                }
                else PrintController.Execute("Встречи с таким ID не существует");
            }
            else PrintController.PrintNoMeetings();
        }
    }
}
