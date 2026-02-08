using System.Globalization;

namespace Homework_Module_2.Task5_Console_Menu;

public class ConsoleMenu
{
    public void Run()
    {
        /*     При помощи всего, что вы изучили, создать приложение, которое может обрабатывать команды.
        Т.е. вы создаете меню, ожидаете ввода нужной команды, после чего выполняете действие, которое присвоено этой команде.
        Программа не должна завершаться после ввода, пользователь сам должен выйти из программы при помощи команды.

            Меню должно содержать следующие команды:
            - пара команд на вывод разного текста
            - команда показать случайное число
            - команда очистить консоль
            - команда выхода

        Если решение строится на switch, то принято работать с константами (в остальных случаях объявляются переменные).
        Подробнее вы можете изучить в статье [Использование констант] */
        
        const int START_RAND = 0;
        const int FINISH_RAND = 100;
        const string COMMAND_SHOW_TEXT1 = "1";
        const string COMMAND_HIDE_TEXT2 = "2";
        const string RAND_NUMBER = "3";
        const string CONSOLE_CLEAR = "4";
        const string EXIT = "5";

        bool isWork = true;
        
        Random random = new Random();

        while (isWork)
        {
            Console.Clear();
            Console.WriteLine("Добро пожаловать в программу!\nМеню:");
            Console.WriteLine($"{COMMAND_SHOW_TEXT1} - Вывод текста 1.");
            Console.WriteLine($"{COMMAND_HIDE_TEXT2} - Вывод текста 2.");
            Console.WriteLine($"{RAND_NUMBER} - Показать случайное число.");
            Console.WriteLine($"{CONSOLE_CLEAR} - Очистить консоль.");
            Console.WriteLine($"{EXIT} - Выход.");
            
            Console.Write("Введите номер команды: ");
            string userInput = Console.ReadLine();
        
            switch (userInput)
            {
                case COMMAND_SHOW_TEXT1:
                    Console.WriteLine("text 1");
                    break;
                case COMMAND_HIDE_TEXT2:
                    Console.WriteLine("text 2");
                    break;
                case RAND_NUMBER:
                    int randomNumber = random.Next(START_RAND, FINISH_RAND);
                    Console.WriteLine($"Случайное число от {START_RAND} до {FINISH_RAND} равно: {randomNumber}.");
                    break;
                case CONSOLE_CLEAR:
                    Console.Clear();
                    break;
                case EXIT:
                    isWork = false;
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Неверный ввод! Попробуйте снова.");
                    break;
            }
            if (isWork)
            {
                Console.Write("Нажмите любую клавишу для продолжения: ");
                Console.ReadKey();
            }
        }
    }
}