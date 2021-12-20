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

                Console.WriteLine($"Enter your birthday date (please use dd.mm.yyyy format)");

                DateTime birthdayDate = Convert.ToDateTime(Console.ReadLine());

                DateTime currenDate = DateTime.Now;

                TimeSpan datesDiff = currenDate - birthdayDate;

                int userAge = Convert.ToInt16(datesDiff.TotalDays / 365);

                Console.WriteLine($"Congratulatinos {useName}, you age is {userAge} ;) ");

                Console.WriteLine($"Press any key to exit program");

                Console.ReadKey();
          }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                Console.WriteLine($"Press any key to exit program");

                Console.ReadKey();
            }
        }
    }
}
