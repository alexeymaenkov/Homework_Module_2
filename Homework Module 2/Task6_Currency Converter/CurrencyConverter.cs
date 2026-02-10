namespace Homework_Module_2.Task6_Currency_Converter;

public class CurrencyConverter
{
    public void Run()
    {
        const string COMMAND_CONVERT_RUB_TO_USD = "1";
        const string COMMAND_CONVERT_USD_TO_RUB = "2";
        const string COMMAND_CONVERT_RUB_TO_EUR = "3";
        const string COMMAND_CONVERT_EUR_TO_RUB = "4";
        const string COMMAND_CONVERT_USD_TO_EUR = "5";
        const string COMMAND_CONVERT_EUR_TO_USD = "6";
        const string COMMAND_EXIT = "7";
        const float RUB_TO_USD = 77.04f;
        const float USD_TO_RUB = 72.5f;
        const float RUB_TO_EUR = 91.3f;
        const float EUR_TO_RUB = 88.7f;
        const float USD_TO_EUR = 0.82f;
        const float EUR_TO_USD = 1.18f;
        
        float exchangeCurrencyCount;
        
        bool isWork = true;
        
        Console.Write("Введите баланс RUB: ");
        float rubInWallet = Convert.ToSingle(Console.ReadLine());
        
        Console.Write("Введите баланс USD: ");
        float usdInWallet = Convert.ToSingle(Console.ReadLine());
        
        Console.Write("Введите баланс EUR: ");
        float eurInWallet = Convert.ToSingle(Console.ReadLine());
        
        string userInput;

        while (isWork)
        {
            Console.Clear();
            
            Console.WriteLine("Конвертер валют");
            Console.WriteLine($"Ваш баланс: RUB:{rubInWallet} | USD:{usdInWallet} | EUR:{eurInWallet}");
            Console.WriteLine($"Курс обмена валют:\nRUB->USD:{RUB_TO_USD} | USD->RUB:{USD_TO_RUB}\nRUB->EUR:{RUB_TO_EUR} | EUR->RUB:{EUR_TO_RUB}\nUSD->EUR:{USD_TO_EUR} | EUR->USD:{EUR_TO_USD}");
            Console.WriteLine("Доступные операции:");
            Console.WriteLine($"{COMMAND_CONVERT_RUB_TO_USD} - Обмен Рублей на Доллары");
            Console.WriteLine($"{COMMAND_CONVERT_USD_TO_RUB} - Обмен Долларов на Рубли");
            Console.WriteLine($"{COMMAND_CONVERT_RUB_TO_EUR} - Обмен Рублей на Евро");
            Console.WriteLine($"{COMMAND_CONVERT_EUR_TO_RUB} - Обмен Евро на Рубли");
            Console.WriteLine($"{COMMAND_CONVERT_USD_TO_EUR} - Обмен Долларов на Евро");
            Console.WriteLine($"{COMMAND_CONVERT_EUR_TO_USD} - Обмен Евро на Доллары");
            Console.WriteLine($"{COMMAND_EXIT} - Выход");
            
            Console.Write("Введите номер операции: ");
            userInput = Console.ReadLine();
        
            switch (userInput)
            {
                case COMMAND_CONVERT_RUB_TO_USD:
                    Console.Write("Сколько Рублей вы хотите обменять:");
                    exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                    
                    if (exchangeCurrencyCount <= rubInWallet)
                    {
                        rubInWallet -= exchangeCurrencyCount;
                        usdInWallet += exchangeCurrencyCount / RUB_TO_USD;
                        Console.WriteLine($"Операция успешна. Ваш баланс: RUB:{rubInWallet} | USD:{usdInWallet} | EUR:{eurInWallet}");
                    }
                    else
                    {
                        Console.WriteLine("У вас не достаточно денег.");
                    }
                    break;
                
                case COMMAND_CONVERT_USD_TO_RUB:
                    Console.Write("Сколько Долларов вы хотите обменять:");
                    exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                    
                    if (exchangeCurrencyCount <= usdInWallet)
                    {
                        usdInWallet -= exchangeCurrencyCount;
                        rubInWallet += exchangeCurrencyCount * USD_TO_RUB;
                        Console.WriteLine($"Операция успешна. Ваш баланс: RUB:{rubInWallet} | USD:{usdInWallet} | EUR:{eurInWallet}");
                    }
                    else
                    {
                        Console.WriteLine("У вас не достаточно денег.");
                    }
                    break;
                
                case COMMAND_CONVERT_RUB_TO_EUR:
                    Console.Write("Сколько Рублей вы хотите обменять:");
                    exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                    
                    if (exchangeCurrencyCount <= rubInWallet)
                    {
                        rubInWallet -= exchangeCurrencyCount;
                        eurInWallet += exchangeCurrencyCount / RUB_TO_EUR;
                        Console.WriteLine($"Операция успешна. Ваш баланс: RUB:{rubInWallet} | USD:{usdInWallet} | EUR:{eurInWallet}");
                    }
                    else
                    {
                        Console.WriteLine("У вас не достаточно денег.");
                    }
                    break;
                
                case COMMAND_CONVERT_EUR_TO_RUB:
                    Console.Write("Сколько Евро вы хотите обменять:");
                    exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                    
                    if (exchangeCurrencyCount <= eurInWallet)
                    {
                        eurInWallet -= exchangeCurrencyCount;
                        rubInWallet += exchangeCurrencyCount * EUR_TO_RUB;
                        Console.WriteLine($"Операция успешна. Ваш баланс: RUB:{rubInWallet} | USD:{usdInWallet} | EUR:{eurInWallet}");
                    }
                    else
                    {
                        Console.WriteLine("У вас не достаточно денег.");
                    }
                    break;
                
                case COMMAND_CONVERT_USD_TO_EUR:
                    Console.Write("Сколько Долларов вы хотите обменять:");
                    exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                    
                    if (exchangeCurrencyCount <= usdInWallet)
                    {
                        usdInWallet -= exchangeCurrencyCount;
                        eurInWallet += exchangeCurrencyCount / USD_TO_EUR;
                        Console.WriteLine($"Операция успешна. Ваш баланс: RUB:{rubInWallet} | USD:{usdInWallet} | EUR:{eurInWallet}");
                    }
                    else
                    {
                        Console.WriteLine("У вас не достаточно денег.");
                    }
                    break;
                
                case COMMAND_CONVERT_EUR_TO_USD:
                    Console.Write("Сколько Евро вы хотите обменять:");
                    exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                    
                    if (exchangeCurrencyCount <= eurInWallet)
                    {
                        eurInWallet -= exchangeCurrencyCount;
                        usdInWallet += exchangeCurrencyCount * EUR_TO_USD;
                        Console.WriteLine($"Операция успешна. Ваш баланс: RUB:{rubInWallet} | USD:{usdInWallet} | EUR:{eurInWallet}");
                    }
                    else
                    {
                        Console.WriteLine("У вас не достаточно денег.");
                    }
                    break;
                
                case COMMAND_EXIT:
                    isWork = false;
                    Console.Clear();
                    break;
                
                default:
                    Console.WriteLine("Неверный ввод номера операции! Попробуйте снова.");
                    break;
            }
            
            Console.Write("Для продолжения обмена нажмите любую клавишу: ");
            Console.ReadKey();
        }
    }
}