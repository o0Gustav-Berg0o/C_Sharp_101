using System.Diagnostics;
using System.Net.Http.Headers;
using System;

using System.Threading;
using System.Diagnostics.Metrics;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //For
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
            Console.WriteLine("4");
            Console.WriteLine("5");
            Console.WriteLine("6");
            Console.WriteLine("7");
            Console.WriteLine("8");
            Console.WriteLine("9");
            Console.WriteLine("10");

            //VS
            Console.WriteLine("++++++++++++++++++++");

         
            for (int i = 0; i < 10; i++)
            {
                
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + 1);
            }

            Console.WriteLine("++++++++++++++++++++");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 10; i > 0; i--) 
            {
                Console.WriteLine(i);
            }

            for (int i = 1; i < 10000; i *= 5)
            { 
                Console.WriteLine(i + "Bob");            
            }

            Console.WriteLine("++++++++++++++++++++");

            string[] fruits = { "apple", "pear", "orange", "grape" };

            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine(fruits[i]);
            }

            //While Loop : Condition checked before the loop body executes.

            bool stayInLoop = false;
            while (stayInLoop)
            {
                Console.WriteLine("Vill du avsluta loopen? Skriv då \"avsluta\" ");
                string input = Console.ReadLine();
                if (input == "avsluta")
                {
                    stayInLoop = false;
                    Console.WriteLine("Loopen avslutas");
                }
            }

            Console.WriteLine("++++++++++++++++++++");


            int tal = -1;
            Random slump = new Random();
            while (tal != 10)
            {
                char[] symboler = { '║', '╚', '╔', '═', '╝', '╗' };
                char slumpmässigSymbol = symboler[slump.Next(symboler.Length)];

                Console.Write(slumpmässigSymbol);
                tal++;
            }

            DateTime start = DateTime.Now;
            DateTime end = DateTime.Now.AddMicroseconds(1);

            //while (start < end)
            //{
            //    Console.Clear();
            //    Console.WriteLine(DateTime.Now);
            //    Thread.Sleep(1);
            //}

            bool passwordIsCorrect = false;
            string correctPassword = "1234";

            while (passwordIsCorrect is false)
            {
                Console.Clear();
                Console.WriteLine("Skriv in ditt lösenord");
                string inputedPassword = Console.ReadLine();
                if (correctPassword == inputedPassword)
                {
                    passwordIsCorrect = true;
                    Console.WriteLine("Correct");
                    Console.ReadKey();
                }
                else 
                {
                    Console.WriteLine("Wrong. Press any key to try again");
                    Console.ReadKey();

                }
            }

            /// Do-While Loop: Condition checked after the loop body executes.
            /// 
            Console.WriteLine(Math.PI.ToString("F48"));

            int choice = -1;
            do
            {
                Console.Write("MENY");
                Console.Write("+++++++++++");
                Console.Write("1 : Säg hej");
                Console.Write("2 : Säg katt");
                Console.WriteLine("3 : Avsluta");
                Console.Write("3 : Avsluta");



            }
            while (choice != 6); 

            //Foreach 

            List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            //Break

            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    break;
                }
                Console.WriteLine(i);
            }



            //Continue
                        
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (int number in numbers)
            {                
                if (number % 2 != 0)
                {
                    continue; // Hoppa till nästa iteration om talet är udda
                }

                Console.WriteLine($"Jämt nummer hittat: {number}");
            }
        }
    }
    
}

