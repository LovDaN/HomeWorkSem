using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите цифру дня недели от 1 до 7, чтобы узнать выходной ли это.");
            int day = int.Parse(Console.ReadLine());
            switch(day)
            {
                case 1: Console.WriteLine("Понедельник - не выходной"); break;
                case 2: Console.WriteLine("Вторник - не выходной"); break;
                case 3: Console.WriteLine("Среда - не выходной"); break;
                case 4: Console.WriteLine("Четверг - не выходной"); break;
                case 5: Console.WriteLine("пятница - не выходной"); break;
                case 6: Console.WriteLine("Суббота - выходной"); break;
                case 7: Console.WriteLine("Воскресенье - выходной"); break;
                default: Console.WriteLine("Нет такого дня недели, а если бы и был, то надеюсь, что - выходной"); break;
            }
                
        }
    }
}
