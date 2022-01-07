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
            bool result =  !string.IsNullOrEmpty(validatedString)  && !string.IsNullOrWhiteSpace(validatedString);
            
            return result;
        }

        static void Main(string[] args)
        {
            string[,] array2D = new string[5, 2];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    int userNumber = i + 1;

                    string userMessage;

                    if (j == 0)
                    {
                        userMessage = $"Введите имя {userNumber}-го пользователя:";
                    }
                    else
                    {
                        userMessage = $"Введите телефон/email {userNumber}-го пользователя:";
                    }

                    Console.WriteLine(userMessage);

                    array2D[i, j] = Console.ReadLine();

                    while(!UserInputIsValid(array2D[i, j]))
                    {
                        Console.WriteLine("Неправильный ввод!");
                        Console.WriteLine(userMessage);
                        array2D[i, j] = Console.ReadLine();
                    }
                }
            }

            Console.WriteLine("____________________________________");
            Console.WriteLine("Ваш справочник:");

            for (int i = 0; i < 5; i++)
            {
                string outputString = "";

                for (int j = 0; j < 2; j++)
                {
                    int userNumber = i + 1;

                    if (j == 0)
                    {
                        outputString = $"Пользователь {userNumber}:" + array2D[i, j] + ", ";
                    }
                    else
                    {
                        outputString += array2D[i, j];
                    }
                }

                Console.WriteLine(outputString);
            }

            Console.ReadKey();
        }
    }
}
