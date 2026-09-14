static void Groceries()
{
    // Creating lists to keep track of the items and their prices
    List<string> items = [];
    List<int> prices = [];

    int readPrice;

    while (true)
    {
        // Ask what item to put into the list
        Console.WriteLine("Input an item for your grocery list: ");
        // Read the input value
        string readItem = Console.ReadLine()!;
        if (string.IsNullOrWhiteSpace(readItem))
        {
            Console.WriteLine("Could not register, input a new item again: ");
            continue;
        }
        else
        {
            items.Add(readItem);
            // Console.WriteLine($"{count++}. {readItem} has been added to the grocery list.");

        }
        while (true)
        {
            //Ask about the price
            Console.WriteLine($"Input a price for the {readItem}: ");
            if (int.TryParse(Console.ReadLine(), out readPrice))
            {
                prices.Add(readPrice);
                // Console.WriteLine($"It costs {readPrice} kr");
                break;
            }
            else
            {
                Console.WriteLine("Could not register, input a new price again: ");
            }
        }
        Console.Clear();

        Console.WriteLine("\nGrocery List");
        // Print out the whole list
        for (int i = 0; i < items.Count; i++)
        {
            // i + 1 to make the list print out start value 1 instead of zero
            Console.WriteLine($"{i + 1}. {items[i]} - {prices[i]} kr");
        }
    }
}
Groceries();