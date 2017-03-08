using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkLemonadeStand
{
    class Weather
    {
        public string Condition;
        public List<string> condition;
        public int Temperature;

        public Weather()
        {
            condition = new List<string>();
        }
    }
}
