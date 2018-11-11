using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsk3Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************************************************************************************");
            Console.WriteLine("*********************************Calculator****************************************************");
            Console.WriteLine("***********************************************************************************************");
            /*Write a program that asks the user to enter two numbers and an operator (+, -, *, or /).
            The program will perform the calculation on the two numbers as defined by the input operator. 
            The result of the calculation is output to the browser console.
            If an unknown operator is entered, a message will inform the user. 
            For this exercise, do not concern yourself with checking the two input numbers as being valid numeric values.
            However, test what happens when you enter a non-numeric input for one of the numbers.*/

            int num1, num2;
            float result = 0;
            string op;

            Console.WriteLine("\nEnter first number: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter second number: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nNow enter operator: +, -, *, /");
            op = Console.ReadLine();

            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Sorry, you have entered a wrong operator. Please try again");
                    break;

            }
            Console.WriteLine("Result = " + result);
            Console.ReadLine();

            output();
        }

        public static void output()
        {
            return;
        }
    
    }
}
