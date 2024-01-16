using System;

class Program
{
    static void Main()
    {
        // Пример массива
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Вывод исходного массива
        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        // Переворачиваем массив
        ReverseArray(array);

        // Вывод перевернутого массива
        Console.WriteLine("Перевернутый массив:");
        PrintArray(array);
    }

    // Метод для переворота массива
    static void ReverseArray(int[] array)
    {
        int length = array.Length;
        for (int i = 0; i < length / 2; i++)
        {
            // Обмениваем значения элементов от начала к середине массива
            int temp = array[i];
            array[i] = array[length - 1 - i];
            array[length - 1 - i] = temp;
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
