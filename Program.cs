using System;

namespace Lesson3_partt1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array2D = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

            string space = "";

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(space + array2D[i, j]);
                    space += " ";
                }
            }

            Console.ReadKey();
        }
    }
}
