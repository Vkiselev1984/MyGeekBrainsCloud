

class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число: ");
        int userNumber = Convert.ToInt32(Console.ReadLine());

        string result = DisplayDigits(userNumber);
        Console.WriteLine($"Цифры числа через запятую: {result}");
    }

    static string DisplayDigits(int n)
    {
        // Преобразуем число в строку для удобства обработки цифр
        string strN = n.ToString();

        // Используем string.Join для объединения цифр через запятую
        string result = string.Join(", ", strN.ToCharArray());

        return result;
    }
}