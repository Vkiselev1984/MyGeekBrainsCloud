using System;

class ShoeStore
{
    static int[] shoeSizes = new int[1000];

    static bool IsShoeAvailable(int targetSize)
    {
        int left = 0;
        int right = shoeSizes.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (shoeSizes[mid] == targetSize)
                return true;
            else if (shoeSizes[mid] < targetSize)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return false; // обувь нужного размера не найдена
    }

    static void Main()
    {
        // Заполняем массив размеров обуви
        for (int i = 0; i < shoeSizes.Length; i++)
        {
            shoeSizes[i] = i + 1; // Предполагаем, что у нас размеры обуви начинаются с 1 и заканчиваются 1000
        }

        Console.Write("Введите желаемый размер обуви: ");
        int targetSize = int.Parse(Console.ReadLine());

        if (IsShoeAvailable(targetSize))
            Console.WriteLine($"Обувь размера {targetSize} есть в наличии!");
        else
            Console.WriteLine($"Обувь размера {targetSize} отсутствует в наличии.");
    }
}