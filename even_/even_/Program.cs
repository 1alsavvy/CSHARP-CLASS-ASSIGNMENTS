using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace even_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an even number");
            int a = Convert.ToInt16(Console.ReadLine());
            if (a % 2 != 0)
            {
                {
                    Console.WriteLine("Enter an Even Number!");
                    a = Convert.ToInt16(Console.ReadLine());
                }

            }
        }
        
    }
}
