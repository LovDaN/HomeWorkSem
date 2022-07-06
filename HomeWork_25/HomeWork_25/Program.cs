using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число A");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число B (степень)");
            int secondNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Возведем число "+firstNum+" в степень "+secondNum);
            int result = Exponentiation(firstNum, secondNum);
            Console.WriteLine("Результат вычисления " + result);

        }
        static int Exponentiation(int num, int num2)
        {
            int result = 1;
            for (int i = 0; i < num2; i++)
            {
                result = result * num;
            }
            return result;
        }



    }
}
