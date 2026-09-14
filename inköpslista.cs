static void Groceries()
{
    // Creating lists to keep track of the items and their prices
    List<string> items = [];
    List<int> prices = [];

    // Ask what item to put into the list
    Console.WriteLine("Input an item for your grocery list: ");
    // Read the input value
    string readItem = Console.ReadLine()!;

    if (string.IsNullOrWhiteSpace(readItem))
    {
        Console.WriteLine("Could not register, input a new item again: ");
    }
    else
    {
        items.Add(readItem); 
        Console.WriteLine($"1. {readItem} has been added to the grocery list.");
    }
}
Groceries();