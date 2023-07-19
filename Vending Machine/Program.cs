using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the vending machine.");
            Console.WriteLine("\nMenu:");
            Console.WriteLine("Soda -------- $1");
            Console.WriteLine("Cookies -------- $2");
            Console.WriteLine("Chips -------- $1.50");
            // Present menu

            double OrderTotal = 0;
            bool ErrorEncountered = false;
            string ContinueShopping = "yes";
            int ItemQuantity = 0;
            string ItemQuantityInput = "null";
            string UserOrder = "null";
            // Set up some variables for later

            while (ContinueShopping == "yes")
            {
                Console.WriteLine("\nPlease enter soda, cookies, or chips to purchase the given item:");
                UserOrder = Console.ReadLine();
                // Prompt user for input

                ErrorEncountered = false;
                // Reset error marker

                if (UserOrder != "cookies" && UserOrder != "soda" && UserOrder != "chips")
                {
                    Console.WriteLine("\nSorry, your input does not match an item on the menu.");
                    ErrorEncountered = true;
                }
                // Ensure that user input matches an item on the menu

                if (ErrorEncountered != true)
                {
                    Console.WriteLine("\nHow many " + UserOrder + " would you like?");
                    ItemQuantityInput = Console.ReadLine();
                    ItemQuantity = Convert.ToInt32(ItemQuantityInput);
                }
                // Prompt for input and save to variables

                if (UserOrder == "soda")
                {
                    OrderTotal = 1 * ItemQuantity + OrderTotal;
                }
                else if (UserOrder == "cookies")
                {
                    OrderTotal = 2 * ItemQuantity + OrderTotal;
                }
                else if (UserOrder == "chips")
                {
                    OrderTotal = 1.5 * ItemQuantity + OrderTotal;
                }

                if (ErrorEncountered == false)
                {
                    Console.WriteLine("\nThank you for adding " + ItemQuantity + " " + UserOrder + " to your cart.");
                    Console.WriteLine("Your total comes to $" + OrderTotal + ".");
                }
                // To prevent useless presentation of order total if the user input was invalid,
                // only display total message if variable ErrorEncountered is false

                Console.WriteLine("\nWould you like to purchase an additional item? \nType \"yes\" to keep shopping or \"no\" to end shopping.");
                ContinueShopping = Console.ReadLine();
                if (ContinueShopping == "no")
                {
                    break;
                }
                // Ask the user if they wish to continue shopping and if so, repeat process, otherwise break
            }
        }   
    }
}
