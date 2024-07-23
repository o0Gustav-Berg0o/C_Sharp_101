using System;

namespace Pattern_Matching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object[] animals = new object[]
            {
                new Dog("Buddy", 5, "Golden Retriever"),
                new Cat("Whiskers", 3, true),
                new Bird("Tweety", 2, false),
                new Dog("Max", 7, "Bulldog")
            };

            Console.WriteLine("Using traditional method:");
            HandleAnimalsTraditional(animals);

            Console.WriteLine("\nUsing pattern matching method:");
            HandleAnimalsPatternMatching(animals);
        }

        static void HandleAnimalsTraditional(object[] animals)
        {
            foreach (var animal in animals)
            {
                if (animal is Dog)
                {
                    Dog dog = (Dog)animal;
                    if (dog.Breed == "Golden Retriever")
                    {
                        Console.WriteLine($"Golden Retriever named {dog.Name} is {dog.Age} years old.");
                    }
                    else
                    {
                        Console.WriteLine($"Dog named {dog.Name} is {dog.Age} years old and is a {dog.Breed}.");
                    }
                }
                else if (animal is Cat)
                {
                    Cat cat = (Cat)animal;
                    string indoorStatus = cat.IsIndoor ? "indoor" : "outdoor";
                    Console.WriteLine($"Cat named {cat.Name} is {cat.Age} years old and is an {indoorStatus} cat.");
                }
                else if (animal is Bird)
                {
                    Bird bird = (Bird)animal;
                    string canTalkStatus = bird.CanTalk ? "can talk" : "cannot talk";
                    Console.WriteLine($"Bird named {bird.Name} is {bird.Age} years old and {canTalkStatus}.");
                }
                else
                {
                    Console.WriteLine("Unknown animal");
                }
            }
        }

        static void HandleAnimalsPatternMatching(object[] animals)
        {
            foreach (var animal in animals)
            {
                string description = animal switch
                {
                    Dog { Breed: "Golden Retriever", Name: var name, Age: var age } =>
                        $"Golden Retriever named {name} is {age} years old.",
                    Dog { Name: var name, Age: var age, Breed: var breed } =>
                        $"Dog named {name} is {age} years old and is a {breed}.",
                    Cat { Name: var name, Age: var age, IsIndoor: var isIndoor } =>
                        $"Cat named {name} is {age} years old and is an {(isIndoor ? "indoor" : "outdoor")} cat.",
                    Bird { Name: var name, Age: var age, CanTalk: var canTalk } =>
                        $"Bird named {name} is {age} years old and {(canTalk ? "can talk" : "cannot talk")}.",
                    _ => "Unknown animal"
                };

                Console.WriteLine(description);
            }
        }
    }

    public abstract class Animal
    {
        public string Name { get; }
        public int Age { get; }

        protected Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    public class Dog : Animal
    {
        public string Breed { get; }

        public Dog(string name, int age, string breed) : base(name, age)
        {
            Breed = breed;
        }
    }

    public class Cat : Animal
    {
        public bool IsIndoor { get; }

        public Cat(string name, int age, bool isIndoor) : base(name, age)
        {
            IsIndoor = isIndoor;
        }
    }

    public class Bird : Animal
    {
        public bool CanTalk { get; }

        public Bird(string name, int age, bool canTalk) : base(name, age)
        {
            CanTalk = canTalk;
        }
    }
}
