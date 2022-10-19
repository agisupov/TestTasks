namespace MeetingConsoleApp.Models
{
    public class Meeting
    {
        private readonly int id;
        public int MeetingId => id;
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime AlertDate { get; set; }

        public Meeting()
        {
            id = AutoIncrement.GenerateId();
        }

        public override string ToString() => string.Format("\nID = {0}\nНазвание: {1}\nНачало: {2}\nОкончание: {3}\nНапоминание в: {4}", 
            MeetingId,
            Name,
            StartDate.ToString("g"),
            EndDate.ToString("g"),
            AlertDate.ToString("g"));

        public void SetDates()
        {
            do
            {
                SetStartDate();
                SetEndDate();
                SetAlertDate();
            }
            while (ValidateMeetingController.CheckMeeting(this) == true);
        }


        public void SetName()
        {
            PrintController.Execute("Введите название встречи:");
            var input = ReadController.ReadLine();
            Name = input;
        }

        public void SetStartDate()
        {
            PrintController.Execute("Дата начала:");
            var startDate = ReadController.ReadDateTime();
            StartDate = startDate;
        }

        public void SetEndDate()
        {
            PrintController.Execute("Дата окончания:");
            var endDate = ReadController.ReadDateTime();
            EndDate = endDate;
        }

        public void SetAlertDate()
        {
            PrintController.Execute("За сколько минут до начала встречи сделать уведомление?");
            var alertTime = ReadController.ReadInt();
            AlertDate = StartDate.AddMinutes(-alertTime);
        }
    }
}
