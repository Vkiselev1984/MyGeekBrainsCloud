using System;
using System.Linq;

// Функции

int[] FillArray(int size, int MinRange, int MaxRange)
{
    int[] arr = new int[size];
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(MinRange, MaxRange + 1);
    }
    return arr;
}

Console.Write("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
//Размер массива:
int[] array = FillArray(N, 0, 100);

Console.Write($"Массив: [ {string.Join(", ", array)}]");


