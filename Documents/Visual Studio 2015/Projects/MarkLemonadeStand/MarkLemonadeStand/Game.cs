using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkLemonadeStand
{
    class Game
    {
        public Player player;
        public Day day;
        public Store store;
        public Weather weather;
        public int DayCounter;
        public string MenuOptions;

        public Game()
        {
            player = new Player();
            day = new Day();
            store = new Store();
            weather = new Weather();
        }

        public void Intro()
        {

        }

        public void MainMenu()
        {

        }
    }
}
