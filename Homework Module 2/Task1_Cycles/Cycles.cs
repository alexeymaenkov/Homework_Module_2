namespace Homework_Module_2.Task1_Cycles;

public class Cycles
{
    public void Run()
    {
        //При помощи циклов вы можете повторять один и тот же код множество раз.
        //Напишите простейшую программу, которая выводит указанное (установленное) пользователем сообщение заданное количество раз.
        //Количество повторов также должен ввести пользователь.

        //Пример:

        //Входные данные (написал пользователь в консоль):
        //Privet!
        //5

        //Результат программы (выведено в консоль):
        //Privet!Privet!Privet!Privet!Privet!

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