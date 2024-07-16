namespace MemoryAllocationDemo
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // Value type on the stack
            int x = 5;
                      
            // Reference type on the heap
            string str = "Hello";


            // Another reference type
            Object obj = new Object();

            // Value type as a field in a reference type
            DateTime now = DateTime.Now;

            // Array on the heap
            int[] numbers = new int[3] { 1, 2, 3 };

            // Value type struct
            Point p = new Point(10, 20);

            // Call a method
            int result = AddNumbers(x, 10);

            Console.WriteLine($"x: {x}, str: {str}, result: {result}");
        }

        static int AddNumbers(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
    }

    struct Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}