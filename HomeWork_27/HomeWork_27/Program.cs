using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int number = Convert.ToInt32(Console.ReadLine());
            
            int quantity = ResNumbers(number);
            Console.WriteLine("Количество цифр в числе ("+quantity+")");

            int result = SumNumbers(number);
            Console.WriteLine("Сумма цифр числа = " + result);
        }
        static int ResNumbers(int num)
        {
            int result = 0;
            for (int i = 0; num!=0; i++)
            {
                result++;
                num = num / 10;
               
            }
            return result;
        }
        static int SumNumbers(int num)
        {
            int res = num;
            int result=0;
            int lastNum;
            while (num != 0)
            {
                lastNum = res
                    % 10;
                result = result + lastNum;
                num = num / 10;

            }
            return result;
        }
    }
}
