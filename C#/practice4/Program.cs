using System;

public class Answer {

   //Метод PrintEvenNumbers принимает число (number), 
   //выводит все чётные числа от 1 до number (включительно), разделеные знаком табуляции.
    static void PrintEvenNumbers(int number)
    {
       for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write($"{i}\t");
            }
        }

    }

  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 6;
        }
        PrintEvenNumbers(number);
    }
}