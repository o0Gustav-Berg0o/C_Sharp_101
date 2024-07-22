using System;
using System.Text;
using System.Diagnostics;

class StringVsStringBuilderDemo
{
    static void Main()
    {
        const int iterationer = 200000;

        Console.WriteLine("Jämförelse mellan String och StringBuilder");
        Console.WriteLine("Antal iterationer: " + iterationer);
        Console.WriteLine();

        // Test med String
        GC.Collect(); // Tvinga skräpinsamling innan testet
        long stringMemoryBefore = GC.GetTotalMemory(true);
        long stringStartTime = Stopwatch.GetTimestamp();
        string stringResult = StringConcatenation(iterationer);
        long stringEndTime = Stopwatch.GetTimestamp();
        long stringMemoryAfter = GC.GetTotalMemory(false);

        // Test med StringBuilder
        GC.Collect(); // Tvinga skräpinsamling innan testet
        long sbMemoryBefore = GC.GetTotalMemory(true);
        long sbStartTime = Stopwatch.GetTimestamp();
        string sbResult = StringBuilderConcatenation(iterationer);
        long sbEndTime = Stopwatch.GetTimestamp();
        long sbMemoryAfter = GC.GetTotalMemory(false);

        // Beräkna och visa resultat
        double stringElapsed = (stringEndTime - stringStartTime) / (double)Stopwatch.Frequency * 1_000_000; // Mikrosekunder
        double sbElapsed = (sbEndTime - sbStartTime) / (double)Stopwatch.Frequency * 1_000_000; // Mikrosekunder
        long stringMemoryUsed = stringMemoryAfter - stringMemoryBefore;
        long sbMemoryUsed = sbMemoryAfter - sbMemoryBefore;

        Console.WriteLine("String:");
        Console.WriteLine($"Tid: {stringElapsed:F2} mikrosekunder");
        Console.WriteLine($"Minnesanvändning: {stringMemoryUsed:N0} bytes");
        Console.WriteLine($"Resultatets längd: {stringResult.Length}");
        Console.WriteLine();

        Console.WriteLine("StringBuilder:");
        Console.WriteLine($"Tid: {sbElapsed:F2} mikrosekunder");
        Console.WriteLine($"Minnesanvändning: {sbMemoryUsed:N0} bytes");
        Console.WriteLine($"Resultatets längd: {sbResult.Length}");
        Console.WriteLine();

        // Jämförelse
        double speedDifference = stringElapsed / sbElapsed;
        double memoryDifference = (double)stringMemoryUsed / sbMemoryUsed;
        Console.WriteLine($"StringBuilder är ca {speedDifference:F2} gånger snabbare än String i detta test.");
        Console.WriteLine($"String använder ca {memoryDifference:F2} gånger mer minne än StringBuilder i detta test.");
    }

    static string StringConcatenation(int iterations)
    {
        string result = "";
        for (int i = 0; i < iterations; i++)
        {
            result += "a";
        }
        return result;
    }

    static string StringBuilderConcatenation(int iterations)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < iterations; i++)
        {
            sb.Append("a");

        }
        return sb.ToString();
    }
}