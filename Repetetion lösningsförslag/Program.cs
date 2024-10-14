using static GeometryHelper;
using System.Diagnostics.Metrics;


using System;

class Program
{
    enum TraficLights
    {
        Green,
        Yellow,
        Red
    }
    static void Main(string[] args)
    {
        CheckTraficLights(TraficLights.Green);
        CheckTraficLights(TraficLights.Yellow);
        CheckTraficLights(TraficLights.Red);
        // 1. Counter
        Counter c1 = new Counter();
        Counter c2 = new Counter();
        Console.WriteLine($"Antal Counter-instanser: {Counter.InstanceCount}");

        // 2. MathHelper
        Console.WriteLine($"Kvadraten av 5 är: {MathHelper.Square(5)}");

        // 3. StringUtility
        Console.WriteLine(StringUtility.Greet("Alice"));

        // 4. GeometryHelper
        Console.WriteLine($"Area av en cirkel med radie 5: {GeometryHelper.CircleArea(5):F2}");
        Console.WriteLine($"Omkrets av en rektangel 3x4: {GeometryHelper.RectanglePerimeter(3, 4):F2}");

        // 5. CurrencyConverter
        Console.WriteLine($"100 USD till EUR: {CurrencyConverter.Convert(100, "USD", "EUR"):F2} EUR");

        // 6. DateHelper
        DateTime birthDate = new DateTime(1990, 5, 15);
        Console.WriteLine($"Ålder för någon född 1990-05-15: {DateHelper.CalculateAge(birthDate)}");
        Console.WriteLine($"Är 2024 ett skottår? {DateHelper.IsLeapYear(2024)}");

        // 7. PasswordGenerator
        Console.WriteLine($"Genererat lösenord: {PasswordGenerator.GeneratePassword(12)}");

        // 8. UnitConverter
        Console.WriteLine($"5 meter till fot: {UnitConverter.MetersToFeet(5):F2} fot");
        Console.WriteLine($"20°C till Fahrenheit: {UnitConverter.CelsiusToFahrenheit(20):F2}°F");
    }
    static void CheckTraficLights(TraficLights userLights)
    {
        if (userLights.HasFlag(userLights))
        {
            return;
        }

        if (userLights.HasFlag(TraficLights.Green))
        {
            Console.WriteLine("Ljuset är grönt. Kör");
        }
        if (userLights.HasFlag(TraficLights.Yellow))
        {
            Console.WriteLine("Ljuset är gult. Sakta ned");
        }
        if (userLights.HasFlag(TraficLights.Red))
        {
            Console.WriteLine("Ljuset är rött. Stanna!");
        }
    }
    public static int StringLength(string s)
    {
        int ne = 0;
        if (s is not null)
        {
            ne = s.Length;
        }
        return ne;
    }
    string?[] s = { null, "a", "b", "c" };
    public static int StringNull(string[] s)
    {

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] is not null)
            {
                return i;
            }
        }
        return 0;
    }
}
public class Counter
{
    private static int instanceCount = 0;

    public Counter()
    {
        instanceCount++;
    }

    public static int InstanceCount
    {
        get { return instanceCount; }
    }
}

public static class MathHelper
{
    public static int Square(int number)
    {
        return number * number;
    }
}

public static class StringUtility
{
    public static string Greet(string name)
    {
        return $"Hej, {name}!";
    }
}


public static class GeometryHelper
{
    public static double CircleArea(double radius)
    {
        return Math.PI * radius * radius;
    }

    public static double CircleCircumference(double radius)
    {
        return 2 * Math.PI * radius;
    }

    public static double RectangleArea(double length, double width)
    {
        return length * width;
    }

    public static double RectanglePerimeter(double length, double width)
    {
        return 2 * (length + width);
    }

    public static class CurrencyConverter
    {
        private static readonly Dictionary<string, double> exchangeRates = new Dictionary<string, double>
    {
        {"USD", 1.0},
        {"EUR", 0.85},
        {"GBP", 0.73},
        {"JPY", 110.14}
    };

        public static double Convert(double amount, string fromCurrency, string toCurrency)
        {
            if (!exchangeRates.ContainsKey(fromCurrency) || !exchangeRates.ContainsKey(toCurrency))
            {
                throw new ArgumentException("Invalid currency");
            }

            double usdAmount = amount / exchangeRates[fromCurrency];
            return usdAmount * exchangeRates[toCurrency];
        }
    }

    public static class DateHelper
    {
        public static int CalculateAge(DateTime birthDate)
        {
            var today = DateTime.Today;
            var age = today.Year - birthDate.Year;
            if (birthDate.Date > today.AddYears(-age)) age--;
            return age;
        }

        public static bool IsLeapYear(int year)
        {
            return DateTime.IsLeapYear(year);
        }
    }

    public static class PasswordGenerator
    {
        private static readonly Random random = new Random();

        public static string GeneratePassword(int length, bool includeUppercase = true, bool includeNumbers = true, bool includeSpecialChars = true)
        {
            const string lowercase = "abcdefghijklmnopqrstuvwxyz";
            const string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string numbers = "0123456789";
            const string specialChars = "!@#$%^&*()_+-=[]{}|;:,.<>?";

            string chars = lowercase;
            if (includeUppercase) chars += uppercase;
            if (includeNumbers) chars += numbers;
            if (includeSpecialChars) chars += specialChars;

            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

    }
    public static class UnitConverter
    {
        public static double MetersToFeet(double meters)
        {
            return meters * 3.28084;
        }

        public static double FeetToMeters(double feet)
        {
            return feet / 3.28084;
        }

        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        public static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
        static int GetStringLength(string input)
        {
            return input?.Length ?? 0;
        }

        // 2. Metod som returnerar första icke-null eller tom sträng
        static string GetFirstNonEmptyString(string?[] strings)
        {
            if (strings == null)
                return string.Empty;

            for (int i = 0; i < strings.Length; i++)
            {
                if (!string.IsNullOrEmpty(strings[i]))
                    return strings[i]!;
            }
            return string.Empty;
        }

        // 3. Person-klass och metod för att skriva ut information
        class Person
        {
            public string? Name { get; set; }
            public int? Age { get; set; }
        }

        static void PrintPersonInfo(Person? person)
        {
            if (person == null)
            {
                Console.WriteLine("Person är null");
                return;
            }
            Console.WriteLine($"Namn: {person.Name ?? "Okänt"}, Ålder: {person.Age?.ToString() ?? "Okänd"}");
        }

        // 4. Metod som summerar två int?, behandlar null som 0
        static int SumNullableInts(int? a, int? b)
        {
            return (a ?? 0) + (b ?? 0);
        }

        // 5. Metod som returnerar längden av en string? eller 0 om null
        static int GetNullableStringLength(string? input)
        {
            return input?.Length ?? 0;
        }

        // 6. Metod som summerar icke-null värden i en int?[]
        static int SumNonNullValues(int?[] numbers)
        {
            if (numbers == null)
                return 0;

            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i].HasValue)
                    sum += numbers[i].Value;
            }
            return sum;
        }

        // 7. Metod som returnerar den längsta av två string?, eller null om båda är null
        static string? GetLongestString(string? a, string? b)
        {
            if (a == null && b == null) return null;
            if (a == null) return b;
            if (b == null) return a;
            return a.Length >= b.Length ? a : b;
        }

        // 8. Metod som ersätter null-värden med 0 i en array
        static int[] ReplaceNullWithZero(string[] keys, int?[] values)
        {
            if (keys == null || values == null || keys.Length != values.Length)
            {
                throw new ArgumentException("Ogiltig indata");
            }

            int[] result = new int[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                result[i] = values[i] ?? 0;
            }
            return result;
        }

        // 9. Metod som returnerar namnet på den äldsta personen
        static string? GetOldestPersonName(Person[]? people)
        {
            if (people == null || people.Length == 0)
            {
                return null;
            }

            Person? oldestPerson = null;
            int maxAge = int.MinValue;

            for (int i = 0; i < people.Length; i++)
            {
                if (people[i]?.Age > maxAge)
                {
                    maxAge = people[i]!.Age ?? int.MinValue;
                    oldestPerson = people[i];
                }
            }

            return oldestPerson?.Name;
        }
    }
}