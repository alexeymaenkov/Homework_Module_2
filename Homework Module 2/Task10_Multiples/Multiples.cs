namespace Homework_Module_2.Task10_Multiples;

public class Multiples
{
    public void Run()
    {
        Random random = new();
        
        int n = random.Next(10, 26);
        int firstOfRange = 50;
        int lastOfRange = 150;
        int count = 0;

        Console.WriteLine($"Число N = {n}");
        
        for (int j = n; j <= lastOfRange; j += n)
        {
            for (int i = firstOfRange; i <= lastOfRange; i++)
            {
                if (i == j)
                {
                    count++;
                }
            }
        }
        Console.WriteLine($"Количество чисел от {firstOfRange} до {lastOfRange} (включая эти числа), которые кратны {n} = {count}");
    }
}