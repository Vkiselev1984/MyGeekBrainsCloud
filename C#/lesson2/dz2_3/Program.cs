using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите целое число от 10 до 99: ");
        int userNumber = Convert.ToInt32(Console.ReadLine());

        int result = FindMaxDigit(userNumber);
        Console.WriteLine($"Наибольшая цифра в введенном числе: {result}");
    }

    static int FindMaxDigit(int number)
    {
        // Проверка, что число находится в диапазоне
        if (number >= 10 && number <= 99)
        {
            // Получаем первую и вторую цифры числа
            int digit1 = number / 10;
            int digit2 = number % 10;

            // Возвращаем наибольшую цифру
            return Math.Max(digit1, digit2);
        }
        else
        {
            Console.WriteLine("Вы ошиблись, число находится за границами диапазона");
            return number;
        }
    }
}