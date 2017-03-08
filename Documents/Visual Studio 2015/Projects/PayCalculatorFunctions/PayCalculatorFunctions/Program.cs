using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayCalculatorFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
        }public int GrossPayCalculator(double Hours, double PayRate)
            {
            Console.WriteLine("Please Enter your hours ");
            double GrossPay;
            Hours = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter your Pay Rate ");
            GrossPay = Hours * PayRate;
            Console.WriteLine("Your hours were {hours} and your hourly rate is {PayRate} making your gross pay {GrossPay}");
            Console.ReadLine();
            }
        }
    }
