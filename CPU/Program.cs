using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Value type - stored on the stack
        int age = 30;

        // Reference type - reference stored on stack, object on heap
        string name = "Alice";

        // Create an instance of a class - reference on stack, object on heap
        Person person = new Person("Bob", 25);

        // Array - reference on stack, array object and its elements on heap
        int[] numbers = new int[] { 1, 2, 3, 4, 5 };

        // List - reference on stack, List object and its elements on heap
        List<string> fruits = new List<string> { "Apple", "Banana", "Cherry" };

        // Call a method - creates a new stack frame
        PrintInfo(person);

        // Local variable in a block - stored on stack, deleted when block ends
        {
            int temp = 100;
            Console.WriteLine(temp);
        } // temp is no longer accessible here

        // Value type as a parameter - copied to the method's stack frame
        ModifyValue(age);
        Console.WriteLine($"Age after ModifyValue: {age}"); // Still 30

        // Reference type as a parameter - reference copied, same object affected
        ModifyReference(person);
        Console.WriteLine($"Person's age after ModifyReference: {person.Age}"); // Changed to 26
    }

    static void PrintInfo(Person p)
    {
        // p is a reference on this method's stack frame, pointing to the same object as 'person' in Main
        Console.WriteLine($"Name: {p.Name}, Age: {p.Age}");

        // Local variable - stored on this method's stack frame
        int yearOfBirth = 2023 - p.Age;

        // When this method ends, its stack frame (including yearOfBirth and p) is removed
    }

    static void ModifyValue(int x)
    {
        // x is a copy of 'age', stored on this method's stack frame
        x = 40; // This change doesn't affect the original 'age' in Main
    }

    static void ModifyReference(Person p)
    {
        // p is a copy of the reference, pointing to the same object as 'person' in Main
        p.Age = 26; // This modifies the actual object on the heap
    }
}

class Person
{
    // These are instance fields - stored in the object on the heap
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

