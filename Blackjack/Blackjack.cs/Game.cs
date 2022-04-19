using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.cs
{
    public class Game
    {
        public Game()
        {
            //
        }

        public void PlayBlackjack()
        {
            int playersValue = 0, dealersValue = 0;
            bool continueGame = true;
            string userDealAgain = "";

            Console.WriteLine("Entering Blackjack");

            // uses the deal class
            Deal deals = new Deal();
            
            while(continueGame == true)
            {
                // card dealing
                playersValue = deals.DealCards(playersValue);
                dealersValue = deals.DealCards(dealersValue);
                Console.WriteLine("Your current value is: {0}", playersValue);
                Console.WriteLine("The dealers value is: {0}", dealersValue);

                // checking hand value
                bool overUnder = CheckCurrentHand(playersValue);
                if (overUnder == true)
                {
                    Console.WriteLine("Hit[H] or Stay[S]");
                    userDealAgain = Console.ReadLine();
                }
                else if (playersValue == 21 && dealersValue == 21)
                {
                    Console.WriteLine("Both players win");
                    continueGame = false;
                }
                else if(playersValue == 21)
                {
                    Console.WriteLine("The player wins!");
                    continueGame = false;
                }
                else if(dealersValue == 21)
                {
                    Console.WriteLine("The dealer wins");
                    continueGame = false;
                }
                else if (playersValue > 21)
                {
                    Console.WriteLine("You are over 21!  The dealer wins");
                    continueGame = false;
                }
                else if (dealersValue > 21)
                {
                    Console.WriteLine("The dealer is over 21!  The player wins");
                    continueGame = false;
                }
                if (userDealAgain == "h" || userDealAgain == "hit")
                {
                    continue;
                }
                else if (userDealAgain == "s" || userDealAgain == "stay")
                {
                    Console.WriteLine($"Current players value: {playersValue}");
                    Console.WriteLine($"Current dealers value: {dealersValue}");
                    if (playersValue > dealersValue)
                    {
                        Console.WriteLine("The player wins!");
                    }
                    else
                    {
                        Console.WriteLine("The dealer wins!");
                    }
                    continueGame = false;
                }
            }
        }
        private static bool CheckCurrentHand(int playersValue)
        {
            return playersValue >= 0 && playersValue <= 20;
        }
    }
}
