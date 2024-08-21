Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Програма калькулятор");

Console.WriteLine("Введіть число a:");
double a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введіть число b:");
double b = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введіть операццію між числами a і b:");

char operation = Convert.ToChar(Console.ReadLine());

try
{
    int v = 0;

    int g = 10 / v;
    if (operation == '/')
    {
        Console.WriteLine($"Рішенням математичної задачі є: {a / b}");
    }
    else if (operation == '*')
    {
        Console.WriteLine($"Рішенням математичної задачі є: {a * b}");
    }
    else if (operation == '-')
    {
        Console.WriteLine($"Рішенням математичної задачі є: {a - b}");
    }
    else if (operation == '+')
    {
        Console.WriteLine($"Рішенням математичної задачі є: {a + b}");
    }
    else if (operation == '^')
    {
        Console.WriteLine($"Рішенням математичної задачі є: {Math.Pow(a, b)}");
    }
}
catch (DivideByZeroException)
{
    Console.WriteLine("Ділення на нуль забороенно");
}
catch (Exception)
{
    Console.WriteLine("Вираз не має змісту");
}

