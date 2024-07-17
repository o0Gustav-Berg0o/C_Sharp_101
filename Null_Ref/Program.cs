using System;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main(string[] args)
    {

        
        Console.WriteLine();

        Person per = new Person();



        string userInput = Console.ReadLine();

        if (userInput == null)
        {
            //Gör något
        }

        if (userInput is null)
        {
            //Gör något
        }

        string name = userInput ?? "Inget namn inmatat av användaren";

        name ??= "Inget namn inmatat av användaren";



        string response = null;

        Console.WriteLine(response);

        Person person = null;

        //Kommer att kasta undantag
        Console.WriteLine(person.Name);

        if (person != null)
        {
            //Kommer INTE att kasta undantag
            Console.WriteLine(person.Name);
        }

        // Using the null-conditional operator (?.) for safe member access
        Console.WriteLine(person?.Name); // Outputs nothing, doesn't throw an exception

        // Using the null coalescing operator (??) to provide a default value
        string name2 = person?.Name ?? "Unknown";
        Console.WriteLine($"Name: {name}"); // Outputs: Name: Unknown

        // Nullable value types
        int? nullableInt = null;
        Console.WriteLine($"Nullable int: {nullableInt}"); // Outputs: Nullable int: 

        // Using null coalescing operator with nullable value types
        int definiteInt = nullableInt ?? 0;
        Console.WriteLine($"Definite int: {definiteInt}"); // Outputs: Definite int: 0

        // Null-forgiving operator (!) - use with caution!
        // This tells the compiler that we're certain 'person' is not null
        // Person notNullPerson = person!; // Uncomment to see how it suppresses warnings

        // Demonstrating null reference in a method
        PrintPersonInfo(null);

        // Creating a non-null Person object
        Person john = new Person { Name = "John", Age = 30 };
        PrintPersonInfo(john);
    }

    static void PrintPersonInfo(Person person)
    {
        // Using null-conditional operator in combination with null-coalescing operator
        Console.WriteLine($"Name: {person?.Name ?? "Unknown"}, Age: {person?.Age.ToString() ?? "Unknown"}");
    }
}