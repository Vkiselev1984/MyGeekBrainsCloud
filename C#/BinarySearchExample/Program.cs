//-------------  БУТКЕМП ПРОГРАММИРОВАНИЕ  --------------//

/* 
Алгоритмы в C# . Эффективность алгоритма

1. Константные выполняется одно действие O(1), O(2), O(3).....
2. Логарифмические 
3. Линейные: O(n), O(2 * n)....
4. Линейно-логарифмические
5. Квадратные
6. Кубические

Грокаем алгоритмы - https://www.youtube.com/watch?v=VMWx78i7Ftc&list=PL-U7QT3LiIYKHpiOQMrB6YXNrSn4EYJN0
скачать - https://verstkag.github.io/books/%D0%93%D1%80%D0%BE%D0%BA%D0%B0%D0%B5%D0%BC%20%D0%B0%D0%BB%D0%B3%D0%BE%D1%80%D0%B8%D1%82%D0%BC%D1%8B.pdf
*/

// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!), result = 0; // использует туже ячейку памяти
// //int k = Convert.ToInt32(Console.ReadLine()); //сохраняется в новой ячейке и занимает память
// for(int i = 1; i <= n; i++) // O(n) - линейная сложность
// result += i;
// Console.Write($"Числа: {result}");
// Если n = 10, то в консоль выведется число 55!!!

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!); // O(1)
Console.Write($"Числа: {(1 + n) / 2 * n}");
// Если n = 10, то в консоль выведется число 50!!! Потому что происходит деление целочисленных чисел. 
// В данном случае n должно быть не int а double, либо в формуле 2 должны быть явно преобразовано в 2.0


/* 
---------------- ДВОИЧНЫЙ (БИНАРНЫЙ) ПОИСК -----------------
*/

using System;

class BinarySearchExample
{
    static int BinarySearch(int[] array, int target, out int iterations)
    {
        int left = 0;
        int right = array.Length - 1;
        iterations = 0;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            iterations++;

            if (array[mid] == target)
            {
                return mid; // Нашли искомый элемент, возвращаем его индекс
            }
            else if (array[mid] < target)
            {
                left = mid + 1; // Искомый элемент находится в правой половине
            }
            else
            {
                right = mid - 1; // Искомый элемент находится в левой половине
            }
        }

        return -1; // Элемент не найден
    }

    static void Main()
    {
        int[] sortedArray = new int[10001];
        for (int i = 0; i <= 10000; i++)
        {
            sortedArray[i] = i;
        }

        Console.Write("Введите число для поиска (от 0 до 10000): ");
        int targetElement = int.Parse(Console.ReadLine());

        if (targetElement < 0 || targetElement > 10000)
        {
            Console.WriteLine("Число должно быть в диапазоне от 0 до 10000.");
            return;
        }

        int iterations;
        int result = BinarySearch(sortedArray, targetElement, out iterations);

        if (result != -1)
        {
            Console.WriteLine($"Элемент {targetElement} найден в массиве с индексом {result} за {iterations} итераций.");
        }
        else
        {
            Console.WriteLine($"Элемент {targetElement} не найден в массиве за {iterations} итераций.");
        }
    }
}
