using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите пятизначное число для проверки");
            int number = Convert.ToInt32(Console.ReadLine());
            int result;
            if ((number >= 10000) && (number < 100000))
            {
                
                int firstNum = (number/10000)%10;
                int secondNum = (number/1000)%10;
                int thirdNum = (number/100)%10;
                int fourthNum = (number/10)%10;
                int fifthNum = number%10;
                result = fifthNum*10000+fourthNum*1000+thirdNum*100+secondNum*10+firstNum;     
                
                if  (result == number)
                {
                    Console.WriteLine("Число "+ number +" палиндром");
                }
                else { Console.WriteLine("Число "+ number +" не палиндром"); }
            }
          
            

            






        }
    }
}
