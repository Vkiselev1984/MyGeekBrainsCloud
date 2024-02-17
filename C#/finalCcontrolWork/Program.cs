using System;

class Program
{
    static void Main()
    {
string[] array = new string[4];
UserInput(array, 0);

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
            UserInput(array, index + 1);
        }
        else
        {
            Console.WriteLine("Внимание: Длина введенных вами данных превышает допустимое количество символов. Попробуйте еще раз");
            UserInput(array, index);
        }
    }  
    }
}