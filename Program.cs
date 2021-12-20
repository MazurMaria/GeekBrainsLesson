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
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                Console.ReadLine();
            }
        }
    }
}
