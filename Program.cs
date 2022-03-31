using System;

namespace dle_InteractiveMap
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] map = { {'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X'},
                            {'X', ' ', ' ', ' ', ' ', 'F', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'X'},
                            {'X', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'X'},
                            {'X', ' ', ' ', 'F', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'X'},
                            {'X', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'F', ' ', ' ', ' ', 'X'},
                            {'X', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'X'},
                            {'X', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'X'},
                            {'X', ' ', ' ', ' ', ' ', 'F', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'F', 'X'},
                            {'X', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'X'},
                            {'X', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'X'},
                            {'X', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'X'},
                            {'X', ' ', 'F', ' ', ' ', ' ', ' ', ' ', ' ', 'F', ' ', ' ', ' ', ' ', 'X'},
                            {'X', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'X'},
                            {'X', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'X'},
                            {'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X'} };

            int playerX = 0, playerY = 0;
            Random rng = new Random();

            playerX = rng.Next(1, 14);
            playerY = rng.Next(1, 14);

            static char[,] mapAltercation(int coordX, int coordY, char[,] map)
            {
                Console.Clear();

                map[coordY, coordX] = 'O';

                for (int y = 0; y < 15; y++)
                {
                    for (int x = 0; x < 15; x++)
                    {
                        Console.Write(map[y, x]);
                    }
                    Console.WriteLine();
                }

                return map;
            }

            while (map[7, 5] != 'O')
            {
                map = mapAltercation(playerX, playerY, map);
                mapAltercation(playerX, playerY, map);

                if (Console.ReadKey(true).Key == ConsoleKey.UpArrow)
                {
                    map[playerY, playerX] = ' ';
                    playerY--;
                }

                if (Console.ReadKey(true).Key == ConsoleKey.DownArrow)
                {
                    map[playerY, playerX] = ' ';
                    playerY++;
                }

                if (Console.ReadKey(true).Key == ConsoleKey.LeftArrow)
                {
                    map[playerY, playerX] = ' ';
                    playerX--;
                }

                if (Console.ReadKey(true).Key == ConsoleKey.RightArrow)
                {
                    map[playerY, playerX] = ' ';
                    playerX++;
                }
            }
        }
    }
}
