namespace Homework_Module_2.Task4_Sum;

public class Sum
{
    public void Run()
    {
        Random random = new();

        int minNumber = 0;
        int maxNumber = 101;
        int number = random.Next(minNumber, maxNumber);
        int sum = number;
        
        Console.WriteLine($"Случайное число от 0 до 100: {number}");

        for (int i = 0; i < number; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                sum += i;
            }
        }
        Console.WriteLine($"Сумма всех положительных чисел меньше {number} (включая {number}), " +
                          $"которые кратны 3 или 5 равна: {sum}");
    }
}