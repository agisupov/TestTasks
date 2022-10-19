namespace MeetingConsoleApp.Controllers
{
    public class ValidateMeetingController
    {
        public static bool CheckMeeting(Meeting meeting) => CheckOverlap(meeting) || CheckStartAndFinish(meeting);

        private static bool CheckOverlap(Meeting meeting)
        {
            var datesOverlap = Storage.Meetings.Any(x => meeting != x && meeting.StartDate <= x.EndDate && meeting.EndDate >= x.StartDate);
            if (datesOverlap)
                PrintController.Execute("Внимание! В это время нельзя указать начало/окончание встречи - обнаружено пересечение. Введите даты снова");
            return datesOverlap;
        }

        private static bool CheckStartAndFinish(Meeting meeting)
        {
            var endEariler = meeting.StartDate > meeting.EndDate;
            if (endEariler)
                PrintController.Execute("Встреча не может закончится до ее начала! Введите даты снова");
            return endEariler;
        }
    }
}
