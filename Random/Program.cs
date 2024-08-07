namespace Random
{
    using System;
    using System.Security.Cryptography;
    using System.Text;

    class Program
    {
        static int WIDTH = 20;
        static int HEIGHT = 10;
        static int playerX;
        static int playerY;
        static Random random = new Random();
        static StringBuilder buffer = new StringBuilder();

        static string GetDirectionString((int x, int y) direction) => direction switch
        {
            (0, 1) => "Upp",
            (0, -1) => "Ner",
            (1, 0) => "Höger",
            (-1, 0) => "Vänster",
            (1, 1) => "Upp-höger",
            (-1, 1) => "Upp-vänster",
            (1, -1) => "Ner-höger",
            (-1, -1) => "Ner-vänster",
            (0, 0) => "Ingen rörelse",
            _ => "Okänd riktning"
        };

        static void Main(string[] args)
        {
            int[]? ints = null;

            Console.SetCursorPosition(20,20);
            var pos = (10, 10); 

            var directions = new (int x, int y)[]
            {
            (0, 1),   // Upp
            (0, -1),  // Ner
            (1, 0),   // Höger
            (-1, 0),  // Vänster
            (1, 1),   // Upp-höger
            (-1, 1),  // Upp-vänster
            (1, -1),  // Ner-höger
            (-1, -1), // Ner-vänster
            (0, 0)    // Ingen rörelse
            };

            var randy = new Random();

            for (int i = 1; i < directions.Length ; i++)
            {
                Console.Clear();
                pos.Item1 += directions[i].x;
                pos.Item2 += directions[i].y;
                Console.SetCursorPosition(pos.Item1, pos.Item2);
               
                Console.Write(GetDirectionString(directions[i]));
                Console.Write(" X");
                Console.ReadLine();
            }


            
            var rndom = new Random();
            for (int i = 0; i < 10000; i++)
            {
                var length = 0;
                for (global::System.Int32 j = 0; j < rndom.Next(1, 11); j++)
                {
                    Console.Write("*");
                    length++;
                }
                Console.Beep(length * 200, 400);
                Console.WriteLine();

            }



            Console.CursorVisible = false;
            InitializePlayer();

            while (true)
            {
                DrawGame();
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true).Key;
                    if (key == ConsoleKey.Q)
                        break;
                    MovePlayer();
                }
                System.Threading.Thread.Sleep(100); // Small delay to reduce CPU usage
            }
        }

        static void InitializePlayer()
        {
            playerX = WIDTH / 2;
            playerY = HEIGHT / 2;
        }

        static void DrawGame()
        {
            buffer.Clear();
            for (int y = 0; y < HEIGHT; y++)
            {
                for (int x = 0; x < WIDTH; x++)
                {
                    if (x == playerX && y == playerY)
                        buffer.Append('@');
                    else
                        buffer.Append('.');
                }
                buffer.AppendLine();
            }
            buffer.AppendLine("\nPress any key to move randomly. Press 'Q' to quit.");

            Console.SetCursorPosition(0, 0);
            Console.Write(buffer.ToString());
        }

        static void MovePlayer()
        {
            int direction = random.Next(4);
            switch (direction)
            {
                case 0: // Up
                    if (playerY > 0) playerY--;
                    break;
                case 1: // Down
                    if (playerY < HEIGHT - 1) playerY++;
                    break;
                case 2: // Left
                    if (playerX > 0) playerX--;
                    break;
                case 3: // Right
                    if (playerX < WIDTH - 1) playerX++;
                    break;
            }
        }
    }
}
