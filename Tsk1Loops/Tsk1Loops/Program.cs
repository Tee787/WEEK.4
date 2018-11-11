using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsk1Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************************************************************");
            Console.WriteLine("******************************Task 1****************************");
            Console.WriteLine("****************************************************************\n");
            //Output a table showing multiple of numbers(x 10, X100 and x1000) in a range from a beginning set number to another end set number. 
            //Use a “for”, while” and a “do while” loop.
            int start, end;

            Console.WriteLine("******************************************************************");
            Console.WriteLine("**************************** Task 1 ******************************");
            Console.WriteLine("******************************************************************\n");
            Console.Write("\nPlease enter the starting point: \n");
            start = int.Parse(Console.ReadLine());
            Console.Write("\nPlease enter the ending point: \n");
            end = int.Parse(Console.ReadLine());
            Console.Write("\nN\t10xN\t\t100xN\t\t1000xN");
            Console.Write("\n-\t-----\t\t----\t\t------");
            //----------------------------"for loop"--------------------------
            Console.WriteLine("\n>>>>>>>>>> for loop <<<<<<<<<<<<<");
            for (int i = start; i <= end; i++)
            {

                Console.WriteLine($"{i}\t{i * 10}\t\t{i * 100}\t\t{i * 1000}\n");
            }
            //-----------------------------"while loop"-------------------------
            Console.WriteLine(">>>>>>>>>> while loop <<<<<<<<<<<<<");
            int j = start;
            while (j <= end)
            {

                Console.WriteLine($"{j}\t{j * 10}\t\t{j * 100}\t\t{j * 1000}\n");
                j++;
            }
            //-----------------------------"do / while loop"-------------------------
            Console.WriteLine(">>>>>>>>>> while loop <<<<<<<<<<<<<");
            int k = start;
            do
            {
                Console.WriteLine($"{k}\t{k * 10}\t\t{k * 100}\t\t{k * 1000}\n");
                k++;
            } while (k <= end);

            Console.ReadLine();

        }
    }
}
