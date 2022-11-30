// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int N = GetNaturalNumber("Введите целое число больше 1:");
ShowNumsNto1(N);

int GetNaturalNumber(string msg)
{
    Console.WriteLine(msg);
    int value;
    while (!int.TryParse(Console.ReadLine(), out value) || value <= 1)
    {
        Console.WriteLine("Ошибка!");
        Console.WriteLine(msg);
    }
    return value;
}

void ShowNumsNto1(int number)
{
    Console.Write(number + ", ");
    number--; 
    if (number > 1) ShowNumsNto1(number);
    else Console.Write(1);
}