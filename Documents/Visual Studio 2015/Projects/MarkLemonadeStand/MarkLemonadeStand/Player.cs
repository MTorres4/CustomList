using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkLemonadeStand
{
    public class Player
    {
        public Inventory inventory;
        public string PlayerName;
        public int Wallet;

        public Player()
        {
            inventory = new Inventory();
        }

        public void GetName()
        {

        }
    }
}
