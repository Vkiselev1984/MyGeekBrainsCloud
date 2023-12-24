using System;

// Напишите программу, которая выводит третью 
// цифру слева заданного числа
// 1234567 => 3
// 7890 => 9
// 123 => 3
// 91 => Третьей цифры нет

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int copyNumber = number;
if (number >= 100) // Число минимум трехзначное
{
    while (number >= 1000) // Делим, пока число имеет больше 3 зн
    {
        number /= 10; // number = number / 10
    }
    int thirdDigit = number % 10;
    Console.WriteLine($"3 цифра от {copyNumber} = {thirdDigit}");
}
else
{
    Console.WriteLine("Число не трехзначное");
}
