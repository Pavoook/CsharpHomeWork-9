// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int m = GetNaturalNumber("Введите натуральное значение m:", 0);
int n = GetNaturalNumber("Введите натуральное значение n:", 0);
Console.WriteLine(CalculateAckermannFunction(m, n));

int GetNaturalNumber(string msg, int min)
{
    Console.WriteLine(msg);
    int value;
    while (!int.TryParse(Console.ReadLine(), out value) || value < min)
    {
        Console.WriteLine("Ошибка!");
        Console.WriteLine(msg);
    }
    return value;
}

int CalculateAckermannFunction(int m, int n)
{
    int result = 0;
    if (m == 0) result = n + 1;
    else
    {
        if (m > 0 && n == 0) result = CalculateAckermannFunction(m - 1, 1);
        else result = CalculateAckermannFunction(m - 1, CalculateAckermannFunction(m, n - 1));
    }
    return result;
}