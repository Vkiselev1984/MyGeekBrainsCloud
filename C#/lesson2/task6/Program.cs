using System;

public class Answer {
    static void Main(string[] args)
{
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number >= 100 && number <= 999)
{
    int secondDigit = number % 100 / 10;
    int thirdDigit = number % 10;
    int result = (int)Math.Pow(secondDigit, thirdDigit);
    Console.WriteLine($"{number}: {secondDigit}^{thirdDigit} = {result}");
    } 
    else 
    {
    Console.WriteLine("Число не трехзначное");
    }

}
}
