namespace Homework_Module_2.Task4_Sum;

public class Sum
{
    public void Run()
    {
        const int MULTIPLES_1 = 3;
        const int MULTIPLES_2 = 5;
        
        Random random = new();
        
        int number = random.Next(0, 101);
        int sum = number;
        
        Console.WriteLine($"Случайное число от 0 до 100: {number}");

        for (int i = 0; i < number; i++)
        {
            if (i % MULTIPLES_1 == 0 || i % MULTIPLES_2 == 0)
            {
                sum += i;
            }
        }
        Console.WriteLine($"Сумма всех положительных чисел меньше {number} (включая {number}), " +
                          $"которые кратны {MULTIPLES_1} или {MULTIPLES_2} равна: {sum}");
    }
}