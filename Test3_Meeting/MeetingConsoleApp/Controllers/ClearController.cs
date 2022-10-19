namespace MeetingConsoleApp.Controllers
{
    internal class ClearController
    {
        public static void Clear()
        {
            Console.Clear();
            MenuWorker.PrintMenu();
        }
    }
}
