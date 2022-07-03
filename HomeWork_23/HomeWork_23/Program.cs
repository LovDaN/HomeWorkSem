using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число N для вывода таблицы кубов");
            int numN = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= numN; i++)
            {
                int currentI = i * i * i;
                Console.WriteLine(i + " --> " +currentI); ;
            }




        }
    }
}
