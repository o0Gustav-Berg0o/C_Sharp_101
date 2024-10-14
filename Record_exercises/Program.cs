namespace Record_exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Bob", "Hope", 12);

            Console.WriteLine(person1.FirstName);

            var olderPerson = person1 with { Age = 122 };

            Console.WriteLine(olderPerson.Age);

            Book book = new Book("Enders Game", "Orson Scot Card");

            Console.WriteLine(book);

            Point point = new Point(2222, 5);
            var (x, y) = point;

            Console.WriteLine(x);

            var students = new List<Student>
            {
                new("Alice", 20),
                new("Bob", 22),
                new("Charlie", 19)
            };
            var olderStudents = students.Where(s => s.Age > 20).ToList();
            Console.WriteLine();

        }
        public record Person(string FirstName, string LastName, int Age);

        public record Book(string Title, string Author)
        {
            public override string ToString() => $"{Title} by {Author}";
        }

        public record Point(int X, int Y);

        public abstract record Shape;
        public record Circle(double Radius) : Shape;
        public record Rectangle(double Width, double Height) : Shape;

        public record Car
        {
            public string Model { get; init; }
            public int Year { get; init; }
        }

        public record Student(string Name, int Age);
    }
}