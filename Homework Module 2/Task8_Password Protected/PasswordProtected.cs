namespace Homework_Module_2.Task8_Password_Protected;

public class PasswordProtected
{
    public void Run()
    {
        const string PASSWORD = "12345";
        
        string hideMessage = "Hide Message";
        
        string userInput = "00000";
        
        while (userInput != PASSWORD)
        {
            Console.Write("Введите пароль: ");
            userInput = Console.ReadLine();

            if (userInput == PASSWORD)
            {
                Console.WriteLine(hideMessage);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Неверный пароль! Попробуйте еще раз.");
            }
        }
    }
}