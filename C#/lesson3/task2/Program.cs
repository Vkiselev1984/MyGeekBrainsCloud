using System;
using System.Linq;

// Функции


//Найдем число в массиве
int[] FillArray(int size, int minRange, int maxRange)
{
    int[] arr = new int[size]; // Массив на size элементов
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minRange, maxRange + 1);
    }
    return arr;
}
Console.Write("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N > 8 || N < 0) // 1,2,3,4,5,6,7 -размер массива
{
    return; // Программа не работает : размер массива отр. или > 8
}
// N - количество цифр в числе (кол-во эл)

int ConvertArrayToInt(int[] array)
{
    int res = 0;
    // i - номер эл. массива, j - степень
    for (int i = 0, j = array.Length - 1; i < array.Length; i++, j--)
    {
        res = res + array[i] * (int)Math.Pow(10, j);
        // res = 0 + 2 * 10 ^ 2 => 200, i++(j = 0 + 1), j-- (j = 2 - 1)
    }
    return res;
}
// [2,3,1] => 231; i = 0, j = 2; i++(i = 1)


int[] array = FillArray(N, 0, 9);
// Размер массива: N, элементы: [0,100]
Console.WriteLine($"Массив: [ {string.Join("; ", array)} ]");
Console.WriteLine($"Число: {ConvertArrayToInt(array)}");
