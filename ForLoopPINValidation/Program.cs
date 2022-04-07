using System;

namespace ForLoopPINValidation
{
    class Program
    {
        static void Main(string[] args)
        {
           // программа просит пользователя ввести ПИН - код 
           // программа проверяет, соответствует ли введенный ПИН-код значению "1234"
           // если введенное значение соответсивует "1234", в консоле выводится "Welcome!"
           // и программа завершает свою работу
           // если введенный ПИН-кол неверный, то программа просит снова ввести ПИН-код
           // у пользователя 3 попытки

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter PIN:");
                    string userPIN = Console.ReadLine();

                if (userPIN == "1234")
                {
                    Console.WriteLine("Welcom!");
                    break;
                }
                else
                {
                    Console.WriteLine($"Login failed. You tried to log in {i + 1}/3 times.");
                    if (i == 2)
                    {
                        Console.WriteLine("No attempts left. Try again later.");
                    }
                }
            }
        }
    }
}
