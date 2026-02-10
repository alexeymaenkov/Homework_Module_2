namespace Homework_Module_2.Task2_Exit_Control;

public class ExitControl
{
    public void Run()
    {
        string userInput = "enter";
        
        while (userInput != "exit")
        {
            Console.Clear();
            
            Console.Write("Продолжить? (enter/exit): ");
            userInput = Console.ReadLine();
        }
    }
}