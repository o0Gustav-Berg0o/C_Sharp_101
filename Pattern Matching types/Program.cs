using System;

namespace PatternMatchingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object[] items = new object[]
            {
                42,                            // Konstant
                null,                          // Discard
                new Person("Alice", 30),       // Type, Declaration, Property
                new Person("Bob", 15),         // Relation
                (1, 2),                        // Positional
                new Person("Charlie", 25)      // Kombinera olika mönster
            };

            foreach (var item in items)
            {
                string result = item switch
                {
                    42 => "Konstant: Det är 42.",
                    null => "Discard: Det är null.",
                    Person { Age: >= 18 } => $"Relation: {((Person)item).Name} är vuxen.",
                    Person p => $"Declaration: Personens namn är {p.Name}.",
                    (int x, int y) => $"Positional: En tuple med värdena {x} och {y}.",
                    _ => "Unknown item"
                };

                Console.WriteLine(result);

                // Separat demonstration av Type och Property patterns
                if (item is Person { Age: var age, Name: var name })
                {
                    Console.WriteLine($"Property: Personen heter {name} och är {age} år gammal.");
                }
            }
        }
    }

    public class Person
    {
        public string Name { get; }
        public int Age { get; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
