using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects
{
    public class Compound_Interest_Calculator
    {
        public double principalInvested { get; set; } // Principal amount invested
        public double rateOfReturn { get; set; } // Expected rate of return
        public double yearsLeftAlone { get; set; } // Time in years investment is left alone
        public double compoundFrequency { get; set; } // Frequency of times compounded in a given year

        public Compound_Interest_Calculator()
        {
            // default contructor
        }
        public Compound_Interest_Calculator(double _principal, double _rate, double _year, double _compound)
        {
            principalInvested = _principal;
            rateOfReturn = _rate;
            yearsLeftAlone = _year;
            compoundFrequency = _compound;
        }
        public string CompoundCalculator()  
        {
            var rateBefore = rateOfReturn;
            
            rateOfReturn /= 100;  // r is divided by 100 to make it a decimal 

            double amount = Math.Pow(1 + (rateOfReturn / compoundFrequency), compoundFrequency * yearsLeftAlone) * principalInvested;  //equation for compounding interest

            return $"Prinicpal invested: {string.Format("{0:C}", (decimal)principalInvested)}\n" +
                $"Expected rate of return: {rateBefore}%\n" + 
                $"Length in years of investment: {yearsLeftAlone} years\n" +
                $"Your investment at the values provided would be worth: { string.Format("{0:C}", amount)}";
        }
    }
}
