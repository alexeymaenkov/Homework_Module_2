using System.Text;

namespace Homework_Module_2.Task2_Exit_Control;

public class ExitControl
{
    public void Run()
    {
        //Написать программу, которая будет выполняться до тех пор, пока не будет введено слово exit.
        //Помните, цикл работает, пока выполняется условие. А противоположное отвечает за выход.
        
        //Это необходимо, чтобы любой разработчик, взглянув на ваш код, понял четкие границы вашего цикла.

        int i = 0;

        bool rerun = true;
        
        StringBuilder userInput = new ();

        while (rerun == true)
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