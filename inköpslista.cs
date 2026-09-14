static void Groceries()
{
    // Creating lists to keep track of the items and their prices
    List<string> items = [];
    List<int> prices = [];

    // Ask what item to put into the list
    Console.WriteLine("Input an item for your grocery list: ");
    // Read the input value
    string readItem = Console.ReadLine()!;
    int readPrice;
    int count = 1;

    if (string.IsNullOrWhiteSpace(readItem))
    {
        Console.WriteLine("Could not register, input a new item again: ");
    }
    else
    {
        items.Add(readItem);
        Console.WriteLine($"{count++}. {readItem} has been added to the grocery list.");

        //Ask about the price
        Console.WriteLine($"Input a price for the {readItem}: ");
        if (int.TryParse(Console.ReadLine(), out readPrice))
        {
            prices.Add(readPrice);
            Console.WriteLine($"It costs {readPrice} kr");
        }else
        {
            Console.WriteLine("Could not register, input a new price again: ");
        }
    }


}
Groceries();