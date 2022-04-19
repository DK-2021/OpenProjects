using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.cs
{
    public class Deal
    {
        public Deal()
        {
            // does nothing
        }
        public int DealCards(int playersValue)
        {
            Random random = new Random();

            playersValue += random.Next(1, 11);
            return playersValue;
        }
    }
}
