using System;
using System.Collections.Generic;

class RecordKeepingProgram
{
    static void Main()
    {
        Dictionary<string, string> records = new Dictionary<string, string>();

        while (true)
        {
            Console.WriteLine("\n--- Record Keeping Menu ---");
            Console.WriteLine("[1] Add Data");
            Console.WriteLine("[2] Delete Data");
            Console.WriteLine("[3] Display Data");
            Console.WriteLine("[4] End");
            Console.Write("Enter your choice (1-4): ");

            string? choice = Console.ReadLine()?.Trim();

            if (choice == "1")
            {
                Console.Write("Enter Key: ");
                string? key = Console.ReadLine()?.Trim();

                if (string.IsNullOrEmpty(key))
                {
                    Console.WriteLine("Error: Key cannot be empty.");
                    continue;
                }

                if (records.ContainsKey(key))
                {
                    Console.WriteLine($"Error: Duplicate key! '{key}' already exists in the records.");
                }
                else
                {
                    Console.Write("Enter Value: ");
                    string? value = Console.ReadLine()?.Trim();

                    if (string.IsNullOrEmpty(value))
                    {
                        Console.WriteLine("Error: Value cannot be empty.");
                    }
                    else
                    {
                        records.Add(key, value);
                        Console.WriteLine($"Success: Record '{key}: {value}' added.");
                    }
                }
            }
            else if (choice == "2")
            {
                if (records.Count == 0)
                {
                    Console.WriteLine("Error: The record list is currently empty. Nothing to delete.");
                    continue;
                }

                Console.Write("Enter Key to delete: ");
                string? key = Console.ReadLine()?.Trim();

                if (string.IsNullOrEmpty(key))
                {
                    Console.WriteLine("Error: Key cannot be empty.");
                    continue;
                }

                if (records.Remove(key))
                {
                    Console.WriteLine($"Success: Deleted key '{key}'.");
                }
                else
                {
                    Console.WriteLine($"Error: Key '{key}' does not exist in the records.");
                }
            }
            else if (choice == "3")
            {
                if (records.Count == 0)
                {
                    Console.WriteLine("No records to display. The dictionary is empty.");
                }
                else
                {
                    Console.WriteLine("\n--- Current Records ---");
                    foreach (var entry in records)
                    {
                        Console.WriteLine($"{entry.Key} : {entry.Value}");
                    }
                    Console.WriteLine("-----------------------");
                }
            }
            else if (choice == "4")
            {
                Console.WriteLine("Thank you.");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
            }
        }
    }
}