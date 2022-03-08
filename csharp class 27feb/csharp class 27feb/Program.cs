using System;
/*using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

namespace csharp_class_27feb
{
    class Program
    {
        static void Main(string[] args)
        {
            int Base, Height;
            Console.WriteLine("Enter the Base");
            Base = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the Height");
            Height = Convert.ToInt16(Console.ReadLine());
            double Hypo=Math.Sqrt(Math.Pow(Base,2)+
                Math.Pow(Height, 2));
            Console.Write("\nA triangle of Base - "+
                Base + " and Height - "+ Height +
                "produces a Hypotenuse of "+
                Hypo.ToString("N3"));

        }
    }
}
