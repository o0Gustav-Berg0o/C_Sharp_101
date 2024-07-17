namespace Random
{
    using System;
    using System.Text;

    class Program
    {
        static int WIDTH = 20;
        static int HEIGHT = 10;
        static int playerX;
        static int playerY;
        static Random random = new Random();
        static StringBuilder buffer = new StringBuilder();

        static void Main(string[] args)
        {
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
