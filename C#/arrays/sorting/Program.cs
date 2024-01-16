using System;

// Сортировка массивов
class Program
{
    static void Main()
    {
        Console.WriteLine("-----------------------------------------------------");
        Console.WriteLine("Сортируем массив с использованием компаратора для обратного порядка");
        Console.WriteLine("-----------------------------------------------------");

        int[] numbers = { 4, 2, 8, 6, 5 };

        Array.Sort(numbers, (a, b) => b.CompareTo(a));

        Console.WriteLine("Результат выполнения:");
        foreach (int num in numbers)
        {
            Console.Write(num + "\t");
        }

        // Веременная num не требуется предварительного объявления в коде до использования в цикле foreach. 
        // Объявление переменной выполняется автоматически в контексте цикла foreach. 
        // Тип переменной num также выводится автоматически на основе типа элементов массива 
        // (в данном случае, типа int).

        // В этом контексте num будет использоваться как временная переменная для хранения значений элементов массива.


        Console.WriteLine("\n-----------------------------------------------------");
        Console.WriteLine("Вот еще пример использования int num in numbers");
        Console.WriteLine("-----------------------------------------------------");

        string[] words = { "apple", "banana", "orange", "grape", "kiwi" };

        Console.WriteLine("Длины каждого слова:");

        foreach (string word in words)
        {
            int length = word.Length;
            Console.WriteLine($"Слово: {word}, Длина: {length}");
        }



    }
}

