using System;

namespace CalculateSumInLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // программа гененрирует 10 случайных чисел(1 до 10), выводит их значения на экран
            // программа подсчитывает сумму этих чисел, и выводит сумму на экран

            Random rnd = new Random();
            int sum = 0;
            
            for (int i = 1; i < 11; i++)
            {
                int myRandom = rnd.Next(1, 11);
                sum = sum + myRandom;
                Console.WriteLine($"{i} Random nr: {myRandom}");
            }
            Console.WriteLine($"Summa = {sum}", sum);



        }
    }
}
