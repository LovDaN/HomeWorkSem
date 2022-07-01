using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_10._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите число");
            int num = int.Parse(Console.ReadLine());

            if ((num / 100 > 0) && (num / 1000 == 0))
            {
                int firstNum = num / 10;
                int result = firstNum % 10;
                Console.WriteLine("Вторая цифра числа: "+ result);
            }
            else { Console.WriteLine("Это не трёхзначное число"); }

        }
        
    }
}
