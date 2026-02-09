using System.Text;
namespace Homework_Module_2.Task7_Name_Output;

public class NameOutput
{
    public void Run()
    {
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