﻿using System;

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int copyNumber = number;

if (number < 100)
{
    Console.WriteLine("Число не трехзначное");
}
else // В числе больше 3 цифр
{
    int digitCount = 0; // Количество цифр "справа"
    int digit = 0; // цифра справа
    while (digitCount < 3)
    {
        digit = number % 10; 
        number /= 10; // number = number / 10
        digitCount++; // digitCount = digitCount + 1
    }
    Console.WriteLine($"3 цифра с конца {copyNumber} = {digit}");
}
