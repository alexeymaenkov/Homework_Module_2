using System.Text;
namespace Homework_Module_2.Task5_Console_Menu;

public class ConsoleMenu
{
    public void Run()
    {
        const int START_RAND = 0;
        const int FINISH_RAND = 100;
        const string COMMAND_SHOW_TEXT1 = "1";
        const string COMMAND_HIDE_TEXT2 = "2";
        const string RAND_NUMBER = "3";
        const string CONSOLE_CLEAR = "4";
        const string EXIT = "5";

        Random random = new Random();
        
        bool isWork = true;
        
        StringBuilder userInput = new ();

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
            userInput.Clear();
            userInput.Append(Console.ReadLine());
        
            switch (userInput.ToString())
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