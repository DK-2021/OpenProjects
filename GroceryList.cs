using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects
{
    public class GroceryList
    {
        public void theList()
        {
            List<string> myGroceries = new List<string>();

            myGroceries = AddToList(myGroceries); 

            DisplayList(myGroceries);
        }
        private List<string> AddToList(List<string> myGroceries)
        {
            bool moreGroceries = true;
            int badAdd; // Referenced in the try-block

            do
            {
                try
                {
                    Console.Write("Enter your item: ");
                    string mustAdd = Console.ReadLine();
                    bool goodAdd = int.TryParse(mustAdd, out badAdd);
                    if (goodAdd != true && String.IsNullOrWhiteSpace(mustAdd) == false)
                    {
                        myGroceries.Add(mustAdd);
                    }
                    else 
                    {
                        Console.WriteLine("You didn't enter an item to the list.");
                    }
                    Console.Write("Do you need to add another item to the list? [y/n]: ");
                    string moreAdds = (Console.ReadLine().ToLower());
                    bool addMore = int.TryParse(moreAdds, out badAdd);
                    if(addMore == true || String.IsNullOrWhiteSpace(moreAdds))
                    {
                        Console.WriteLine("You entered an invalid input.  Enter [y/n] to continue");
                        string lastChanceAdd = (Console.ReadLine().ToLower());
                        if (lastChanceAdd == "y")
                        {
                            continue;
                        }
                        else 
                        {
                            Console.WriteLine("The program ends...");
                            break;
                        }
                    }
                    else if (moreAdds == "n")
                    {
                        moreGroceries = false;
                        break;
                    }
                    else if (moreAdds == "y")
                    {
                        continue;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("There was an error: " + ex.Message);
                    throw;
                }
            } while (moreGroceries);

            return myGroceries;
        }
        private void DisplayList(List<string> myGroceries)
        {
            int count = 1;
            foreach (var i in myGroceries)
            {
                Console.WriteLine("Item #" + count + ": " + i);
                count++;
            }
        }
    }
}
