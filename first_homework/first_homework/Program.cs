//Дано целое число, большее 999.
//Используя одну операцию деления нацело
//и одну операцию взятия остатка от деления,
//найти цифру, соответствующую разряду тысяч в записи этого числа.


using System;

namespace first_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число(>999)\n");
            int first_number = int.Parse(Console.ReadLine());
            if(first_number<1000)
                Console.WriteLine("Ошибка.Число не подходит по условию");
            else
            {
                int k = first_number / 1000;
                k = k % 10;
                Console.WriteLine($"Цифра, соответствующая разряду тысяч в записи этого числа:  {k}");
            }

            

        }
    }
}
