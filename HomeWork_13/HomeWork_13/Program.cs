using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int num = int.Parse(Console.ReadLine());

            if ((num / 100 > 0) && (num / 1000 == 0))
            {
                int ThirdNum = num % 10;
                Console.WriteLine("Третья цифра числа: " + ThirdNum);
            }
            else { Console.WriteLine("Третьей цифры нет"); }
        }
    }
}
