using System;

class Program
{
    static void Main()
    {
        // Задаем размер массива
        int arraySize = 10;

        // Создаем генератор случайных чисел
        Random random = new Random();

        // Создаем массив и заполняем его случайными трехзначными числами
        int[] array = new int[arraySize];
        for (int i = 0; i < arraySize; i++)
        {
            array[i] = random.Next(100, 1000); // Генерируем трехзначное число
        }

        // Выводим сгенерированный массив
        Console.WriteLine("Сгенерированный массив:");
        PrintArray(array);

        // Находим количество чётных чисел в массиве
        int evenCount = CountEvenNumbers(array);

        // Выводим результат на консоль
        Console.WriteLine($"Количество чётных чисел в массиве: {evenCount}");
    }

    // Метод для вывода массива на консоль
    static void PrintArray(int[] array)
    {
        foreach (int number in array)
        {
            Console.Write($"{number} ");
        }
        Console.WriteLine();
    }

    // Метод для подсчета количества чётных чисел в массиве
    static int CountEvenNumbers(int[] array)
    {
        int count = 0;

        foreach (int number in array)
        {
            if (number % 2 == 0)
            {
                count++;
            }
        }

        return count;
    }
}
