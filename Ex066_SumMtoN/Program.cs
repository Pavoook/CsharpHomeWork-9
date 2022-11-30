// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int M = GetNaturalNumber("Введите нижнюю границу ряда натуральных чисел:", 0);
int N = GetNaturalNumber("Введите верхнюю границу ряда натуральных чисел:", M);
Console.WriteLine(CalculateSumMtoN(M, N));

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

int CalculateSumMtoN(int min, int max)
{
    int sum = 0;
    sum += min;
    min++;
    if (min <= max) sum += CalculateSumMtoN(min, max);
    else sum =+ max;
    return sum;
}