using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HILowCard
{
    class Game
    {
        public static void playgame(Player s1, Player s2)
        {
            int indexofdeck = 0;
            int round = 0;
            int sum = 0;

            deck deck_card = new deck();
            deck_card.Deck();
            deck_card.Shuffle();
            deck_card.DealCard(s1, s2);

            Console.WriteLine(" ");

            while (indexofdeck != 26)
            {
                if (card.CardRank(s1.Deck_card[indexofdeck]) < card.CardRank(s2.Deck_card[indexofdeck]))
                {
                    Console.WriteLine(s1._name + " : " + s1.Deck_card[indexofdeck] + " Win " + s2._name + " : " + s2.Deck_card[indexofdeck]);
                    s1.num_of_card += (2 + (2 * sum));
                    indexofdeck++;
                    round = 0;
                    sum = 0;
                }
                else if (card.CardRank(s1.Deck_card[indexofdeck]) > card.CardRank(s2.Deck_card[indexofdeck]))
                {
                    Console.WriteLine(s2._name + " : " + s2.Deck_card[indexofdeck] + " Win " + s1._name + " : " + s1.Deck_card[indexofdeck]);
                    s2.num_of_card += (2 + (2 * sum));
                    indexofdeck++;
                    round = 0;
                    sum = 0;
                }
                else
                {
                    if (round == 0)
                    {
                        Console.WriteLine(s1._name + " : " + s1.Deck_card[indexofdeck] + " Equal " + s2._name + " : " + s2.Deck_card[indexofdeck]);
                        if (indexofdeck + card.CardRank(s1.Deck_card[indexofdeck]) <= 25)
                        {
                            sum = card.CardRank(s1.Deck_card[indexofdeck]);
                            indexofdeck += sum;
                            round = 1;

                        }
                        else
                        {
                            sum = (25 - indexofdeck);
                            indexofdeck = 25;
                            round = 1;
                        }
                    }
                    else
                    {
                        if (indexofdeck < 25)
                        {
                            Console.WriteLine(s1._name + " : " + s1.Deck_card[indexofdeck] + " Equal(again) " + s2._name + " : " + s2.Deck_card[indexofdeck] + "(Shuffle Card)");
                            round = 0;
                            indexofdeck -= sum;
                            sum = 0;
                            deck_card.Shuffle(s1, indexofdeck);
                            deck_card.Shuffle(s2, indexofdeck);
                        }
                        else
                        {
                            indexofdeck++;
                        }

                    }

                }
            }

            Console.WriteLine(" ");

            if (s1.num_of_card < s2.num_of_card)
            {
                Console.WriteLine(s1._name + " get " + s1.num_of_card + " cards Win");
            }
            else if (s2.num_of_card < s1.num_of_card)
            {
                Console.WriteLine(s2._name + " get " + s2.num_of_card + " cards Win");
            }
            else
            {
                Console.WriteLine(s1._name + " and " + s2._name + " get " + s2.num_of_card + " cards Draw");
            }
            Console.WriteLine(" ");
        }
    }
}
