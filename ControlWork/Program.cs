using System;

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("Введите элементы массива через пробел:");
        string input = Console.ReadLine()!;
        string[] inputArray = input.Split(' ');
        Console.WriteLine("Новый массив:");
        foreach (string item in inputArray)
        {
            Console.WriteLine(item);
        }
    }

    static string[] FilterArray(string[] inputArray)
    {
        
        int count = 0;
        foreach (string item in inputArray)
        {
            if (item.Length <= 3)
            {
                count++;
            }
        }
        
        string[] resultArray = new string[count];
        int index = 0;
        foreach (string item in inputArray)
        {
            if (item.Length <= 3)
            {
                resultArray[index] = item;
                index++;
            }
        }

        return resultArray;        
    }
}