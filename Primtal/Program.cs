using System;

class PrimeNumberFinder
{
    /// <summary>
    /// Kontrollerar om ett givet tal är ett primtal.
    /// </summary>
    /// <param name="number">Talet som ska kontrolleras</param>
    /// <returns>true om talet är ett primtal, annars false</returns>
    public static bool IsPrime(int number)
    {
        // Tal mindre än eller lika med 1 är inte primtal
        if (number <= 1)
            return false;

        // 2 är det enda jämna primtalet
        if (number == 2)
            return true;

        // Jämna tal större än 2 är inte primtal
        if (number % 2 == 0)
            return false;

        // Kontrollera udda tal upp till roten av number
        for (int i = 3; i <= Math.Sqrt(number); i += 2)
        {
            // Om number är delbart med något tal, är det inte ett primtal
            if (number % i == 0)
                return false;
        }

        // Om vi når hit är talet ett primtal
        return true;
    }

    /// <summary>
    /// Hittar nästa primtal som är större än eller lika med det givna talet.
    /// </summary>
    /// <param name="number">Utgångstalet</param>
    /// <returns>Nästa primtal</returns>
    public static int FindNextPrime(int number)
    {
        // Om talet är mindre än eller lika med 1, är nästa primtal 2
        if (number <= 1)
            return 2;

        int nextNumber = number;
        while (true)
        {
            // Kontrollera om det nuvarande talet är ett primtal
            if (IsPrime(nextNumber))
                return nextNumber;

            // Om inte, öka talet och fortsätt söka
            nextNumber++;
        }
    }

    public static void Main(string[] args)
    {
        Console.Write("Ange ett tal: ");

        // Försök att konvertera användarens inmatning till ett heltal
        if (int.TryParse(Console.ReadLine(), out int inputNumber))
        {
            // Hitta nästa primtal
            int nextPrime = FindNextPrime(inputNumber);

            // Skriv ut resultatet
            Console.WriteLine($"Närmaste primtal efter {inputNumber} är {nextPrime}");
        }
        else
        {
            // Felmeddelande om inmatningen inte är ett giltigt heltal
            Console.WriteLine("Ogiltig inmatning. Vänligen ange ett heltal.");
        }
    }
}