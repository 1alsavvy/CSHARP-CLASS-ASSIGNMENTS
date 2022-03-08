using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cls5
{
    class Program
    {
        static void Main(string[] args)
        {
            int again = 1;
                while ( again == 1){
                    Console.WriteLine("please enter the number of scores");
                    int max = 0, min = 100, mark, sum = 0, a = 0, b;
                    b = Convert.ToInt16(Console.ReadLine());
                    double avg; 
                    
                    do 
                    {
                        a++;
                        Console.WriteLine("Enter mark - " + a + ":");
                        mark = Convert.ToInt16(Console.ReadLine());
                        //Cumulative sum
                        sum += mark;
                        if (mark > max)
                        {
                            max = mark;
                        }
                        if (mark < min)
                        {
                            min = mark;
                        }
                    }
                    while (a < b);
                    avg = sum / b;
                    Console.WriteLine("\nNumber of courses : "+b+"\nTotal score : " + sum + "\nHighest score : " + max + "\nLowest score : " + min + "\nAverage score : " + avg + "\n\n");
                    Console.WriteLine("continue? enter 1 ");
                    again = Convert.ToInt16(Console.ReadLine());

                }
           
            Console.ReadKey();
        }

        }
    
}
