using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsk2Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("*********************************Task 2********************************");
            Console.WriteLine("***********************************************************************\n");
            //Output a times table(to the browser console) for a number input from the user (input via a web page prompt).
            //Use a “for”, while” and a “do while” loop.
            int num2, num1;
            
            Console.WriteLine("Input the number to be calculated:\n ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("\n>>>>>For Loop<<<<<\t\t>>>>>While Loop<<<<<\t\t>>>>>Do While Loop<<<<<");
            Console.Write("\n------------------\t\t--------------------\t\t-----------------------");

            Console.WriteLine("\n>>>>>>>> for loop <<<<<<<\n");
            for (num1 = 1; num1 <= 12; num1++)
            {
                Console.WriteLine("\t{0} x {1} = {2}\n", num1, num2, num1 * num2);
            }
            Console.WriteLine(">>>>>>> while loop <<<<<<<\n");

            num1 = 0;
            while (num1 <= 12)
            {
                Console.WriteLine("\t{0} x {1} = {2}\n", num1, num2, num1 * num2);
                num1++;
            }
            Console.WriteLine(">>>>>>> do while loop <<<<<<<\n");

            num1 = 0;
            do
            {
                Console.WriteLine("\t{0} x {1} = {2}\n", num1, num2, num1 * num2);
                num1++;
            } while (num1 <= 12);

            Console.ReadLine();



        }
    }
}
