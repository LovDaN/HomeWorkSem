using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значения для проверки");
            Console.WriteLine("Введите значения первой точки x y z");
            int xA = Convert.ToInt32(Console.ReadLine());
            int yA = Convert.ToInt32(Console.ReadLine());
            int zA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значения для второй точки x y z");
            int xB = Convert.ToInt32(Console.ReadLine());
            int yB = Convert.ToInt32(Console.ReadLine());
            int zB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Координаты первой точки ("+xA+","+yA+","+zA+") Координаты для второй точки ("+xB+","+yB+","+zB+")");
            double resX = Math.Pow((xA - xB), 2);
            double resY = Math.Pow((yA - yB), 2);
            double resZ = Math.Pow((zA - zB), 2);
            double result = Math.Sqrt((resX+resY+resZ));
            result = Math.Round(result, 2);
            Console.WriteLine("Результат "+result);


        }
    }
}
