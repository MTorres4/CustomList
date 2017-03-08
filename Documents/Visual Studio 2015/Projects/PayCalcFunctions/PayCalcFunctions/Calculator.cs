using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayCalcFunctions
{
    class Calculator
    {
        public int GetUserHours()
        {
            Console.WriteLine("Please enter your hours");
            int Hours = int.Parse(Console.ReadLine());
            return Hours;
        }
        public double GetUserRate()
        {
            Console.WriteLine("Please enter your rate");
            double Rate = double.Parse(Console.ReadLine());
            return Rate;
        }
        public double CalculateGrossPay(int Hours, double Rate)
        {
            double GrossPay = Rate * Hours;
            Console.WriteLine($"Your hours were {Hours} and your hourly rate is {Rate} and your gross pay is {GrossPay}");
            return GrossPay;
        }
    }
}
