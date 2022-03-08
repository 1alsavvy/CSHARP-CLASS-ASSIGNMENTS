using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0, min = 100, mark, sum = 0;
            double avg;
            for (int a = 1; a < 8; a++)
            {
                Console.WriteLine("Select the Loop of your choice");
                Console.WriteLine("\nFor Loop \nWhile Loop \nDo While Loop");
                mark = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("\nEnter Mark - " + a + " : ");

                mark = Convert.ToInt16(Console.ReadLine());
                //Cumulative Sum
                sum += mark;  //sum=sum+mark
                //Highest Mark
                if (mark > max)
                {
                    max = mark;
                    //Lowest Mark
                    if (mark > min)
                    {
                        max = mark;
                    }

                }
                
            }
            avg = sum / 7;
            //Display Answers
            Console.WriteLine("\nTotal Score - " + sum +
                "\nHighest Score - " + max +
                "\nLowest Score - " + min +
                "\nAverage Score - " + avg.ToString("N3") + "\n");
        }
    }
}

            


