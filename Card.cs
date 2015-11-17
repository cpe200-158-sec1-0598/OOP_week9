using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HILowCard
{
    class card
    {

        public static string CardSuit_n(int a)
        {
            if (a == 0) return "_Clubs";
            else if (a == 1) return "_Diamond";
            else if (a == 2) return "_Hearts";
            else return "_Spades";
        }

        public static string CardRank_n(int a)
        {
            if (a == 0) return "Ace";
            else if (a == 1) return "Two";
            else if (a == 2) return "Three";
            else if (a == 3) return "Four";
            else if (a == 4) return "Five";
            else if (a == 5) return "Six";
            else if (a == 6) return "Seven";
            else if (a == 7) return "Eight";
            else if (a == 8) return "Nine";
            else if (a == 9) return "Ten";
            else if (a == 10) return "Jack";
            else if (a == 11) return "Queen";
            else return "King";

        }

        public static int CardRank(string nameofcard)
        {
            if (nameofcard == "Ace_Clubs" || nameofcard == "Ace_Diamond" || nameofcard == "Ace_Hearts" || nameofcard == "Ace_Spades") return 1;
            else if (nameofcard == "Two_Clubs" || nameofcard == "Two_Diamond" || nameofcard == "Two_Hearts" || nameofcard == "Two_Spades") return 2;
            else if (nameofcard == "Three_Clubs" || nameofcard == "Three_Diamond" || nameofcard == "Three_Hearts" || nameofcard == "Three_Spades") return 3;
            else if (nameofcard == "Four_Clubs" || nameofcard == "Four_Diamond" || nameofcard == "Four_Hearts" || nameofcard == "Four_Spades") return 4;
            else if (nameofcard == "Five_Clubs" || nameofcard == "Five_Diamond" || nameofcard == "Five_Hearts" || nameofcard == "Five_Spades") return 5;
            else if (nameofcard == "Six_Clubs" || nameofcard == "Six_Diamond" || nameofcard == "Six_Hearts" || nameofcard == "Six_Spades") return 6;
            else if (nameofcard == "Seven_Clubs" || nameofcard == "Seven_Diamond" || nameofcard == "Seven_Hearts" || nameofcard == "Seven_Spades") return 7;
            else if (nameofcard == "Eight_Clubs" || nameofcard == "Eight_Diamond" || nameofcard == "Eight_Hearts" || nameofcard == "Eight_Spades") return 8;
            else if (nameofcard == "Nine_Clubs" || nameofcard == "Nine_Diamond" || nameofcard == "Nine_Hearts" || nameofcard == "Nine_Spades") return 9;
            else if (nameofcard == "Ten_Clubs" || nameofcard == "Ten_Diamond" || nameofcard == "Ten_Hearts" || nameofcard == "Ten_Spades") return 10;
            else if (nameofcard == "Jack_Clubs" || nameofcard == "Jack_Diamond" || nameofcard == "Jack_Hearts" || nameofcard == "Jack_Spades") return 11;
            else if (nameofcard == "Queen_Clubs" || nameofcard == "Queen_Diamond" || nameofcard == "Queen_Hearts" || nameofcard == "Queen_Spades") return 12;
            else return 13;
        }


    }
}
