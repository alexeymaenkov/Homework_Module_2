using System.Text;

namespace Homework_Module_2.Task2_Exit_Control;

public class ExitControl
{
    public void Run()
    {
        int i = 0;

        bool rerun = true;
        
        StringBuilder userInput = new ();

        while (rerun)
        {
            Console.WriteLine(i);
            i++;
            
            Console.Write("Продолжить? (enter/exit): ");
            userInput.Clear();
            userInput.Append(Console.ReadLine());
            
            switch (userInput.ToString())
            {
                case "exit":
                    rerun = false;
                    break;
                default:
                    Console.Clear();
                    continue;
            }
        }
    }
}