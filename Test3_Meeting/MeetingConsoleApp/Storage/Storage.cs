namespace MeetingConsoleApp
{
    public static class Storage
    {
        private static List<Meeting> meetings = new List<Meeting>();

        public static List<Meeting> Meetings => meetings;
    }
}
