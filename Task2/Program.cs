//  Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int GetSumNumbers(int firstnumber, int secondnumber)
{
    if (secondnumber == firstnumber)
    {
        return firstnumber;
    }

    int result = secondnumber + GetSumNumbers(firstnumber, secondnumber - 1);
    return result;
}

Console.WriteLine("Введите число начало промежутка M: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число конец промежутка N: ");
int n = int.Parse(Console.ReadLine());

if (m <= n)
{
    int sum = GetSumNumbers(m, n);
    Console.WriteLine($"Сумма чисел в промежутке от {m} до {n} включительно равна {sum}");
}
else Console.WriteLine("Введены неверные данные, число M должно быть меньше числа N");