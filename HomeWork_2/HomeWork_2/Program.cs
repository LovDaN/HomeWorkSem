using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            
            Console.WriteLine("Введите первое число");
            int FirstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int SecondNum = int.Parse(Console.ReadLine());
            int max = FirstNum;
            int min = SecondNum;
            if(max < SecondNum)
            {
                max = SecondNum;
                min = FirstNum;
                Console.WriteLine("Макимальное число= "+max);
                Console.WriteLine("Минимальное число= "+min);
            }
            else
            {
                Console.WriteLine("Макимальное число = "+max);
                Console.WriteLine("Минимальное число= " + min);
            }

        }
    }
}
