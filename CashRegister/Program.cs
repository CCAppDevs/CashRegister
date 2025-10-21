namespace CashRegister
{
    // --- Verbs/Actions - Things we can do ---
    // Menu
    // Prompt the user
    // Add to the list
    // Calculate Function
    // Change Tax Rate
    // Print the list
    internal class Program
    {
        // global variables
        static int currentIndex = 0;
        static double[] prices = new double[10];

        static void Main(string[] args)
        {
            // App that calculates the total of many items and the subtotal after tax

            // --- Nouns/Variables - Things we know ---
            double taxRate = 0.10;
            bool isRunning = true;
            int choice = -1;

            while (isRunning)
            {
                PrintMenu();
                // capture the users choice
                choice = PromptInt("What would you like to do?");

                // choose which action to do based on value of choice
                switch (choice)
                {
                    case 0:
                        // exit
                        isRunning = false;
                        break;
                    case 1:
                        AddItem(1.2);
                        break;
                    case 2:
                        PrintList();
                        break;
                    default:
                        // invalid choice, something went wrong
                        Console.WriteLine("Invalid choice, please try again");
                        break;
                }

            }
        }

        static void PrintMenu()
        {
            Console.WriteLine("#######################");
            Console.WriteLine("Main Menu");
            Console.WriteLine("#######################");
            Console.WriteLine();
            Console.WriteLine("1. Add Item");
            Console.WriteLine("2. Print List");
            Console.WriteLine("3. Calculate Tax");
            Console.WriteLine("4. Change Tax Rate");
            Console.WriteLine("0. Exit");
        }

        static int PromptInt(string message)
        {
            Console.Write(message + " ");
            int value = -1;

            // try to parse the input to an integer and place in value
            if (Int32.TryParse(Console.ReadLine(), out value))
            {
                // return the succesful parse
                return value;
            } else
            {
                // return an unsuccesful parse
                return -1;
            }
        }

        static void AddItem(double price)
        {
            // add an item
            if (currentIndex >= 10)
            {
                Console.WriteLine("Too Many Items. Cannot Add");
                return;
            }

            prices[currentIndex] = price;
            currentIndex++;
            Console.WriteLine("Price Added to List.");
        }

        static void Calculate()
        {

        }

        static void ChangeTaxRate(double rate)
        {

        }

        static void PrintList()
        {
            Console.WriteLine("Printing the list of prices:");

            for (int i = 0; i < prices.Length; i++)
            {
                Console.WriteLine(prices[i]);
            }
        }
    }
}
