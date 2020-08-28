using System;

namespace PathCounter
{
    class Program
    {
        /*************************************
         * Дано: поле N x M, передвигаться можно только вправо и вниз
         * Найти: количество всех возможный путей
         *************************************/
        static void Main(string[] args)
        {
            Console.WriteLine($"3 x 2 = {Calculate(3, 2)}");
            Console.WriteLine($"4 x 4 = {Calculate(4, 4)}");
            Console.WriteLine($"3 x 6 = {Calculate(3, 6)}");
            Console.WriteLine($"6 x 3 = {Calculate(6, 3)}");
            Console.WriteLine($"5 x 5 = {Calculate(5, 5)}");
            Console.WriteLine($"7 x 7 = {Calculate(7, 7)}");
            Console.ReadKey();
        }

        private static int Calculate(int width, int height)
        {
            var map = new int[width, height];
            InitMap(map);

            for (int i = 1; i < width; i++)
                for (int j = 1; j < height; j++)
                    map[i, j] = map[i - 1, j] + map[i, j - 1];

            return map[width - 1, height - 1];
        }

        private static void InitMap(int[,] map)
        {
            for (int i = 0; i < map.GetLength(0); i++)
                map[i, 0] = 1;

            for (int i = 0; i < map.GetLength(1); i++)
                map[0, i] = 1;

        }
    }
}
