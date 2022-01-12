using System;

namespace Lesson3_part2
{
    internal class Program
    {

        /// <summary>
        /// Повторение ввода пользователя
        /// </summary>
        /// <param name="inputString">введенная пользователем строка</param>
        /// <returns>верно введенное значение</returns>
        static string RepeatUserInput(string inputString)
        {
            while (!UserInputIsValid(inputString))
            {
                Console.WriteLine("Неверный ввод, повторите:");
                inputString = Console.ReadLine();
            }

            return inputString;
        }

        /// <summary>
        /// Проверка ввода пользователя
        /// </summary>
        /// <param name="inputString">введенная пользователем строка</param>
        /// <returns>true - если ввод верен, false если неверен</returns>
        static bool UserInputIsValid(string inputString)
        {
            bool result = !string.IsNullOrEmpty(inputString) && !string.IsNullOrWhiteSpace(inputString);

            return result;
        }

        /// <summary>
        /// Получить ввод пользователя
        /// </summary>
        /// <param name="inputString">сообщение для пользователя</param>
        /// <returns>введенную пользователем строку</returns>
        static string GetUserInput(string inputMessage)
        {
            Console.WriteLine(inputMessage);

            string result = Console.ReadLine();

            result = RepeatUserInput(result);

            return result;
        }

        /// <summary>
        /// Получить ввод пользователя
        /// </summary>
        /// <param name="inputString">сообщение для пользователя</param>
        /// <returns>введенную пользователем строку</returns>
        static string GetFullName(string familyName, string givenName, string patronymicName)
        {
            string result = familyName + " " + givenName + " " + patronymicName;

            return result;
        }

        static void Main(string[] args)
        {
            string familyName = GetUserInput("Введите фамилию:");

            string givenName = GetUserInput("Введите имя:");

            string patronymicName = GetUserInput("Введите отчество:");

            string outputLine = GetFullName(familyName, givenName, patronymicName);

            Console.WriteLine($"Полное имя: {outputLine}");

            Console.ReadKey();

        }
    }
}
