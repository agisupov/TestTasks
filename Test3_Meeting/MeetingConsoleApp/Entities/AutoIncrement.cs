namespace MeetingConsoleApp.Entities
{
    public class AutoIncrement
    {
        private static int id = 1;
        public static int GenerateId()
        {
            return id++;
        }
    }
}
