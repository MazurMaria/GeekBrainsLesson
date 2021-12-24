using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine($"Hello world! What's your name?");

                string useName = Console.ReadLine();

                Console.WriteLine($"Hello {useName}.");

                Console.WriteLine($"Enter your birth year");

                int birthYear = Convert.ToInt16(Console.ReadLine());

                int currentYear = DateTime.Now.Year;

                if (birthYear <= 0 || birthYear >= currentYear)
                {
                    Console.WriteLine($"Is a not correct year, sorry");
                }

                else
                {
                    int userAge = currentYear - birthYear;

                    Console.WriteLine($"{useName}, you age is {userAge} ;) ");
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            finally
            {
                Console.WriteLine($"Press any key to exit program");

                Console.ReadKey();
            }

        }
    }
}
