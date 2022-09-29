// Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.

string ShowNumbers(int number)
{
    if (number == 1)
    {
        return "1";
    }

    string result = number + ", " + ShowNumbers(number - 1);
    return result;
}

Console.WriteLine("Введите число:");
int n = int.Parse(Console.ReadLine());
string res = ShowNumbers(n);
Console.WriteLine(res);