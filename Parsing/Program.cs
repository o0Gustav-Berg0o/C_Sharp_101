namespace Parsing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string numberString = "42";
            if (int.TryParse(numberString, out int number))
            {
                Console.WriteLine($"Parsed integer: {number}");
            }
            else
            {
                Console.WriteLine("Failed to parse integer");
            }

            string floatString = "3.14";
            if (float.TryParse(floatString, out float floatNumber))
            {
                Console.WriteLine($"Parsed float: {floatNumber}");
            }
            else
            {
                Console.WriteLine("Failed to parse float");
            }

            string dateString = "2024-07-02";
            if (DateTime.TryParse(dateString, out DateTime date))
            {
                Console.WriteLine($"Parsed date: {date.ToShortDateString()}");
            }
            else
            {
                Console.WriteLine("Failed to parse date");
            }

            string boolString = "true";
            if (bool.TryParse(boolString, out bool boolValue))
            {
                Console.WriteLine($"Parsed boolean: {boolValue}");
            }
            else
            {
                Console.WriteLine("Failed to parse boolean");
            }

            string csvString = "apple,banana,cherry";
            string[] fruits = csvString.Split(',');
            Console.WriteLine("Parsed fruits:");
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
        }
    }
}
