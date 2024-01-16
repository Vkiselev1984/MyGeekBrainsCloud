using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Введите целое число или 'q' для завершения:");

            // Читаем введенную строку
            string input = Console.ReadLine();

            // Выражение, которое проверяет, равна ли строка input строке "q" без учета регистра символов.
            // input.ToLower() - вызывает метод ToLower() для строки input и возвращает новую строку,
            // где все символы исходной строки преобразованы в нижний регистр.
            if (input.ToLower() == "q")
            {
                Console.WriteLine("Программа завершена.");
                break;
            }

            // Пытаемся преобразовать введенную строку в целое число
            if (int.TryParse(input, out int number))
            {
                // Проверяем условие завершения программы по сумме цифр числа
                if (IsSumOfDigitsEven(number))
                {
                    Console.WriteLine($"Сумма цифр числа {number} чётная. Программа завершена.");
                    break;
                }
                else
                {
                    Console.WriteLine($"Сумма цифр числа {number} нечётная.");
                }
            }
            else
            {
                Console.WriteLine("Введено некорректное значение. Пожалуйста, введите целое число или 'q'.");
            }
        }
    }

    // Метод для проверки чётности суммы цифр числа
    static bool IsSumOfDigitsEven(int num)
    {
        int sum = 0;

        // Получаем абсолютное значение числа, чтобы обработать отрицательные числа
        num = Math.Abs(num);

        // Считаем сумму цифр числа
        while (num > 0)
        {
            sum += num % 10;
            num /= 10;
        }

        // Проверяем, является ли сумма чётной
        return sum % 2 == 0;
    }
}
