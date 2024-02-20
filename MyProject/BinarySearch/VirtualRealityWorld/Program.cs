/* Предположим, у нас есть виртуальный мир с разными локациями, и каждая локация имеет свой уникальный ключ. 
Нам нужно быстро определить, в какой локации находится нужный ключ.

Мы можем использовать бинарный поиск для этой задачи, предполагая, что локации упорядочены в виртуальном мире.
*/
using System;

class VirtualRealityWorld
{
    static string[] locations = new string[]
    {
        "Локация 1", "Локация 2", "Локация 3", "Локация 4", "Локация 5",
        "Локация 6", "Локация 7", "Локация 8", "Локация 9", "Локация 10"
    };

    static bool FindKeyLocation(string targetKey)
    {
        int left = 0;
        int right = locations.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            int comparisonResult = string.Compare(locations[mid], targetKey);

            if (comparisonResult == 0)
            {
                Console.WriteLine($"Ключ находится в {locations[mid]}!");
                return true;
            }
            else if (comparisonResult < 0)
                left = mid + 1;
            else
                right = mid - 1;
        }

        Console.WriteLine("Ключ не найден в виртуальном мире.");
        return false;
    }

    static void Main()
    {
        Console.Write("Введите ключ, который нужно найти: ");
        string targetKey = Console.ReadLine();

        FindKeyLocation(targetKey);
    }
}