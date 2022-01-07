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
            string userMessage = "Введите любую строку, программа распечатает ее наоборот";
            Console.WriteLine(userMessage);

            string inputString = Console.ReadLine();

            while (!UserInputIsValid(inputString))
            {
                Console.WriteLine("Неправильный ввод!");
                Console.WriteLine(userMessage);
                inputString = Console.ReadLine();
            }

            char[] inputArray = inputString.ToCharArray();

            string outputString = string.Empty;

            for (int i = inputArray.Length - 1; i >= 0; i--)
            {
                outputString += inputArray[i];
            }

            Console.WriteLine($"Перевернутая строка: {outputString}");

            Console.ReadKey();

        }
    }
}
