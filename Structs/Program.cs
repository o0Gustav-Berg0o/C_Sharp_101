using System;

// Definiera en struct för att representera en 2D-punkt
struct PointStruct
{
    public int X;
    public int Y;

    // Konstruktor för struct
    public PointStruct(int x, int y)
    {
        X = x;
        Y = y;
    }

    // Metod för att beräkna avståndet från origo
    public double DistanceFromOrigin()
    {
        return Math.Sqrt(X * X + Y * Y);
    }
}

// Definiera en motsvarande klass för jämförelse
class PointClass
{
    public int X;
    public int Y;

    // Konstruktor för klass
    public PointClass(int x, int y)
    {
        X = x;
        Y = y;
    }

    // Samma metod som i structen
    public double DistanceFromOrigin()
    {
        return Math.Sqrt(X * X + Y * Y);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Demonstration av structs vs klasser i C#");

        // Skapa instanser av både struct och klass
        PointStruct ps = new PointStruct(3, 4);
        PointClass pc = new PointClass(3, 4);

        Console.WriteLine("1. Grundläggande användning:");
        Console.WriteLine($"PointStruct: X = {ps.X}, Y = {ps.Y}");
        Console.WriteLine($"PointClass: X = {pc.X}, Y = {pc.Y}");

        // Demonstrera värdetyp vs referenstyp beteende
        Console.WriteLine("\n2. Värdetyp vs Referenstyp:");
        PointStruct ps2 = ps;
        PointClass pc2 = pc;

        ps2.X = 10;
        pc2.X = 10;

        Console.WriteLine($"Original PointStruct: X = {ps.X}"); // Oförändrad
        Console.WriteLine($"Original PointClass: X = {pc.X}");  // Ändrad

        // Demonstrera beteende som metodparametrar
        Console.WriteLine("\n3. Som metodparametrar:");
        ModifyPoint(ps, pc);
        Console.WriteLine($"PointStruct efter ModifyPoint: X = {ps.X}"); // Oförändrad
        Console.WriteLine($"PointClass efter ModifyPoint: X = {pc.X}");  // Ändrad

        // Visa defaultvärden
        Console.WriteLine("\n4. Defaultvärden:");
        PointStruct defaultStruct = default(PointStruct);
        PointClass defaultClass = default(PointClass);
        Console.WriteLine($"Default PointStruct: X = {defaultStruct.X}, Y = {defaultStruct.Y}");
        Console.WriteLine($"Default PointClass: {(defaultClass == null ? "null" : "not null")}");

        // Demonstrera prestanda (enkel illustration)
        Console.WriteLine("\n5. Prestanda (enkel illustration):");
        int iterations = 10_000_000;

        var startTimeStruct = DateTime.Now;
        for (int i = 0; i < iterations; i++)
        {
            PointStruct tempPs = new PointStruct(i, i);
        }
        var endTimeStruct = DateTime.Now;

        var startTimeClass = DateTime.Now;
        for (int i = 0; i < iterations; i++)
        {
            PointClass tempPc = new PointClass(i, i);
        }
        var endTimeClass = DateTime.Now;

        Console.WriteLine($"Tid för struct: {(endTimeStruct - startTimeStruct).TotalMilliseconds} ms");
        Console.WriteLine($"Tid för class: {(endTimeClass - startTimeClass).TotalMilliseconds} ms");

        Console.ReadLine(); // Håll konsolen öppen
    }

    // Metod som tar både struct och klass som parametrar
    static void ModifyPoint(PointStruct ps, PointClass pc)
    {
        ps.X = 100; // Detta påverkar endast den lokala kopian av structen
        pc.X = 100; // Detta påverkar den ursprungliga klassinstansen
    }
}