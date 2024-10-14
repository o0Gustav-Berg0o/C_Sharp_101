using System;
using System.Collections.Generic;
using System.Linq;

// Product record
public record Product(string Name, string Category, decimal Price);

// Storage location struct
public struct StorageLocation
{
    public string Section;
    public int Shelf;
    public int Position;

    public StorageLocation(string section, int shelf, int position)
    {
        Section = section;
        Shelf = shelf;
        Position = position;
    }

    public override string ToString() => $"{Section}-{Shelf}-{Position}";
}

// Main program
class Program
{
    static void Main(string[] args)
    {
        // Create a list to store products
        List<(Product Product, StorageLocation Location, int Quantity)> inventory = new();

        // Main menu
        while (true)
        {
            Console.WriteLine("\nVälj en åtgärd:");
            Console.WriteLine("1. Lägg till produkt");
            Console.WriteLine("2. Visa lager");
            Console.WriteLine("3. Sök produkt");
            Console.WriteLine("4. Uppdatera lager");
            Console.WriteLine("5. Avsluta");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    AddProduct(inventory);
                    break;
                case "2":
                    DisplayInventory(inventory);
                    break;
                case "3":
                    SearchProduct(inventory);
                    break;
                case "4":
                    UpdateInventory(inventory);
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Ogiltigt val. Försök igen.");
                    break;
            }
        }
    }

    // Implement these methods
    static void AddProduct(List<(Product, StorageLocation, int)> inventory) { }

    static void DisplayInventory(List<(Product, StorageLocation, int)> inventory) { }

    static void SearchProduct(List<(Product, StorageLocation, int)> inventory) { }

    static void UpdateInventory(List<(Product, StorageLocation, int)> inventory) { }
}
