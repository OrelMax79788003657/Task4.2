using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int positive = 0;
            int negative = 0;

            int userinput = 0;
            do
            {
                Console.Write("Введите число(0-конец): ");
                userinput = Convert.ToInt32(Console.ReadLine());

                if (userinput > 0)
                {
                    positive++;
                }
                else if (userinput < 0)
                {
                    negative++;
                }
            } while (userinput != 0);

            if (positive > negative)
            {
                Console.WriteLine("положительных больше");
            }
            else if (negative > positive)
            {
                Console.WriteLine("отрицательных больше");
            }
            else
            {
                Console.WriteLine("ничья");
            }
            Console.ReadKey();
        }
    }
}
