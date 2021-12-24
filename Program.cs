using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    internal class Program
    {
        // Запросить у пользователя минимальную и максимальную температуру за сутки и вывести среднесуточную температуру.

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine($"Введите первое значение температуры:");

                int firstTemp = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine($"Введите второе значение температуры:");

                int secondTemp = Convert.ToInt16(Console.ReadLine());

                int averageTemp = (firstTemp + secondTemp) / 2;

                Console.WriteLine($"Введите номер месяца:");

                int monthNumber = Convert.ToInt16(Console.ReadLine());

                bool isWinter = false;

                string resultMessage = $"Средняя температура {averageTemp}. ";

                switch (monthNumber)
                {
                    case 1:
                        resultMessage += "Месяц: Январь. ";
                        isWinter = true;
                        break;
                    case 2:
                        resultMessage += "Месяц: Февраль. ";
                        isWinter = true;
                        break;
                    case 3:
                        resultMessage += "Месяц: Март. ";
                        break;
                    case 4:
                        resultMessage += "Месяц: Апрель. ";
                        break;
                    case 5:
                        resultMessage += "Месяц: Май. ";
                        break;
                    case 6:
                        resultMessage += "Месяц: Июнь. ";
                        break;
                    case 7:
                        resultMessage += "Месяц: Июль. ";
                        break;
                    case 8:
                        resultMessage += "Месяц: Август. ";
                        break;
                    case 9:
                        resultMessage += "Месяц: Сентябрь. ";
                        break;
                    case 10:
                        resultMessage += "Месяц: Октябрь. ";
                        break;
                    case 11:
                        resultMessage += "Месяц: Ноябрь. ";
                        break;
                    case 12:
                        resultMessage += "Месяц: Декабрь. ";
                        isWinter = true;
                        break;
                    default:
                        resultMessage += "Некорректно введен номер месяца. ";
                        break;
                }

                if (averageTemp > 0 && isWinter)
                {
                    resultMessage += "Дождливая зима...";

                }

                Console.WriteLine(resultMessage);

            }
            
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            finally
            {
                Console.WriteLine($"Нажмите любою клавишу и Enter для выхода из программы");

                Console.ReadKey();
            }

        }
    }
}
