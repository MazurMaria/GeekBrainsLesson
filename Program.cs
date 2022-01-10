using System;

namespace Lesson3_part2
{
    internal class Program
    {

        /// <summary>
        /// Проверяет входящую строку (ввод пользователя)
        /// </summary>
        /// <param name="validatedString">Проверяемая строка</param>
        /// <returns>true - строка верна, или false - строка неверна</returns>
        static bool UserInputIsValid(string validatedString)
        {
            bool result = !string.IsNullOrEmpty(validatedString) && !string.IsNullOrWhiteSpace(validatedString);

            return result;
        }

        static void Main(string[] args)
        {
            string[,] seaBattle = new string[10, 10] {
             {"X","X","X","X","X","O","X","O","X","O" },
             {"X","O","X","O","X","X","X","O","X","O" },
             {"X","O","X","X","X","O","X","O","X","O" },
             {"X","O","X","O","X","O","X","O","X","O" },
             {"X","O","X","O","X","O","X","O","X","O" },
             {"X","X","X","O","X","O","X","O","X","O" },
             {"X","O","X","O","X","O","X","O","X","O" },
             {"X","O","X","O","X","X","X","O","X","O" },
             {"X","O","X","O","X","O","X","O","X","O" },
             {"X","O","X","O","X","O","X","O","X","O" }
            };

            Console.WriteLine("Морской бой");

            for (int i = 0; i < 10; i++)
            {
                string outputLine = string.Empty;

                for (int j = 0; j < 10; j++)
                {
                    outputLine += seaBattle[i, j];
                }

                Console.WriteLine(outputLine);
            }

            Console.ReadKey();

        }
    }
}
