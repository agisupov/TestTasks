using System.Globalization;

namespace MeetingConsoleApp.Controllers
{
    public class ReadController
    {
        public static string ReadLine() => Console.ReadLine();

        public static int ReadInt()
        {
            while (true)
            {
                var isParsed = int.TryParse(ReadLine(), out var commandNumber);
                if (isParsed && commandNumber >= 0)
                {
                    return commandNumber;
                }
                else
                {
                    PrintController.Execute("Число введено неверно!");
                }
            }
        }

        public static DateTime ReadDateTime()
        {
            while (true)
            {
                PrintController.Execute("Введите дату и время в формате ДД.ММ.ГГГГ ЧЧ:ММ");
                var input = ReadLine();
                var isParsed = DateTime.TryParseExact(input, "dd.MM.yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out var result);

                if (isParsed)
                {
                    if (result > DateTime.Now)
                        return result;

                    PrintController.Execute("Дата может не может быть в прошлом");
                }
                else
                {
                    PrintController.Execute("Дата введена неверно");
                }
            }
        }

        public static DateTime ReadDateOnly()
        {
            while (true)
            {
                PrintController.Execute("Введите дату в формате ДД.ММ.ГГГГ");
                var input = ReadLine();
                var isParsed = DateTime.TryParseExact(input, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out var result);

                if (isParsed)
                {
                    return result;
                }

                PrintController.Execute("Дата введена неверно");

            }
        }
    }
}
