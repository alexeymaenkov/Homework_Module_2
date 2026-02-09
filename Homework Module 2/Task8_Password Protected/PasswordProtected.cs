namespace Homework_Module_2.Task8_Password_Protected;

public class PasswordProtected
{
    public void Run()
    {
        const string PASSWORD = "12345";
        
        string hideMessage = "Hide Message";
        
        bool isWork = true;

        while (isWork)
        {
            Console.Write("Введите пароль: ");
            string userInput = Console.ReadLine();
            
            switch (userInput)
            {
                case PASSWORD:
                    isWork = false;
                    Console.WriteLine(hideMessage);
                    break;
                default:
                    Console.WriteLine("Неверный пароль! Попробуйте еще раз.");
                    break;
            }
        }
    }
}