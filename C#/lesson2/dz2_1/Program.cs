using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        int userNumber = Convert.ToInt32(Console.ReadLine());

        CheckNumber(userNumber);
    }

    static void CheckNumber(int num)
    {
        if (num % 7 == 0 && num % 23 == 0)
        {
            Console.WriteLine($"{num} кратно и 7, и 23.");
        }
        else
        {
            Console.WriteLine($"{num} не кратно одновременно и 7, и 23.");
        }
    }
}