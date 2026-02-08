using System.Text;
namespace Homework_Module_2.Task7_Name_Output;

public class NameOutput
{
    public void Run()
    {
        /*Вывести имя в прямоугольник из символа, который введет сам пользователь.

        От пользователя получаете символ и имя и по этим данным выводите имя в прямоугольнике.
        Длина всех выводимых строк в прямоугольнике одинаковая, а узнать длину всегда можно у второй строки.
        Длину строки можно всегда узнать через свойство Length
        string someString = “Hello”;
        Console.WriteLine(someString.Length); //5

        То есть при вводе символа % и имени Alexey получиться, что в каждой строке 8 символов (в консоли длина символа одинаковая)
            %%%%%%%%
            %Alexey%
            %%%%%%%%



        Решить проблему множественной конкатенации строк */

        Console.Write("Введите ваше имя: ");
        string name = Console.ReadLine();
        
        Console.Write("Введите символ: ");
        char symbol = Convert.ToChar(Console.ReadLine());
        
        int lenghtOfStrings = name.Length + 2;
        
        StringBuilder symbolString = new ();
        
        symbolString.Append(symbol, lenghtOfStrings);
        Console.WriteLine(symbolString.ToString());
        
        symbolString.Remove(1, name.Length);
        symbolString.Insert(1, name);
        Console.WriteLine(symbolString.ToString());
        
        symbolString.Remove(1, name.Length);
        symbolString.Append(symbol, name.Length);
        Console.WriteLine(symbolString.ToString());
    }
}