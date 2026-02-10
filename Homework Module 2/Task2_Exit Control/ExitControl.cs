namespace Homework_Module_2.Task2_Exit_Control;

public class ExitControl
{
    public void Run()
    {
        int countTries = 0;

        bool rerun = true;
        
        string userInput = "enter";
        /*
        while (rerun)
        {
            Console.WriteLine(countTries);
            countTries++;
            
            Console.Write("Продолжить? (enter/exit): ");
            userInput = Console.ReadLine();
            
            switch (userInput)
            {
                case "exit":
                    rerun = false;
                    break;
                default:
                    Console.Clear();
                    continue;
            }
        }
        */
        
        /*
        while (rerun)
        {
            Console.WriteLine(countTries);
            
            Console.Write("Продолжить? (enter/exit): ");
            userInput = Console.ReadLine();
            
            if (userInput == "exit")
            {
                rerun = false;
            }
            else if (userInput == "enter")
            {
                countTries++;
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Неверный ввод! Попробуйте снова.");
            }
        }
        */

        while (userInput != "exit")
        {
            Console.Clear();
            
            countTries++;
            Console.WriteLine(countTries);
            
            Console.Write("Продолжить? (enter/exit): ");
            userInput = Console.ReadLine();
        }
    }
}