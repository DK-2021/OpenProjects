using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects
{
    public class Dividend_Calculator
    {
        public double totalShares { get; set; }
        public double sharePrice { get; set; }
        public double dividendYield { get; set; }

        public Dividend_Calculator()
        {
            // default constructor
        }
        public Dividend_Calculator(double _totalShares, double _sharePrice, double _dividendYield) // must overload the constructor
        {
            totalShares = _totalShares;
            sharePrice = _sharePrice;
            dividendYield = _dividendYield;

            Console.WriteLine(DivPayout());  // takes values provided in the fields and provides them to the DivPayout method
        }
        public string DivPayout()
        {
            const int quarter = 4;
            dividendYield /= 100;

            double perShareDividendPayout = (sharePrice * dividendYield) / quarter;
            double quartleryDividendPayout = perShareDividendPayout * totalShares;
            double yearlyDividendPayout = quartleryDividendPayout * quarter;
            double monthlyDividenPayout = yearlyDividendPayout / 12;

            return $"Your money earned per share: {string.Format("{0:C}", perShareDividendPayout)}\n" +
                $"Your money earned per monthly: {string.Format("{0:C}", monthlyDividenPayout)}\n" +
                $"Your money earned per quarter: {string.Format("{0:C}", quartleryDividendPayout)}\n" +
                $"Your money earned per year: {string.Format("{0:C}", yearlyDividendPayout)}";
        }
    }
}
