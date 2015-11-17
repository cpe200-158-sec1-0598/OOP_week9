using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HILowCard
{
    class Program
    {
        static void Main(string[] args)
        {
            Player s1 = new Player("Player 1");
            Player s2 = new Player("Player 2");

            Game.playgame(s1, s2);
            Console.ReadLine();
        }

    }

}
