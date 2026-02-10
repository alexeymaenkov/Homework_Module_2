namespace Homework_Module_2.Task11_PowerOfTwo;

public class PowerOfTwo
{
    public void Run()
    {
        Random random = new ();

        int minRandomNumber = 2;
        int maxRandomNumber = 1000;
        int randomNumber = random.Next(minRandomNumber, maxRandomNumber);
        int numberTwo = 2;
        int power = 2;
        int powCount = 1;
        /*
        while (randomNumber >= numberTwo)
        {
            numberTwo *= power;
            if (randomNumber >= numberTwo)
            { 
                powCount++;
            }
        }*/

        for (int i = numberTwo; i <= randomNumber; i *= power)
        {
            numberTwo *= power;
            powCount++;
        }
        
        Console.WriteLine($"Заданное число: {randomNumber}\nМинимальная степень двойки: {powCount}\nДва в найденной степени:{numberTwo}");
    }
}