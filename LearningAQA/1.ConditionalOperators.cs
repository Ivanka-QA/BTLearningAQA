using System;
using System.Security.Cryptography.X509Certificates;

public class ConditionalOperators
{
    public static void DiscountCalculator()
    {
        //1.Умовні оператори — Знижка в магазині. Користувач вводить суму покупки. Якщо сума більше 1000 — знижка 5%. Якщо більше 5000 — знижка 10%. Вивести кінцеву суму з урахуванням знижки. 
        //Приклад: Введіть суму: 1200 → До сплати: 1140 грн

        decimal amount;
        while (true)
        {
            Console.Write("Enter your purchase total amount: ");
            if (decimal.TryParse(Console.ReadLine(), out amount))
            {
                break;
            }
            Console.WriteLine("Please enter a valid total amount of your purchase without currency.");
        }

        decimal discount = 0;
        if (amount > 5000)
        {
            discount = 0.10m; // 10% discount
        }
        else if (amount > 1000)
        {
            discount = 0.05m; // 5% discount
        }
        decimal finalAmount = amount * (1 - discount);
        Console.WriteLine($"Final amount to pay: {finalAmount} USD");
    }

    public static void TemperatureAdvisor()
    {
        //2. Умовні оператори — Температурний порадник 
        //Користувач вводить температуру на вулиці. Програма радить, що одягнути: 
        //- > 25° — футболка та шорти 
        //- 15–25° — легка куртка 
        //- <15° — теплий одяг

        while (true)
        {
           TemperatureCalculator();
            Console.WriteLine("Do you want to check another temperature? (yes/no)");
            string response = Console.ReadLine()?.ToLower();
            if (response != "yes")
            {
                break;
            }
        }
    }

       private static void TemperatureCalculator() 
        { 
            double temperature;
            while (true)
            {
                Console.Write("Enter the current temperature: ");
                if (double.TryParse(Console.ReadLine(), out temperature))
                {
                    break;
                }
                Console.WriteLine("Please enter a valid temperature.");
            }
            switch (temperature)
            {
                case > 25:
                    Console.WriteLine("Wear a t-shirt and shorts.");
                    break;
                case >= 15 and <= 25:
                    Console.WriteLine("Wear a light jacket.");
                    break;
                default:
                    Console.WriteLine("Wear warm clothes.");
                    break;
            }
        }

}