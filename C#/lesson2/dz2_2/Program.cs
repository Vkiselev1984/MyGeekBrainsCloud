using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение X: ");
        int xCoordinate = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите значение Y: ");
        int yCoordinate = Convert.ToInt32(Console.ReadLine());

        int quadrant = FindQuadrant(xCoordinate, yCoordinate);
        Console.WriteLine($"Точка находится в {quadrant} четверти координатной плоскости.");
    }

    static int FindQuadrant(int x, int y)
    {
        if (x > 0 && y > 0)
        {
            return 1;
        }
        else if (x < 0 && y > 0)
        {
            return 2;
        }
        else if (x < 0 && y < 0)
        {
            return 3;
        }
        else if (x > 0 && y < 0)
        {
            return 4;
        }
        else
        {
            Console.WriteLine("Точка лежит на одной из координатных осей.");
            return 0;
        }
    }
}