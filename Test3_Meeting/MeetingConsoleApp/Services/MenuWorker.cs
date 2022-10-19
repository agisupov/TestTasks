namespace MeetingConsoleApp.Services
{
    public static class MenuWorker
    {
        private static List<MenuItem> menuItems = new List<MenuItem>();

        public static void Run()
        {
            CreateMenu();
            PrintMenu();
            while (true)
            {
                var commandNumber = ReadController.ReadInt();
                MenuItemExecute(commandNumber);
            }
        }

        private static void CreateMenu()
        {
            menuItems.Add(new MenuItem(1, "Создать встречу"));
            menuItems.Add(new MenuItem(2, "Изменить встречу"));
            menuItems.Add(new MenuItem(3, "Удалить встречу"));
            menuItems.Add(new MenuItem(4, "Посмотреть встречи на конкретный день"));
            menuItems.Add(new MenuItem(5, "Посмотреть все встречи"));
        }

        public static void PrintMenu()
        {
            PrintController.Execute("------- Меню -------");
            menuItems.ForEach(x => PrintController.Execute(x.ToString()));
            PrintController.Execute("--------------------");
        }

        private static void MenuItemExecute(int menuNumber)
        {
            var menuItem = menuItems.FirstOrDefault(x => x.OperationId == menuNumber);

            if (menuItem == null)
                PrintController.Execute("Нет такого пункта в меню!");
            else
                menuItem.Execute();
        }
    }
}
