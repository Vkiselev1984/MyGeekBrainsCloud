        int a = 50;
        int b = 2;
        int c = 6;
        int d = 4;

        long result = a * b / (c + d);

        Console.WriteLine(result);

        //Ответ: 10
        // Усовершенствуем пример: long result = a / b / (c + d);

        long newResult = a / b / (c + d);

        Console.WriteLine(newResult);

        //Ответ: 2 и он не совсем правильный
        // Деля целочисленные значения мы всегда получаем как результат целочисленное значение.
        // Что бы в результате отображался и остаток, т.е. дробная часть, нам необходимо привести один из
        // опперандов к десятичному значению. Сделать это можно с помощью специального метода Convert

        newConvertedResult = float.Parse(a / b / (c + d));

        Console.WriteLine(newConvertedResult);

