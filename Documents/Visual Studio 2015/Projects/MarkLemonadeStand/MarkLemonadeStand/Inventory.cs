using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkLemonadeStand
{
    public class Inventory
    {
        public Pitcher pitcher;
        public List<cups> cups;
        public List<ice> ice;
        public List<lemons> lemons;
        public List<sugar> sugar;
        public int IceUsed;
        public int LemonsUsed;
        public int SugarUsed;

        public Inventory()
        {
            pitcher = new Pitcher();
            cups = new List<cups>();
            ice = new List<ice>();
            lemons = new List<lemons>();
            sugar = new List<sugar>();
        }

        public void DisplayInventory()
        {

        }

        public void IceRecipe()
        {

        }

        public void LemonRecipe()
        {

        }

        public void SugarRecipe()
        {

        }
    }
}
