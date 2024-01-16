using System;

class Program
{
    static void Main()
    {
        // Запрашиваем у пользователя ввод массива
        int[] array = ReadArrayFromConsole();

        // Переменная для хранения количества чётных чисел
        int evenCount = 0;

        // Проходим по каждому элементу массива
        foreach (int number in array)
        {
            // Проверяем, является ли текущее число чётным
            if (number % 2 == 0)
            {
                // Увеличиваем счетчик чётных чисел
                evenCount++;
            }
        }

        // Выводим введенный массив
        Console.WriteLine("Введенный массив:");
        PrintArray(array);

        // Выводим результат на консоль
        Console.WriteLine($"Количество чётных чисел в массиве: {evenCount}");
    }

    // Метод для чтения массива из консоли
    static int[] ReadArrayFromConsole()
    {
        Console.WriteLine("Введите элементы массива через пробел:");
        string input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Введена пустая строка. Массив будет пустым.");
            return new int[0];
        }

        try
        {
            // Разделяем введенную строку на массив строк по пробелам
            string[] inputArray = input.Split(' ');

            // Создаем массив для хранения целых чисел
            int[] array = new int[inputArray.Length];

            // Проходим по каждой строке и пытаемся преобразовать ее в целое число
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (!int.TryParse(inputArray[i], out array[i]))
                {
                    Console.WriteLine("Ошибка при парсинге чисел. Пожалуйста, введите корректные числа.");
                    return new int[0];
                }
            }

            return array;
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка при парсинге чисел. Пожалуйста, введите корректные числа.");
            return new int[0];
        }
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
}