using System;

// Сортировка массивов
class Program
{
        static void Main()
        {
                Console.WriteLine("\n-----------------------------------------------------");
                Console.WriteLine("Арифметика и форматы данных");
                Console.WriteLine("");
                Console.WriteLine("а = 50");
                Console.WriteLine("b = 2");
                Console.WriteLine("c = 6");
                Console.WriteLine("d = 4");
                Console.WriteLine("");
                Console.WriteLine("Возьмем пример: a * b / (c + d)");

                int a = 50;
                int b = 2;
                int c = 6;
                int d = 4;

                long result = a * b / (c + d);

                Console.WriteLine("");
                Console.WriteLine($"Ответ {result}");

                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("Усовершенствуем пример: a / b / (c + d)");

                //Ответ: 2 и он не совсем правильный
                // Деля целочисленные значения мы всегда получаем как результат целочисленное значение.
                // Что бы в результате отображался и остаток, т.е. дробная часть, нам необходимо привести один из
                // опперандов к десятичному значению. 

                float newResult = float.Parse((a / (float)b / (c + d)).ToString());

                Console.WriteLine("");

                Console.WriteLine("a / b дает нам результат в виде десятичной дроби, а значит int нам не подходит");
                Console.WriteLine("");

                Console.WriteLine("Решить эту проблему можно, если определить один из операндов как float");
                Console.WriteLine("");

                Console.WriteLine("В результате наш пример будет вида: newResult = float.Parse((a / (float)b / (c + d)).ToString())");
                Console.WriteLine("");

                Console.WriteLine($"Ответ {newResult}");
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("");
        }
}
