using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsk1GuessMyFavouritePet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************************************************");
            Console.WriteLine("*************Guess My Favourite Pet*************");
            Console.WriteLine("************************************************\n");
            //Write a program that asks the user to enter the name of a type of pet(ie.dogs, rabbits, chickens or parrots) in order to guess the favorite pet type.
            //A message indicating if the guess was correct or incorrect is output to the browser console.
            //The favorite pet type is preset in the program code, ie.assigned to a variable. A message is displayed to the user if they enter an unrecognised pet.
            string pet;

            Console.WriteLine("\nEnter the name of a pet: ");
            pet = (Console.ReadLine());

            switch (pet)
            {
                case "Cat":
                    Console.WriteLine("Cat");
                    break;
                case "Dog":
                    Console.WriteLine("Dog");
                    break;
                case "Rabbit":
                    Console.WriteLine("Rabbit");
                    break;
                case "Parrot":
                    Console.WriteLine("Parrot");
                    break;
                default:
                    Console.WriteLine("An unexpected name");
                    break;
            }
            Console.ReadLine();
        }
    }
}
