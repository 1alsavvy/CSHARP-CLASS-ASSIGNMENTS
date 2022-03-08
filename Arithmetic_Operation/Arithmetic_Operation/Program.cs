using System;
/*using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

namespace Arithmetic_Operation
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1, Num2;
            Console.WriteLine("Input Num1");
            Num1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Input Num2");


            Num2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("Arithmetric Operations \n-----------------------");
            Console.WriteLine("1. Addition \n2.Multiplication \n3.Division \n4.Subtraction");
            int Ans = Convert.ToInt16(Console.ReadLine());

            if (Ans == 1)
                Console.WriteLine("\n Addition of two numbers - " + " produces the sum of - " + (Num1 + Num2));

            else if (Ans == 2)
                Console.WriteLine("\n Multiplication of two numbers - " + " produces the product - " + (Num1 * Num2));

            else if (Ans == 3)
                Console.WriteLine("\n Division of two numbers - " + " produces the quotient - " + (Num1 / Num2));

            else if (Ans == 4)
                Console.WriteLine("\n Subtraction of two numbers - " + " produces the diffrence - " + (Num1 - Num2));
                  

        }
    }
}
