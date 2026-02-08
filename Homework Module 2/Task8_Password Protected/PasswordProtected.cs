namespace Homework_Module_2.Task8_Password_Protected;

public class PasswordProtected
{
    public void Run()
    {
        /*
        Создайте переменную типа string, в которой хранится пароль для доступа к тайному сообщению.
        Пользователь вводит пароль, далее происходит проверка пароля на правильность, и если пароль неверный,
        то попросите его ввести пароль ещё раз. Если пароль подошёл, выведите секретное сообщение.

            Если пользователь неверно ввел пароль 3 раза, программа завершается. */
        
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