using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HILowCard
{
    class Player
    {
        public string _name;
        public int num_of_card;
        public string[] Deck_card = new string[30];

        public Player(string name)
        {
            _name = name;
            num_of_card = 0;
        }
    }
}
