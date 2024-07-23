using System;
using System.Diagnostics;

namespace Pattern_Matching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Switch();
            //Konstant();
            //Typ();
            //Variable();
            Console.ReadLine();
            object[] shapes = new object[]
            {
                new Circle(5),
                new Rectangle(4, 6),
                new Triangle(3, 4),
                new Circle(10)
            };

            Console.WriteLine("Using traditional method:");
            HandleShapesTraditional(shapes);

            Console.WriteLine("\nUsing pattern matching method:");
            HandleShapesPatternMatching(shapes);
        }

        static void HandleShapesTraditional(object[] shapes)
        {
            foreach (var shape in shapes)
            {
                if (shape is Circle)
                {
                    Circle circle = (Circle)shape;
                    double area = Math.PI * circle.Radius * circle.Radius;
                    Console.WriteLine($"Circle with radius {circle.Radius} has an area of {area}");
                }
                else if (shape is Rectangle)
                {
                    Rectangle rectangle = (Rectangle)shape;
                    double area = rectangle.Width * rectangle.Height;
                    Console.WriteLine($"Rectangle with width {rectangle.Width} and height {rectangle.Height} has an area of {area}");
                }
                else if (shape is Triangle)
                {
                    Triangle triangle = (Triangle)shape;
                    double area = 0.5 * triangle.Base * triangle.Height;
                    Console.WriteLine($"Triangle with base {triangle.Base} and height {triangle.Height} has an area of {area}");
                }
                else
                {
                    Console.WriteLine("Unknown shape");
                }
            }
        }

        static void HandleShapesPatternMatching(object[] shapes)
        {
            foreach (var shape in shapes)
            {
                string description = shape switch
                {
                    Circle { Radius: var r } => $"Circle with radius {r} has an area of {Math.PI * r * r}",
                    Rectangle { Width: var w, Height: var h } => $"Rectangle with width {w} and height {h} has an area of {w * h}",
                    Triangle { Base: var b, Height: var h } => $"Triangle with base {b} and height {h} has an area of {0.5 * b * h}",
                    _ => "Unknown shape"
                };

                Console.WriteLine(description);
            }
        }
        static void Konstant() 
        {
            Object obj = 42;

            if (obj is 42)
            {
                Console.WriteLine(obj);
            }
            else
            {
                Console.WriteLine("Objektet har ej värdet 42");
            }
        }

        static void Typ()
        {
            Object obj = new Circle(42);

            if (obj is Circle c)
            {
                Console.WriteLine(obj);
            }
            else
            {
                Console.WriteLine("Objektet är ej av typen Circle");
            }
        }

        static void Variable()
        {
            Object obj = new Circle(42.2);

            if (obj is Circle c)
            {
                Console.WriteLine(c.Radius);
            }
            else
            {
                Console.WriteLine("Objektet är ej av typen Circle");
            }
        }
        static void Egenskap()
        {
            object obj = new Person { Name = "Alice", Age = 30 };

            if (obj is Person { Age: var age, Name: var name })
            {
                Console.WriteLine($"The person's name is {name} and they are {age} years old.");
            }
            else
            {
                Console.WriteLine("The object is not a Person or does not have the expected properties.");
            }
        }

        static void Switch()
        {
            Person person = new Person { Name = "Alice", Age = 18 };
            string alice = GetCategory(person); 
            Console.WriteLine(alice);
        }
        static string GetCategory(Person person) => person switch
        {
            { Age: < 18 } => "Ungdom",
            { Age: >= 18 and < 65 } => "Vuxen",
            { Age: >= 65 } => "Senior",
            _ => "Okänd kategori"
        };

    }
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public abstract class Shape { }

    public class Circle : Shape
    {
        public double Radius { get; }
        public Circle(double radius) => Radius = radius;
    }

    public class Rectangle : Shape
    {
        public double Width { get; }
        public double Height { get; }
        public Rectangle(double width, double height) => (Width, Height) = (width, height);
    }

    public class Triangle : Shape
    {
        public double Base { get; }
        public double Height { get; }
        public Triangle(double @base, double height) => (Base, Height) = (@base, height);
    }
}
