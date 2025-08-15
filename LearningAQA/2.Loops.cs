using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Loops
{
    public static void NumbersGuesser ()
    {
        //    3. Цикли — Вгадай число. Комп’ютер загадує число від 1 до 20. Користувач вводить числа, поки не вгадає. Після кожної спроби підказувати: 'Більше' або 'Менше'. 

        Random random = new Random();   
        while (true)
        {
            /*
                if you uncomment the following commented part but comment row 33 ->
                the program will ask a user to set the range for numbers randomizer
            */

            /*
                Console.WriteLine("Let's set the range for randomizer");
                Console.WriteLine("Enter the lower edge");
                int.TryParse(Console.ReadLine(), out int lowerEdge);
                Console.WriteLine("Enter the higher edge");
                int.TryParse(Console.ReadLine(), out int higherEdge);
                int randomNumber = random.Next(lowerEdge, higherEdge + 1);
                Console.WriteLine($"Guess a number between {lowerEdge} and {higherEdge}.");
            */

            int randomNumber = random.Next(1, 21);
            while (true)
            {
                Console.Write("Enter a number: ");
                if (int.TryParse(Console.ReadLine(), out int usersNumber))
                {
                    if (usersNumber < randomNumber)
                    {
                        Console.WriteLine("Higher!");
                    }
                    else if (usersNumber > randomNumber)
                    {
                        Console.WriteLine("Lower!");
                    }
                    else
                    {
                        Console.WriteLine("Congrats! You've nailed it!");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter an integer value in the range.");
                }
            }
            Console.WriteLine("Do you want to play again? (yes/no)");
            string response = Console.ReadLine()?.ToLower();
            if (response != "yes")
            {
                break;
            }
        }

    }




    //4. Цикли — Генератор паролів
    //Запросити у користувача довжину пароля та створити пароль з випадкових цифр і літер.



}
