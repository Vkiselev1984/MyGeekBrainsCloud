using System;

class Program
{
    static void Main()
    {
        int M = 5;
        int N = 10;
        PrintNumbersInRange(M, N);
    }

    // Создаем рекурсию для вывода натуральных чисел
    static void PrintNumbersInRange(int currentNumber, int endNumber)
    {
        // Базовый случай
        if (currentNumber > endNumber)
        {
            return;
        }
        // Выводим текущее число
        Console.WriteLine(currentNumber);
        // Рекурсивный вызов для следующего числа
        PrintNumbersInRange(currentNumber + 1, endNumber);
    }
}