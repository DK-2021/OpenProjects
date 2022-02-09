using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects
{
    public class PasswordGenerator
    {
        public void newPassword()
        {
            try
            {
                bool anotherPassword = true;
                bool goodEntry = false;
                int badEntry;

                do
                {
                    Console.Write("Enter the password length from [1 - 50]: ");
                    int passLength = int.Parse(Console.ReadLine());
                    if (passLength >= 1 && passLength <= 50)
                    {
                        const string chars = "qazxswedcvfrtgbnhyujmkilopQAZXSWEDCVFRTGBNHYUJMKIOLP1234567890!@#$%^&*_";
                        Random rnd = new Random();
                        StringBuilder password = new StringBuilder();

                        while (0 < passLength)
                        {
                            password.Append(chars[rnd.Next(chars.Length)]);
                            passLength--;
                        }
                        Console.WriteLine($"Your randomly generated password: {password.ToString()}");
                        
                        Console.WriteLine("Do you want to create another password? [y/n]: ");
                        string answer = Console.ReadLine().ToLower();
                        goodEntry = int.TryParse(answer, out badEntry);
                        
                        if (goodEntry == false && answer == "y")
                        {
                            continue;
                        }
                        else 
                        {
                            anotherPassword = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"You entered, {passLength}, which is an invalid entry");
                    }

                } while (anotherPassword);
            }
            catch (Exception mess)
            {
                Console.WriteLine($"There was an error with the program: {mess}");

            }
        }
    }
}
