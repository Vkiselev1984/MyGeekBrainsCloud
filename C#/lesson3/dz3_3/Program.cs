using System;

class UserInputToCompileForTest
{
    public static double[] ReadArrayFromConsole()
    {
        Console.WriteLine("Введите элементы массива через пробел:");
        string input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Введена пустая строка. Массив будет пустым.");
            return new double[0];
        }

        string[] inputArray = input.Split(' ');
        double[] array = new double[inputArray.Length];

        for (int i = 0; i < inputArray.Length; i++)
        {
            if (!double.TryParse(inputArray[i], out array[i]))
            {
                Console.WriteLine("Ошибка при парсинге чисел. Пожалуйста, введите корректные числа.");
                return new double[0];
            }
        }

        return array;
    }

    public static void PrintResult(double[] array)
    {
        if (array.Length == 0)
        {
            Console.WriteLine("Массив пуст");
            return;
        }

        double min = FindMin(array);
        double max = FindMax(array);
        double difference = max - min;

        Console.WriteLine($"Минимум: {min}");
        Console.WriteLine($"Максимум: {max}");
        Console.WriteLine($"Разница между максимумом и минимумом: {difference}");
    }

    public static double FindMin(double[] numbers)
    {
        if (numbers.Length == 0)
        {
            throw new ArgumentException("Массив не должен быть пустым");
        }

        double min = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }
        return min;
    }

    public static double FindMax(double[] numbers)
    {
        if (numbers.Length == 0)
        {
            throw new ArgumentException("Массив не должен быть пустым");
        }

        double max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        return max;
    }
}

class Program
{
    static void Main()
    {
        double[] array = UserInputToCompileForTest.ReadArrayFromConsole();
        UserInputToCompileForTest.PrintResult(array);
    }
}
