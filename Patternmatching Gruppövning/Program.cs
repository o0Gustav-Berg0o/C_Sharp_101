using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Välkommen till Skogens Hemlighet!");
        PlayGame();
    }

    static void PlayGame()
    {
        var player = new Player { Name = "Äventyraren", Health = 100, Gold = 0 };
        var currentLocation = Location.Forest;

        while (true)
        {
            Console.WriteLine($"\nDu är i {GetLocationName(currentLocation)}.");
            Console.WriteLine($"Hälsa: {player.Health}, Guld: {player.Gold}");
            Console.WriteLine("Vad vill du göra? (Utforska/Vila/Inventory/Avsluta)");

            var action = Console.ReadLine().ToLower();
            switch (action)
            {
                case "utforska":
                    ExploreLocation(currentLocation, player);
                    break;
                case "vila":
                    RestPlayer(player);
                    break;
                case "inventory":
                    ShowInventory(player);
                    break;
                case "avsluta":
                    Console.WriteLine("Tack för att du spelade!");
                    return;
                default:
                    Console.WriteLine("Ogiltig handling. Försök igen.");
                    break;
            }

            if (player.Health <= 0)
            {
                Console.WriteLine("Game Over! Du har förlorat all din hälsa.");
                return;
            }
        }
    }

    static void ExploreLocation(Location location, Player player)
    {
        var (description, result) = location switch
        {
            Location.Forest => ("Du utforskar den täta skogen.", EncounterEvent()),
            Location.Cave => ("Du vågar dig in i den mörka grottan.", EncounterEvent()),
            Location.River => ("Du följer den slingrande floden.", EncounterEvent()),
            _ => ("Du befinner dig på en okänd plats.", (0, 0))
        };

        Console.WriteLine(description);
        player.Health += result.Item1;  // Använd Item1 istället för healthChange
        player.Gold += result.Item2;    // Använd Item2 istället för goldChange
        Console.WriteLine($"Hälsoförändring: {result.Item1}, Guldförändring: {result.Item2}");
    }

    static (int healthChange, int goldChange) EncounterEvent() =>
        new Random().Next(3) switch
        {
            0 => (-10, 5),  // Strid med monster
            1 => (0, 10),   // Hittade en skatt
            _ => (5, 0)     // Vilsam plats
        };

    static void RestPlayer(Player player) =>
        player.Health = Math.Min(100, player.Health + 20);

    static void ShowInventory(Player player) =>
        Console.WriteLine($"Inventory: Hälsa: {player.Health}, Guld: {player.Gold}");

    static string GetLocationName(Location location) => location switch
    {
        Location.Forest => "Skogen",
        Location.Cave => "Grottan",
        Location.River => "Floden",
        _ => "Okänd plats"
    };
}

class Player
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Gold { get; set; }
}

enum Location
{
    Forest,
    Cave,
    River
}