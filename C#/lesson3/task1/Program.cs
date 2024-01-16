using System;
using System.Linq;

// Функции


//Необходимо написать функцию заполнения массива рандомными числами
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

Console.WriteLine($"Массив: [ {string.Join(", ", array)}]");

//Найти число, которое делится на 7 без остатка и оканчивается на 1
int GetCountOfIntrestingElements(int[] array) {
    int count = 0;
    for (int i = 0; i < array.Length; i++){
if (array[i] % 7 == 0 && array[i] % 10 == 1){
    count++;
}
    }
    return count;
}

Console.WriteLine($"Кол-во чисел, которые делятся на 7 и оканчиваются на 1: {GetCountOfIntrestingElements(array)}");
