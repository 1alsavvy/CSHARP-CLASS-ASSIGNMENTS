using System;
/*using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

namespace momo
{
    class Program
    {
        static void Main(string[] args)
        {
            int Password;
            int Shortcode;
            Shortcode = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Your Code");
            Password = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Menu \n-----------------------");
            Console.WriteLine("\n1Transfer Money \n2.MoMoPay & Paybill \n3.Airtime & Bundles \n4.Allow Cash Out \n5.Financial Services \n6.My Wallet");

               int Ans = Convert.ToInt16(Console.ReadLine());
            switch (Ans)
            {
                case 1:
                    Console.WriteLine("\n1)MoMo User \n2)Non MoMo User \n3)Send with care \n4)Favorite \n5)Other Networks \n6)Bank Account \0)Back");
                    break;
            }
        }
    }
}
