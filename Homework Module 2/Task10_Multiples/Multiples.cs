namespace Homework_Module_2.Task10_Multiples;

public class Multiples
{
    public void Run()
    {
        /*
        Дано N (10 ≤ N ≤ 25).
        Найти количество чисел от 50 до 150 (включая эти числа), которые кратны N.
        Операции деления (/, %) не использовать. А умножение не требуется. Посмотрите на задачу “Последовательность”
        Число N всего одно, его надо получить в нужном диапазоне. Хоть с помощью Random, хоть ввод пользователя.
        */
        
        Random random = new();
        
        int N = random.Next(10, 26);
        int firstOfRange = 50;
        int lastOfRange = 150;
        int count = 0;

        Console.WriteLine($"Число N = {N}");
        
        for (int j = N; j <= lastOfRange; j += N)
        {
            for (int i = firstOfRange; i <= lastOfRange; i++)
            {
                if (i == j)
                {
                    count++;
                }
            }
        }
        Console.WriteLine($"Количество чисел от {firstOfRange} до {lastOfRange} (включая эти числа), которые кратны {N} = {count}");
    }
}