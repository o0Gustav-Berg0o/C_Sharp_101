namespace Static
{
    using System;

    public class Calculator
    {
        // Static member
        public static int StaticCount { get; private set; }

        // Instance member
        public int InstanceCount { get; private set; }

        // Static method
        public static int Add(int a, int b)
        {
            StaticCount++;
            return a + b;
        }

        // Instance method
        public int Multiply(int a, int b)
        {
            InstanceCount++;
            return a * b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Using static method and property
            Console.WriteLine($"5 + 3 = {Calculator.Add(5, 3)}");
            Console.WriteLine($"Static count: {Calculator.StaticCount}");

            // Creating instances of Calculator
            Calculator calc1 = new Calculator();
            Calculator calc2 = new Calculator();

            // Using instance methods
            Console.WriteLine($"4 * 6 = {calc1.Multiply(4, 6)}");
            Console.WriteLine($"2 * 8 = {calc2.Multiply(2, 8)}");

            // Showing instance counts
            Console.WriteLine($"calc1 instance count: {calc1.InstanceCount}");
            Console.WriteLine($"calc2 instance count: {calc2.InstanceCount}");

            // Using static method again
            Console.WriteLine($"10 + 7 = {Calculator.Add(10, 7)}");
            Console.WriteLine($"Final static count: {Calculator.StaticCount}");

            Console.ReadLine(); // Keep console window open
        }
    }
}
