namespace Homework_Module_2.Task11_PowerOfTwo;

public class PowerOfTwo
{
    public void Run()
    {
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