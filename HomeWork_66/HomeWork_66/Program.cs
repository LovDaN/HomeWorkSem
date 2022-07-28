using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_66
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Задайте число N: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Задайте число M: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            FindSumNaturalNumber(firstNumber, secondNumber);
        }
        static void FindSumNaturalNumber(int firstNum, int secondNum)
        {
            int result = 0;
            
            if (firstNum < secondNum)
            {
                while (firstNum < secondNum)
                {
                    if (result == 0) firstNum++;
                    Console.Write($"{firstNum} ");
                    result += firstNum;
                    firstNum++;
                }
            }
            else
            {
                while (secondNum < firstNum)
                {
                    if (result == 0) secondNum++;
                    Console.Write($"{secondNum} ");
                    result += secondNum;
                    secondNum++;
                }
            }
            Console.Write(" = "+result);
            Console.WriteLine();
            
           
        }
    }
}
