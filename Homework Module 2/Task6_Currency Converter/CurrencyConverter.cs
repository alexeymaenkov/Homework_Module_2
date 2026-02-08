using System.Text;
namespace Homework_Module_2.Task6_Currency_Converter;

public class CurrencyConverter
{
    public void Run()
    { 
        /*Написать конвертер валют (3 валюты).

        У пользователя есть баланс в каждой из представленных валют.
        Он может попросить сконвертировать часть баланса с одной валюты в другую.
        Тогда у него с баланса одной валюты снимется X и зачислится на баланс другой Y.
        Курс конвертации должен быть просто прописан в программе.

           По имени переменной курса конвертации должно быть понятно, из какой валюты в какую валюту конвертируется.
           В консольном меню будет 6 команд конвертации, на каждый обмен. И для каждого обмена своя переменная с коэффициентом обмена.
           Валюта не может быть отрицательной и это стоит учитывать.
           Программа должна завершиться тогда, когда это решит пользователь.

        В каждом кейсе должна быть одна операция. Либо деление, либо умножение. То есть, одна строка.
        Все остальные действия должны происходить за пределами свитча.** */
        
        const string CONVERT_RUB_TO_USD = "1";
        const string CONVERT_USD_TO_RUB = "2";
        const string CONVERT_RUB_TO_EUR = "3";
        const string CONVERT_EUR_TO_RUB = "4";
        const string CONVERT_USD_TO_EUR = "5";
        const string CONVERT_EUR_TO_USD = "6";
        const string EXIT = "7";
        const float rubToUsd = 77.04f, usdToRub = 72.5f, rubToEur = 91.3f, eurToRub = 88.7f, usdToEur = 0.82f, eurToUsd = 1.18f;
        
        float rubInWallet, usdInWallet, eurInWallet;
        float exchangeCurrencyCount;
        
        Console.Write("Введите баланс RUB: ");
        rubInWallet = Convert.ToSingle(Console.ReadLine());
        Console.Write("Введите баланс USD: ");
        usdInWallet = Convert.ToSingle(Console.ReadLine());
        Console.Write("Введите баланс EUR: ");
        eurInWallet = Convert.ToSingle(Console.ReadLine());
        
        StringBuilder userInput = new ();
        
        bool isWork = true;

        while (isWork)
        {
            Console.Clear();
            Console.WriteLine("Конвертер валют");
            Console.WriteLine($"Ваш баланс: RUB:{rubInWallet} | USD:{usdInWallet} | EUR:{eurInWallet}");
            Console.WriteLine($"Курс обмена валют:\nRUB->USD:{rubToUsd} | USD->RUB:{usdToRub}\nRUB->EUR:{rubToEur} | EUR->RUB:{eurToRub}\nUSD->EUR:{usdToEur} | EUR->USD:{eurToUsd}");
            Console.WriteLine("Доступные операции:");
            Console.WriteLine($"{CONVERT_RUB_TO_USD} - Обмен Рублей на Доллары");
            Console.WriteLine($"{CONVERT_USD_TO_RUB} - Обмен Долларов на Рубли");
            Console.WriteLine($"{CONVERT_RUB_TO_EUR} - Обмен Рублей на Евро");
            Console.WriteLine($"{CONVERT_EUR_TO_RUB} - Обмен Евро на Рубли");
            Console.WriteLine($"{CONVERT_USD_TO_EUR} - Обмен Долларов на Евро");
            Console.WriteLine($"{CONVERT_EUR_TO_USD} - Обмен Евро на Доллары");
            Console.WriteLine($"{EXIT} - Выход");
            
            Console.Write("Введите номер операции: ");
            userInput.Clear();
            userInput.Append(Console.ReadLine());
        
            switch (userInput.ToString())
            {
                case CONVERT_RUB_TO_USD:
                    Console.Write("Сколько Рублей вы хотите обменять:");
                    exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                    if (exchangeCurrencyCount <= rubInWallet)
                    {
                        rubInWallet -= exchangeCurrencyCount;
                        usdInWallet += exchangeCurrencyCount / rubToUsd;
                        Console.WriteLine($"Операция успешна. Ваш баланс: RUB:{rubInWallet} | USD:{usdInWallet} | EUR:{eurInWallet}");
                    }
                    else
                    {
                        Console.WriteLine("У вас не достаточно денег.");
                    }
                    break;
                case CONVERT_USD_TO_RUB:
                    Console.Write("Сколько Долларов вы хотите обменять:");
                    exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                    if (exchangeCurrencyCount <= usdInWallet)
                    {
                        usdInWallet -= exchangeCurrencyCount;
                        rubInWallet += exchangeCurrencyCount * usdToRub;
                        Console.WriteLine($"Операция успешна. Ваш баланс: RUB:{rubInWallet} | USD:{usdInWallet} | EUR:{eurInWallet}");
                    }
                    else
                    {
                        Console.WriteLine("У вас не достаточно денег.");
                    }
                    break;
                case CONVERT_RUB_TO_EUR:
                    Console.Write("Сколько Рублей вы хотите обменять:");
                    exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                    if (exchangeCurrencyCount <= rubInWallet)
                    {
                        rubInWallet -= exchangeCurrencyCount;
                        eurInWallet += exchangeCurrencyCount / rubToEur;
                        Console.WriteLine($"Операция успешна. Ваш баланс: RUB:{rubInWallet} | USD:{usdInWallet} | EUR:{eurInWallet}");
                    }
                    else
                    {
                        Console.WriteLine("У вас не достаточно денег.");
                    }
                    break;
                case CONVERT_EUR_TO_RUB:
                    Console.Write("Сколько Евро вы хотите обменять:");
                    exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                    if (exchangeCurrencyCount <= eurInWallet)
                    {
                        eurInWallet -= exchangeCurrencyCount;
                        rubInWallet += exchangeCurrencyCount * eurToRub;
                        Console.WriteLine($"Операция успешна. Ваш баланс: RUB:{rubInWallet} | USD:{usdInWallet} | EUR:{eurInWallet}");
                    }
                    else
                    {
                        Console.WriteLine("У вас не достаточно денег.");
                    }
                    break;
                case CONVERT_USD_TO_EUR:
                    Console.Write("Сколько Долларов вы хотите обменять:");
                    exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                    if (exchangeCurrencyCount <= usdInWallet)
                    {
                        usdInWallet -= exchangeCurrencyCount;
                        eurInWallet += exchangeCurrencyCount / usdToEur;
                        Console.WriteLine($"Операция успешна. Ваш баланс: RUB:{rubInWallet} | USD:{usdInWallet} | EUR:{eurInWallet}");
                    }
                    else
                    {
                        Console.WriteLine("У вас не достаточно денег.");
                    }
                    break;
                case CONVERT_EUR_TO_USD:
                    Console.Write("Сколько Евро вы хотите обменять:");
                    exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                    if (exchangeCurrencyCount <= eurInWallet)
                    {
                        eurInWallet -= exchangeCurrencyCount;
                        usdInWallet += exchangeCurrencyCount * eurToUsd;
                        Console.WriteLine($"Операция успешна. Ваш баланс: RUB:{rubInWallet} | USD:{usdInWallet} | EUR:{eurInWallet}");
                    }
                    else
                    {
                        Console.WriteLine("У вас не достаточно денег.");
                    }
                    break;
                case EXIT:
                    isWork = false;
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Неверный ввод номера операции! Попробуйте снова.");
                    break;
            }
            if (isWork)
            {
                Console.Write("Для продолжения обмена нажмите любую клавишу: ");
                Console.ReadKey();
            }
        }
    }
}