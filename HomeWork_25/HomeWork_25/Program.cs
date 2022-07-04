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
            Console.WriteLine("Введите первое число");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число (степень)");
            int secondNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Возведем число "+firstNum+" в степень "+secondNum);
            int result = 1;
            
            for (int i = 0; i < secondNum; i++)
            {
                result = result * firstNum;
                
                
            }
            Console.WriteLine("Результат вычисления " + result);
        }

            
        
    }
}
