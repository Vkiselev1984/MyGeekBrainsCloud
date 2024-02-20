using System;

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("Введите элементы массива через пробел:");
        string[] inputArray = Console.ReadLine()!.Split(' ');
        Console.WriteLine("Отфильтрованный массив строк, длинной менее 3 символов:");
        string[] filteredArray = FilterArray(inputArray);
        foreach (string item in filteredArray)
        {
            Console.WriteLine(item);
        }
    }

    static string[] FilterArray(string[] inputArray)
{
    int count = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            count++;
        }
    }

    string[] resultArray = new string[count];
    int index = 0;

    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            resultArray[index++] = inputArray[i];
        }
    }

    return resultArray;
}
}