namespace MeetingConsoleApp.Controllers
{
    internal class UpdateMeetingController
    {
        private static List<string> fields = new List<string>() {
            "1. Название",
            "2. Дата начала",
            "3. Дата окончания",
            "4. Дата напоминания"
        };

        public static void Execute()
        {
            var meetings = Storage.Meetings;
            if (meetings.Any())
            {
                PrintController.PrintMeetings(meetings);
                PrintController.Execute("Введите ID встречи, которую хотите изменить");
                var meetId = ReadController.ReadInt();
                var meeting = meetings.FirstOrDefault(x => x.MeetingId == meetId);
                if (meeting != null)
                    SelectField(meeting);
                else PrintController.Execute("Встречи с таким ID не существует");
            }
            else PrintController.PrintNoMeetings();
        }

        private static void SelectField(Meeting meeting)
        {
            fields.ForEach(x => PrintController.Execute(x));
            PrintController.Execute("Выберите номер редактируемого поля");
            var fieldId = ReadController.ReadInt();
            bool success = true;

            switch (fieldId)
            {
                case 1:
                    meeting.SetName();
                    break;
                case 2:
                    SetStartDate(meeting);
                    break;
                case 3:
                    SetEndDate(meeting);
                    break;
                case 4:
                    meeting.SetAlertDate();
                    break;
                default:
                    {
                        PrintController.Execute("Нет поля с таким номером!");
                        success = false;
                    }
                    break;
            }

            if (success) 
                PrintController.Execute("Поле изменено!");
        }

        private static void SetEndDate(Meeting meeting)
        {
            do
            {
                meeting.SetEndDate();
            }
            while (ValidateMeetingController.CheckMeeting(meeting) == true);
        }

        private static void SetStartDate(Meeting meeting)
        {
            do
            {
                meeting.SetStartDate();
            }
            while (ValidateMeetingController.CheckMeeting(meeting) == true);
        }
    }
}
