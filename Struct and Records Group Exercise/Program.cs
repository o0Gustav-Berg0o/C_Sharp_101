using System;
using System.Collections.Generic;
using System.Reflection;

// Produkt-record
public record Product(string Name, string Category, decimal Price);

// Lagerplats-struct
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

// Huvudprogram
class Program
{
    static void Main(string[] args)
    {
       
        // Skapa en lista för att lagra produkter
        List<(Product Product, StorageLocation Location, int Quantity)> inventory = new()
        {
            (
                new Product("Dummy Product", "Test Category", 9.99m),
                new StorageLocation("A", 1, 1),
                10
            )
        };

        // Huvudmeny
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
        static void AddProduct(List<(Product, StorageLocation, int)> inventory)
        {
            string name = "";
            string category = "";
            decimal price = -0.1m;
            string section = "";
            int shelf = -1;
            int position = -1;
            int quantity = -1;

            while (name == "")
            {
                Console.WriteLine("Enter products name : ");

                name = Console.ReadLine();
            }
            while (category == "")
            {
                Console.WriteLine("Enter products category : ");

                category = Console.ReadLine();
            }
            while (price < 0)
            {
                Console.WriteLine("Enter products price : ");

                price = Convert.ToInt32(Console.ReadLine());
            }
            while (section == "")
            {
                Console.WriteLine("Enter products section : ");

                section = Console.ReadLine();
            }
            while (shelf < 0)
            {
                Console.WriteLine("Enter products shelf : ");

                shelf = Convert.ToInt32(Console.ReadLine());
            }
            while (position < 0)
            {
                Console.WriteLine("Enter products position : ");

                position = Convert.ToInt32(Console.ReadLine());
            }
            while (quantity < 0)
            {
                Console.WriteLine("Enter products quantity : ");

                quantity = Convert.ToInt32(Console.ReadLine());
            }
            inventory.Add((new Product(name, category, price), new StorageLocation(section, shelf, position), quantity));

        }
        static void DisplayInventory(List<(Product, StorageLocation, int)> inventory)
        {
            Console.WriteLine("Products List");
            Console.WriteLine(new string('-', Console.BufferWidth - 1));

            // Define column widths
            //Make dynamic 
            const int nameWidth = 15;
            const int categoryWidth = 15;
            const int priceWidth = 10;
            const int sectionWidth = 8;
            const int shelfWidth = 6;
            const int positionWidth = 9;
            const int quantityWidth = 9;

            // Print header
            Console.WriteLine($"| {"Name".PadRight(nameWidth)} | {"Category".PadRight(categoryWidth)} | {"Price".PadRight(priceWidth)} | {"Section".PadRight(sectionWidth)} | {"Shelf".PadRight(shelfWidth)} | {"Position".PadRight(positionWidth)} | {"Quantity".PadRight(quantityWidth)} |");
            Console.WriteLine(new string('-', Console.BufferWidth - 1));

            // Print each product
            foreach (var product in inventory)
            {
                Console.WriteLine(
                    $"| {product.Item1.Name.PadRight(nameWidth)} " +
                    $"| {product.Item1.Category.PadRight(categoryWidth)} " +
                    $"| {product.Item1.Price.ToString("C").PadRight(priceWidth)} " +
                    $"| {product.Item2.Section.PadRight(sectionWidth)} " +
                    $"| {product.Item2.Shelf.ToString().PadRight(shelfWidth)} " +
                    $"| {product.Item2.Position.ToString().PadRight(positionWidth)} " +
                    $"| {product.Item3.ToString().PadRight(quantityWidth)} |");
            }

            Console.WriteLine(new string('-', Console.BufferWidth - 1));
        }
        static void SearchProduct(List<(Product, StorageLocation, int)> inventory) 
        {
            //Search by name
            //Send list to print method with added header of search result
            Console.WriteLine("Enter name of product that you want to search for: ");
            string searchword = Console.ReadLine();
            List<(Product, StorageLocation, int)> resultFromSearch = new List<(Product, StorageLocation, int)> ();

            foreach (var product in inventory)
            {
                if (product.Item1.Name.Contains(searchword))
                {
                    resultFromSearch.Add(product);
                }
            }
            if (resultFromSearch.Count > 0)
            {
                Console.WriteLine("Search Result");
                DisplayInventory(resultFromSearch);
            }
            else
            {
                Console.WriteLine("No match");
            }
        }
        static void UpdateInventory(List<(Product, StorageLocation, int)> inventory) 
        {
            Console.WriteLine("Enter name of product that you want to update: ");
            string productNameToUpdate = Console.ReadLine(); // Add general search method to avoid repeting code
            var index = inventory.FindIndex(x => x.Item1.Name.Contains(productNameToUpdate, StringComparison.OrdinalIgnoreCase));
            var item = inventory[index];          
          
            Console.WriteLine("Enter new quantity : ");
            var updatedQuantity = int.Parse(Console.ReadLine());
            inventory[index] = (item.Item1, item.Item2, updatedQuantity);
          
            Console.ReadKey();
        }
    }
}