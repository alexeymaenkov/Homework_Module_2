namespace Homework_Module_2.Task1_Cycles;

public class Cycles
{
    public void Run()
    {
        Console.Write("Введите сообщение: ");
        string input = Console.ReadLine();

        Console.Write("Введите количество повторений: ");
        int iterations = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < iterations; i++)
        {
            Console.Write(input);
        }
    }
}