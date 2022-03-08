using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8th_MARCH
{
    class Program
    {
        static void Main(string[] args)
        {
            int again = 1;
            while (again == 1)
            {

                double basic_salary, tax_relief, ssnit, chg_income, net, income_tax;
                const double ssnit_rate = 0.035;

                Console.WriteLine("Basic Salary: ");
                basic_salary = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Tax Relief: ");
                tax_relief = Convert.ToDouble(Console.ReadLine());

                ssnit = basic_salary * ssnit_rate;

                chg_income = basic_salary - (ssnit + tax_relief);

                if (chg_income <= 365)
                {
                    income_tax = 0;

                }
                else if (chg_income <= 475)
                {
                    income_tax = (chg_income - 365) * 0.05;
                }
                else if (chg_income <= 605)
                {
                    income_tax = 5.5 + ((chg_income - 475) * 0.10);

                }
                else if (chg_income <= 3605)
                {
                    income_tax = 5.5 + 13.0 + ((chg_income - 605) * 0.175);

                }
                else if (chg_income <= 2000)
                {
                    income_tax = 5.5 + 13.0 + 525 + ((chg_income - 3605) * 0.25);
                }

                else
                {
                    income_tax = 5.5 + 13.0 + 525 + 4098.75 + ((chg_income - 20000) * 0.30);

                }

                        Console.WriteLine("\nBasic Salary -" + basic_salary.ToString("C") +
                            "\nTax Relief - " + tax_relief.ToString("C") +
                            "\nSSNIT Contribution - " + ssnit.ToString("C") +
                            "\nIncome Tax - " + income_tax.ToString("C") +
                            "\nNet Income - " + (basic_salary - (ssnit + income_tax)).ToString("C") + "\n");
                        Console.WriteLine("\nEnter 1 to continue......");
                        again = Convert.ToInt16(Console.ReadLine());
                    }
                }

            }

        }
    

    

 

