using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.cs
{
    public class Card
    {
        public int Value { get; set; }

        public Card(int _value)
        {
            Value = _value;
        }
        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
