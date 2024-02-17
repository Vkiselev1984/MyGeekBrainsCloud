using System;

class Program
{
    static void Main()
    {
        string[] array = new string[4];
        UserInput(array, 0);
        int rows = array.Length;
        int cols = rows / 2;
        string[,] matrix = new string[rows, cols];
        FillMatrixFromArr(array, matrix);
        Console.WriteLine("Полученные данные: ");
        PrintMatrix(matrix);
    }

    static void UserInput(string[] array, int index)
    {
        if (index >= array.Length)
        {
            return;
        }
        Console.WriteLine($"Введите данные для индекса {index} от 0 до 3 символов: ");
        string input = Console.ReadLine();
        if (input.Length <= 3)
        {
            array[index] = input;
            UserInput(array, index +1);
        }
        else
        {
            Console.WriteLine("Внимание: Длина введенных вами данных превышает допустимое количество символов. Попробуйте еще раз");
            UserInput(array, index);
        }
    }

    static void FillMatrixFromArr(string[] array, string[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int index = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (index < array.Length)
                {
                    matrix[i, j] = array[index];
                    index++;
                }
                else
                {
                    break;
                }
            }
        }
    }

    static void PrintMatrix(string[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            Console.Write($" {matrix[i, 0]}\t");
            for (int j = 1; j < cols; j++)
            {
                Console.Write($" {matrix[i, j]}\t");
            }
            Console.WriteLine();
        }
    }
}
