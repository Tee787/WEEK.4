using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task.1
            //string pet; 

            //Console.WriteLine("************************************************");
            //Console.WriteLine("*****************Exercise_1*********************");
            //Console.WriteLine("************************************************");                  

            //    Console.WriteLine("\nEnter the name of a pet: ");
            //    pet = (Console.ReadLine());

            //switch (pet)
            //{
            //    case "Cat":
            //        Console.WriteLine("Cat");

            //        break;
            //    case "Dog":
            //        Console.WriteLine("Dog");
            //        break;
            //    case "Rabbit":
            //        Console.WriteLine("Rabbit");
            //        break;
            //    case "Parrot":
            //        Console.WriteLine("Parrot");
            //        break;
            //    default:
            //        Console.WriteLine("An unexpected name");
            //        break;

            //}   
            //            Console.ReadLine();

            //Task.2

            string fruit;
            bool loopContinue = true;
            


                Console.WriteLine("**********************************************************");
            Console.WriteLine("***********************Exercise 2*************************");
            Console.WriteLine("**********************************************************");

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

            // Task.3




            output();
        }

        public static void output()
        {

        }
    }
}
