namespace MeetingConsoleApp.Controllers
{
    internal class CreateMeetingController
    {
        internal static void Execute()
        {
            var meeting = new Meeting();
            meeting.SetName();
            meeting.SetDates();

            Storage.Meetings.Add(meeting);
            ClearController.Clear();
            PrintController.Execute("Встреча добавлена!");
        }
    }
}
