namespace Homework_Module_2.Task5_Console_Menu;

public class ConsoleMenu
{
    public void Run()
    {
        const int START_RAND = 0;
        const int FINISH_RAND = 100;
        
        const string COMMAND_SHOW_TEXT_HELLO = "1";
        const string COMMAND_SHOW_TEXT_NAME = "2";
        const string COMMAND_RAND_NUMBER = "3";
        const string COMMAND_CONSOLE_CLEAR = "4";
        const string COMMAND_EXIT = "5";

        Random random = new Random();
        
        bool isWork = true;

        string userInput;

        while (isWork)
        {
            Console.Clear();
            
            Console.WriteLine("Добро пожаловать в программу!\nМеню:");
            Console.WriteLine($"{COMMAND_SHOW_TEXT_HELLO} - Вывод приветствия");
            Console.WriteLine($"{COMMAND_SHOW_TEXT_NAME} - Вывод Имени");
            Console.WriteLine($"{COMMAND_RAND_NUMBER} - Показать случайное число.");
            Console.WriteLine($"{COMMAND_CONSOLE_CLEAR} - Очистить консоль.");
            Console.WriteLine($"{COMMAND_EXIT} - Выход.");
            
            Console.Write("Введите номер команды: ");
            userInput = Console.ReadLine();
        
            switch (userInput)
            {
                case COMMAND_SHOW_TEXT_HELLO:
                    Console.WriteLine("Hello!");
                    break;
                
                case COMMAND_SHOW_TEXT_NAME:
                    Console.WriteLine("Alex");
                    break;
                
                case COMMAND_RAND_NUMBER:
                    int randomNumber = random.Next(START_RAND, FINISH_RAND);
                    Console.WriteLine($"Случайное число от {START_RAND} до {FINISH_RAND} равно: {randomNumber}.");
                    break;
                
                case COMMAND_CONSOLE_CLEAR:
                    Console.Clear();
                    break;
                
                case COMMAND_EXIT:
                    isWork = false;
                    Console.Clear();
                    break;
                
                default:
                    Console.WriteLine("Неверный ввод! Попробуйте снова.");
                    break;
            }
            
            Console.Write("Нажмите любую клавишу для продолжения: ");
            Console.ReadKey();
        }
    }
}