using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects
{
    public class Calculator
    {
        public static void MyCalculator()
        {
            Boolean moreCalc = true;
            do
            {
                try
                {
                    double a, b;
                    Console.WriteLine("Enter number 1: "); 
                    a = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter number 2: "); 
                    b = Convert.ToDouble(Console.ReadLine());

                    int theChoice = CalculatorFunction();

                    CalculationAnswer(theChoice, a, b);
                    
                    Console.WriteLine("Do you want to do another calculation? [y/n]");
                    string result = (Console.ReadLine().ToLower());
                    if (result == "n")
                    {
                        moreCalc = false;
                        Console.WriteLine("Click to exit");
                    }
                    else if(result == "y")
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("You did not select yes or no, the program will continue until you select no.");
                    }
                }
                catch (Exception msg)
                {
                    Console.WriteLine(msg.Message);
                    Console.WriteLine("You must enter an integer!");
                }

            } while (moreCalc == true);
        }
        private static int CalculatorFunction()
        {
            Console.WriteLine("Press 1 to add: "); 
            Console.WriteLine("Press 2 to subtract: ");
            Console.WriteLine("Press 3 to multiply: ");
            Console.WriteLine("Press 4 to divide: ");
            string theChoice = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(theChoice))
            {
                Console.WriteLine("You did not enter a valid entry");
            }
            int intChoice = Convert.ToInt32(theChoice);
            return intChoice;
        }
        private static void CalculationAnswer(int theChoice, double a, double b)
        {
            switch (theChoice)
            {
                case 1:
                    Console.WriteLine($"{a} added to {b} will equal: {a + b}");
                    break;
                case 2:
                    Console.WriteLine($"{a} subtracted by {b} will equal: {a - b}");
                    break;
                case 3:
                    Console.WriteLine($"{a} multiplied by {b} will equal: {a * b}");
                    break;
                case 4:
                    Console.WriteLine($"{a} divided by {b} will equal: {a / b}");
                    break;
                default:
                    Console.WriteLine("You entered an invalid entry");
                    break;
            }
        }
    }
}
