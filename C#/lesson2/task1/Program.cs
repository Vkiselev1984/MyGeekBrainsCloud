using System;
class Program
{
    //Проверка кратности числа 7 и 2
static void Main()
{
Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 7 == 0 && a % 23 == 0)
{
Console.WriteLine("да");
}
else
{
Console.WriteLine("нет");
}
}
}