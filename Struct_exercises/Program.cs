namespace Struct_exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Point point = new Point(2, 2);
            Console.WriteLine(point.X);

            Color color = new Color(12, 255, 11);
            Console.WriteLine(color.Red + " " + color.Green + " " + color.Blue);

            Date date = new Date(2024, 10, 8);
            Console.WriteLine($"Date: {date.Year}-{date.Month}-{date.Day}");

            Rectangle rectangle = new Rectangle(12, 20);

            for (int y = 0; y < rectangle.Height; y++)
            {
                for (int x = 0; x < rectangle.Width; x++)
                {
                    if (y == 0 || y == rectangle.Height - 1 || x == 0 || x == rectangle.Width - 1)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }



        }
        public struct Point
        {
            public int X { get; set; }
            public int Y { get; set; }

            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }
        }

        public struct Color
        {
            public byte Red { get; set; }
            public byte Green { get; set; }
            public byte Blue { get; set; }

            public Color(byte red, byte green, byte blue)
            {
                Red = red;
                Green = green;
                Blue = blue;
            }
        }

        public struct Date
        {
            public short Year { get; set; }
            public byte Month { get; set; }
            public byte Day { get; set; }

            public Date(short year, byte month, byte day)
            {
                Year = year;
                Month = month;
                Day = day;
            }
        }

        public struct Rectangle
        {
            public double Width { get; set; }
            public double Height { get; set; }

            public Rectangle(double width, double height)
            {
                Width = width;
                Height = height;
            }
        }
        public struct Circle
        {
            public double Radius { get; }

            public Circle(double radius)
            {
                if (radius < 0)
                    throw new ArgumentException("Radius kan inte vara negativ.", nameof(radius));

                Radius = radius;
            }

            public double CalculateArea()
            {
                return Math.PI * Radius * Radius;
            }

            public double CalculateCircumference()
            {
                return 2 * Math.PI * Radius;
            }

        }
    }
}
