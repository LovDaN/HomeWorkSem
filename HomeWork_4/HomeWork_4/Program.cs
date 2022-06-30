using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int secondNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите третье число");
            int thirdNum = int.Parse(Console.ReadLine());
            int max = firstNum;

            if(max < secondNum)
            {
                max = secondNum;

                if (max < thirdNum)
                {
                    max = thirdNum;
                    Console.WriteLine("Максимальное число= " + max);
                }
                else
                {
                    Console.WriteLine("Максимальное число= " + max);
                }
                
            }
            else if(max < thirdNum)
            {
                max = thirdNum;
                Console.WriteLine("Максимальное число= " + max);
            }
            else
            {
               
                Console.WriteLine("Максимальное число= " + max);
            }
        }
    }
}
