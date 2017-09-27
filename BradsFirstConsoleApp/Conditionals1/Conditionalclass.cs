using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals1
{
    class Conditionalclass
    {
        static void Main(string[] args)
        {
            //declare variables
            string myName;
            string location;
            int myPay;
            int myBonus;

            //Ask what is your name, assign reply to myName
            Console.WriteLine("What is your name?");
            myName = Console.ReadLine();

            Console.WriteLine("Where is your hometown?");
            location = Console.ReadLine();

            //Ask what is your basepay, convert response to an int and assign it to myPay
            Console.WriteLine("What is your basepay?");
            myPay = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your bonus?");
            myBonus = Convert.ToInt32(Console.ReadLine());

            //Add myPay + bonusPay to get totalPay
            int totalPay = myPay + myBonus;

            //If statement to output message based on totalPay
            if (totalPay >= 100)
            {
                Console.WriteLine("Rich Fuck");
            }
            else if (totalPay < 100 && totalPay >= 50)
            {
                Console.WriteLine("Youll pass");
            }
            else
            {
                Console.WriteLine("You shall not pass");
            }


            //Ask what is favorite food and assign to favoriteFood
            Console.WriteLine("What is your favorite food?");
            string favoriteFood = Console.ReadLine();

            //Switch output message based on favoriteFood value
            switch (favoriteFood)
            {
                case "steak":
                    Console.WriteLine($"How much steak can you buy with {totalPay} dollars?");
                    break;
                case "Shrimp":
                    Console.WriteLine($"How much shrimp can you buy with {totalPay} dollars?");
                    break;
                default:
                    Console.WriteLine($"With {totalPay} dollars you cant buy shit.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
