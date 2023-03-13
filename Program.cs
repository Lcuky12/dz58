using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp57
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int minNumber = 1;
            int maxNumber = 100;
            int degreeNumber = 2;
            int numberRandom;
            int degree = 1;

            numberRandom = random.Next(minNumber, maxNumber + 1);

            while (numberRandom >= degree)
            {
                degree *= degreeNumber;
            }

            Console.WriteLine($"Число {numberRandom} будет {degreeNumber} в степени {degree} которое больше рандомного числа {numberRandom} ");
        }
    }
}