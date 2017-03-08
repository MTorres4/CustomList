using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayCalcFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator GrossPayCalc = new Calculator();
            int Hours = GrossPayCalc.GetUserHours();
            double Rate =  GrossPayCalc.GetUserRate();
            GrossPayCalc.CalculateGrossPay(Hours, Rate);
            Console.ReadLine();
        }
    }
}
