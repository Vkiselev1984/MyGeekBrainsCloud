using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите элементы массива через пробел:");
        string input = Console.ReadLine();
        string[] inputArray = input.Split(' ');
        Console.WriteLine("Новый массив:");
        foreach (string item in inputArray)
        {
            Console.WriteLine(item);
        }
    }
}