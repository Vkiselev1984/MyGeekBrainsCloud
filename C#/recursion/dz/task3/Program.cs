using System;

class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 };
        PrintArrayReverse(array, array.Length - 1);
    }

    // Метод для вывода элементов массива с конца
    static void PrintArrayReverse(int[] array, int index)
    {
        if (index < 0)
        {
            return;
        }
        Console.WriteLine(array[index]);
        PrintArrayReverse(array, index - 1);
    }
}
