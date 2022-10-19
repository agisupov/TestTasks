namespace MeetingConsoleApp.Models
{
    public class MenuItem
    {
        public int OperationId { get; set; }
        private string Name { get; set; }

        public MenuItem(int operationId, string name)
        {
            OperationId = operationId;
            Name = name;
        }

        public void Execute()
        {
            switch (OperationId)
            {
                case 1:
                    CreateMeetingController.Execute();
                    break;
                case 2:
                    UpdateMeetingController.Execute();
                    break;
                case 3:
                    DeleteMeetingController.Execute();
                    break;
                case 4:
                    ShowMeetingsController.ExecuteShowSpecifiedDay();
                    break;
                case 5:
                    ShowMeetingsController.ExecuteShowAll();
                    break;
                default:
                    PrintController.Execute("Такой команды не существует!");
                    break;
            }
        }

        public override string ToString() => ($"{OperationId}. {Name}");
    }
}
