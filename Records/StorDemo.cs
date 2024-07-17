using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Demonstrering av skillnader mellan Records och Klasser");

        // 1. Deklaration och initialisering
        Console.WriteLine("\n1. Deklaration och initialisering:");
        var person1 = new PersonRecord("John Doe", 30);
        var person2 = new PersonClass("John Doe", 30);
        Console.WriteLine($"Record: {person1}");
        Console.WriteLine($"Klass: {person2}");

        // 2. Värdesemantik vs Referenssemantik
        Console.WriteLine("\n2. Värdesemantik vs Referenssemantik:");
        var person3 = person1 with { Age = 31 };
        var person4 = person2;
        person4.Age = 31; // Värdet Age i person4 och person2 pekar på samma ställe i minnet
        Console.WriteLine($"Original Record: {person1}");
        Console.WriteLine($"Modifierad Record: {person3}");
        Console.WriteLine($"Original Klass: {person2}");
        Console.WriteLine($"Modifierad Klass: {person4}");

        // 3. Jämförelse
        Console.WriteLine("\n3. Jämförelse:");
        var person5 = new PersonRecord("John Doe", 30);
        var person6 = new PersonClass("John Doe", 30);
        Console.WriteLine($"Records lika: {person1.Equals(person5)}");
        Console.WriteLine($"Klasser lika: {person2.Equals(person6)}");

        // 4. Dekonstruktion
        Console.WriteLine("\n4. Dekonstruktion:");
        var (name, age) = person1;
        Console.WriteLine($"Dekonstruerad Record: Namn = {name}, Ålder = {age}");

        // 5. Med-uttryck
        Console.WriteLine("\n5. Med-uttryck:");
        var updatedPerson = person1 with { Name = "Jane Doe" };
        Console.WriteLine($"Uppdaterad Record: {updatedPerson}");

        // 6. Arv
        Console.WriteLine("\n6. Arv:");
        var employee1 = new EmployeeRecord("Alice", 28, "IT");
        var employee2 = new EmployeeClass("Bob", 35, "HR");
        Console.WriteLine($"Employee Record: {employee1}");
        Console.WriteLine($"Employee Klass: {employee2}");
    }
}

// Record definition
public record PersonRecord(string Name, int Age);

// Motsvarande klass definition
public class PersonClass
{
    public string Name { get; set; }
    public int Age { get; set; }

    public PersonClass(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public override string ToString()
    {
        return $"PersonClass {{ Name = {Name}, Age = {Age} }}";
    }
}

// Arv med records
public record EmployeeRecord(string Name, int Age, string Department) : PersonRecord(Name, Age);

// Arv med klasser
public class EmployeeClass : PersonClass
{
    public string Department { get; set; }

    public EmployeeClass(string name, int age, string department) : base(name, age)
    {
        Department = department;
    }

    public override string ToString()
    {
        return $"EmployeeClass {{ Name = {Name}, Age = {Age}, Department = {Department} }}";
    }
}