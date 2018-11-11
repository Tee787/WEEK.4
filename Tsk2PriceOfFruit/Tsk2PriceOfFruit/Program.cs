using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsk2PriceOfFruit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********************************************************");
            Console.WriteLine("********************Price of Fruit************************");
            Console.WriteLine("**********************************************************\n");
            /*Write a program that asks the user to enter the name of a fruit variety in order to return the price per kilogram.
            A message indicating the name of the fruit and its price is output to the browser console.
            If an unknown fruit type is entered, a message will inform the user. 
            The prices of the fruits are preset in the program code as constants.
            The following table shows the known fruit types and their cost per kilogram:*/
            string fruit;
            bool loopContinue = true;

            Console.WriteLine("\nEnter a fruit to find out the price per kg:\n ");
            fruit = Console.ReadLine();

            do
            {
                switch (fruit)
                {
                    case "Apple":
                        Console.WriteLine("\nApples @ $1.25 per kg\n");
                        loopContinue = false;
                        break;

                    case "Banana":
                        Console.WriteLine("\nBananas @ $3.15 per kg\n");
                        loopContinue = false;
                        break;
                    case "Kiwifruit":
                        Console.WriteLine("\nKiwifruit @ $4.65 per kg\n");
                        loopContinue = false;
                        break;
                    case "Orange":
                        Console.WriteLine("\nOranges @ $2.75 per kg\n");
                        loopContinue = false;
                        break;
                    default:
                        Console.WriteLine("\nSorry, there is no pricing per kg for your choice. Please try again:");
                        loopContinue = true;
                        break;
                }

            } while (loopContinue);


            Console.ReadLine();
        }
    }
}
