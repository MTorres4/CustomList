using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkLemonadeStand
{
    class Customer
    {
        public List<string> Conditions;
        public double MaxPrice;
        public int MinimumTemperature;
        public string PreferredCondition;
        public int PreferredIce;
        public int PreferredLemons;
        public int PreferredSugar;

        public Customer()
        {
            Conditions = new List<string>();
        }
    }
}
