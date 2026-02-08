namespace Homework_Module_2.Task11_PowerOfTwo;

public class PowerOfTwo
{
    public void Run()
    {
        /*
        Найдите минимальную степень двойки, превосходящую заданное число.
        К примеру, для числа 4 будет 2 в степени 3, то есть 8. 4<8.
        Для числа 29 будет 2 в степени 5, то есть 32. 29<32.
        В консоль вывести число (лучше получить от Random), степень и само число 2 в найденной степени.
        Math.Pow не используйте, реализовать надо с помощью простых математических операций. */
        
        Random random = new ();
        
        int setNumber = random.Next(2, 1000);
        int numberTwo = 2;
        int power = 2;
        int powCount = 2;

        while (setNumber >= numberTwo)
        {
            numberTwo *= power;
            if (setNumber >= numberTwo)
            { 
                powCount++;
            }
        }
        Console.WriteLine($"Заданное число: {setNumber}\nМинимальная степень двойки: {powCount}\nДва в найденной степени:{numberTwo}");
    }
}