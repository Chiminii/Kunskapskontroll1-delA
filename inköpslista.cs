static void Groceries()
{
    // Creating lists to keep track of the items and their prices
    List<string> items = [];
    List<int> prices = [];
    int readPrice;

    while (true)
    {
        Console.Clear();
        Console.WriteLine("\nGrocery List");
        int totalSum = 0;
        // Print out the whole list
        for (int i = 0; i < items.Count; i++)
        {
            // calculate total cost
            totalSum += prices[i];
            // i + 1 to make the list print out start value 1 instead of zero
            Console.WriteLine($"{i + 1}. {items[i]} - {prices[i]} kr");
        }
        Console.WriteLine($"Totalt: {totalSum} kr");

        // Ask what item to put into the list
        Console.WriteLine("\nInput an item for your grocery list or a number to remove an item: ");
        // Read the input value
        string readItem = Console.ReadLine()!;
        if (string.IsNullOrWhiteSpace(readItem))
        {
            Console.WriteLine("Could not register, input a new item again: ");
            continue;
        }
        // when the user wants to remove an item
        else if (int.TryParse(readItem, out int readRemoveItem))
        {
            // take the input value minus 1 since a list starts at zero and not one
            int removeIndex = readRemoveItem - 1;
            if (removeIndex >= 0 && removeIndex < items.Count)
            {
                items.RemoveAt(removeIndex);
                prices.RemoveAt(removeIndex);
                continue;
            }
            else
            {
                Console.WriteLine("That number does not exist on the list. Press Enter to try again.");
                Console.ReadLine();
                continue;
            }
        }

        while (true)
        {
            //Ask about the price
            Console.WriteLine($"Input a price for the {readItem}: ");
            if (int.TryParse(Console.ReadLine(), out readPrice))
            {
                items.Add(readItem);
                prices.Add(readPrice);
                break;
            }
            else
            {
                Console.WriteLine("\nCould not register, item was not added. Press Enter to try again.");
                Console.ReadLine();
                break;
            }
        }
    }
}
Groceries();