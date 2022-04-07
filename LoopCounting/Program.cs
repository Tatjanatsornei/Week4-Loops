using System;

namespace LoopCounting
{
    class Program
    {
        static void Main(string[] args)
        {
            //цикл выводит значение от 1 до 10

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i+1);
            }

            Console.WriteLine();//пустая строка в консоли
            //цикл выводит на экран значения от 10 до 1

            for(int i = 10; i > 0; i--) // i-- = i-1
            {
                Console.WriteLine(i);
            }
        }
    }
}
