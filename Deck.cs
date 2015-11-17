using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HILowCard
{
    class deck
    {
        private string[] CardArray = new string[52];
        private string suit_n, rank_n;

        // card card_c = new card();
        public void Deck()
        {

            for (int i = 0; i < 52; i++)
            {
                suit_n = card.CardSuit_n(i % 4);
                rank_n = card.CardRank_n(i % 13);
                CardArray[i] = rank_n + suit_n;
            }
        }

        public void Shuffle(Player s, int numofset)
        {
            string[] newArray = new string[26];
            string tmp;
            newArray = s.Deck_card;
            Random rnd = new Random();
            int iCount = numofset;
            int bNum;
            while (iCount < 26)
            {
                bNum = rnd.Next(numofset, 26);
                tmp = newArray[bNum];
                newArray[iCount] = newArray[bNum];
                newArray[bNum] = tmp;
                iCount++;
            }
            s.Deck_card = newArray;
        }

        public void Shuffle()
        {
            string[] newArray = new string[52];
            string tmp;
            newArray = CardArray;
            Random rnd = new Random();
            int iCount = 0;
            int iNum;

            while (iCount < 52)
            {
                iNum = rnd.Next(0, 52);
                tmp = newArray[iCount];
                newArray[iCount] = newArray[iNum];
                newArray[iNum] = tmp;
                iCount++;
            }

            CardArray = newArray;
        }

        public void DealCard(Player s1, Player s2)
        {
            int j, k;
            j = k = 0;
            for (int i = 0; i < 52; i++)
            {
                if (i % 2 == 0)
                {
                    s1.Deck_card[j] = CardArray[i];
                    j++;
                }
                else
                {
                    s2.Deck_card[k] = CardArray[i];
                    k++;
                }
            }
        }
    }
}
