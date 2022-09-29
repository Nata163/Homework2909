// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
double GetAkkerman(double m, double n)
{
    double result = 0;
    if (m == 0)
    {
        return (n + 1);
    }
    else if (m > 0 && n == 0)
    {
        result = GetAkkerman(m - 1, 1);
    }
    else result = GetAkkerman(m - 1, GetAkkerman(m, n - 1));
    return result;
}

Console.WriteLine("Введите число m: ");
double m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n: ");
double n = int.Parse(Console.ReadLine());

if (m >= 0 && n >= 0)
{
    double res = GetAkkerman(m, n);
    Console.WriteLine($" A({m},{n}) равно {res}");
}
else Console.WriteLine("Введены неверные данные, числа должны быть неотрицательными");