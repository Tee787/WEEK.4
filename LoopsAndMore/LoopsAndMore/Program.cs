using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsAndMore
{
    class Program
    {
        static void Main(string[] args)
        {
            //******************************************* Task 1 *********************************************
            // int start, end;

            //Console.WriteLine("******************************************************************");
            //Console.WriteLine("**************************** Task 1 ******************************");
            //Console.WriteLine("******************************************************************\n");
            // Console.Write("\nPlease enter the starting point: \n");
            // start = int.Parse(Console.ReadLine());
            // Console.Write("\nPlease enter the ending point: \n");
            // end = int.Parse(Console.ReadLine());
            // Console.Write("\nN\t10xN\t\t100xN\t\t1000xN");
            // Console.Write("\n-\t-----\t\t----\t\t------");
            // //----------------------------"for loop"--------------------------
            // Console.WriteLine("\n>>>>>>>>>> for loop <<<<<<<<<<<<<");
            //for (int i = start; i <= end; i++)
            // {

            //     Console.WriteLine($"{i}\t{i * 10}\t\t{i * 100}\t\t{i * 1000}\n");
            // }
            // //-----------------------------"while loop"-------------------------
            // Console.WriteLine(">>>>>>>>>> while loop <<<<<<<<<<<<<");
            // int j = start;
            // while (j <= end)
            // {

            //     Console.WriteLine($"{j}\t{j * 10}\t\t{j * 100}\t\t{j * 1000}\n");
            //     j++;
            // }
            // //-----------------------------"do / while loop"-------------------------
            // Console.WriteLine(">>>>>>>>>> while loop <<<<<<<<<<<<<");
            // int k = start;
            // do
            // {
            //     Console.WriteLine($"{k}\t{k * 10}\t\t{k * 100}\t\t{k * 1000}\n");
            //     k++;
            // } while (k <= end);

            // Console.ReadLine();

            //******************************************* Task 2 *********************************************

            int num2, num1;

            Console.WriteLine("******************************************************************");
            Console.WriteLine("**************************** Task 2 ******************************");
            Console.WriteLine("******************************************************************\n");
            Console.WriteLine("Input the number to be calculated:\n ");
            num2 = int.Parse(Console.ReadLine());


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

            //******************************************* Task 3 *********************************************

            //Console.WriteLine("******************************************************************");
            //Console.WriteLine("**************************** Task 3 ******************************");
            //Console.WriteLine("******************************************************************\n");

            //float x, y, square, cube;


            //Console.WriteLine("Input start number is: ");
            //x = int.Parse(Console.ReadLine());
            //Console.WriteLine("Input end number is: ");
            //y = int.Parse(Console.ReadLine());
            //Console.Write("\nNumber\tSquare\t\tCube\t\t1000xN");
            //Console.Write("\n-\t-----\t\t----\t\t------\n");
            //Console.WriteLine(">>>>>>>>>>>>>>> for loop <<<<<<<<<<<<<<<<<");

            //for (float i = x; i <= y; i++)
            //{
            //    Console.WriteLine("{i}\t{i * x^2}\t\t{i * x^3}", x, x*x, x*x*x);
            //}

            //Console.Read();
        }
    }
}
