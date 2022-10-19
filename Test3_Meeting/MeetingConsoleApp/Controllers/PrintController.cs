namespace MeetingConsoleApp.Controllers
{
    public class PrintController
    {
        public static void Execute(string message)
        {
            Print(message);
        }

        public static void Print(string message)
        {
            Console.WriteLine(message);
        }

        public static void PrintNoMeetings()
        {
            Execute("Список встреч пуст!");
        }

        public static void PrintMeetings(List<Meeting> meetings, bool isSaving = false)
        {
            ClearController.Clear();
            meetings.ForEach(x => Execute(x.ToString()));
            if (isSaving) 
                SaveToFileController.Execute(meetings);
        }

        public static void PrintAlertMeetings(List<Meeting> meetings)
        {
            Execute("----- Напоминание о встречах: -----");
            meetings.ForEach(x => Execute(x.ToString()));
            Execute("");
        }
    }
}
