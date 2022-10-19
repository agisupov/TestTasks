namespace MeetingConsoleApp.Controllers
{
    public class ShowMeetingsController
    {
        public static void ExecuteShowAll()
        {
            var meetings = Storage.Meetings;
            if (meetings.Any())
                PrintController.PrintMeetings(meetings, true);
            else
                PrintController.PrintNoMeetings();
        }

        public static void ExecuteShowSpecifiedDay()
        {
            var date = ReadController.ReadDateOnly();
            var meetings = Storage.Meetings.Where(x => x.StartDate.Date == date).ToList();

            if (meetings.Any())
                PrintController.PrintMeetings(meetings, true);
            else
                PrintController.PrintNoMeetings();
        }
    }
}
