using System;

class Program
{
    static void Main()
    {
        // Задаем начальный массив
        int[] array = { 1, 5, 10, 20, 30, 40, 99, 4, 90, 3 };

        // Находим количество элементов, значения которых лежат в отрезке [10, 90]
        int countInRange = CountElementsInRange(array, 10, 90);

        // Выводим результат на консоль
        Console.WriteLine($"Количество элементов в отрезке [10, 90]: {countInRange}");
    }

    // Метод для подсчета количества элементов в массиве, значения которых лежат в заданном отрезке
    static int CountElementsInRange(int[] array, int lowerBound, int upperBound)
    {
        int count = 0;

        // Проходим по каждому элементу массива
        foreach (int number in array)
        {
            // Проверяем, лежит ли текущее число в заданном отрезке
            if (number >= lowerBound && number <= upperBound)
            {
                // Увеличиваем счетчик
                count++;
            }
        }

        return count;
    }
}