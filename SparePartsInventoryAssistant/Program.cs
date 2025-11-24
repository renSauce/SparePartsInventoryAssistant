using System;

// Inventory variable: Array of strings 

var inventory = new[] { "hydraulic pump", "PLC module", "servo motor" };

Console.WriteLine("Hej. Welcome to the spare parts inventory!");
// To make the UI more readable
Console.WriteLine();
Console.WriteLine("Which part do you need?");

// Loop continues until match is found
while (true)
{   
    // Read user input - string - handle null/empty string input
    var input = Console.ReadLine() ?? "";
    
    // Exact match with inventory array - between input and inventory parts
    var index = Array.IndexOf(inventory, input);
    if (index >= 0)
    {
        Console.WriteLine($"I have got {inventory[index]} here for you. Bye!");
        break;
    }

    // Special queries - if input matches either of the two strings, show inventory count and list parts
    if (input == "Do you actually have any parts?" || input == "Is there anything in stock at all?")
    {   
        // Inventory parts count
        Console.WriteLine($"We have {inventory.Length} part(s)!");
        // List all parts in inventory
        foreach (var part in inventory)
            Console.WriteLine(part);
    }
    else
    {   
        //String Concatenation
        Console.WriteLine($"I am afraid we do not have any {input} in the inventory");
    }
    
    // To make the UI more readable
    Console.WriteLine();
    Console.WriteLine("Which part do you need?");
}
