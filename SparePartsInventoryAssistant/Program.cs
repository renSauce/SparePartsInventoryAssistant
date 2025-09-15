using System;

var inventory = new[] { "hydraulic pump", "PLC module", "servo motor" };

Console.WriteLine("Hej. Welcome to the spare parts inventory!");
Console.WriteLine();
Console.WriteLine("Which part do you need?");

// Loop continues until match is found
while (true)
{
    var input = Console.ReadLine();

    if (input == null) continue;

    // Exact match with inventory array
    var index = Array.IndexOf(inventory, input);
    if (index >= 0)
    {
        Console.WriteLine($"I have got {inventory[index]} here for you. Bye!");
        break;
    }

    // Special queries
    if (input == "Do you actually have any parts?" || input == "Is there anything in stock at all?")
    {
        Console.WriteLine($"We have {inventory.Length} part(s)!");
        foreach (var part in inventory)
            Console.WriteLine(part);
    }
    else
    {
        Console.WriteLine($"I am afraid we do not have any {input} in the inventory");
    }

    Console.WriteLine();
    Console.WriteLine("Which part do you need?");
}
