// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int n = InputInt("Введите положительное число ");
int m = 1;
if (n < 1)
{
    Console.WriteLine("Ввели не положительное число ");
}
Console.WriteLine(NaturalNumber(n, m));

int NaturalNumber(int n, int m)
{
    if (n == m)
        return n;
    else
        Console.Write($"{NaturalNumber(n, m + 1)}, ");
    return m;
}

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int m2 = InputInt2("Введите M:");
int n2 = InputInt2("Введите N:");
Console.WriteLine($"Сумма элементов от {m2} до {n2} = {CountNaturalSum(m2, n2)}");

int InputInt2(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int CountNaturalSum(int m2, int n2)
{
    if (m2 == n2)
        return n2;
    return n2 + CountNaturalSum(m2, n2 - 1);
}

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int m3 = InputInt3("Введите M: ");
int n3 = InputInt3("Введите N: ");
Console.WriteLine($"A({m3}, {n3}) = {Akkerman(m3, n3)}");

int InputInt3(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int Akkerman(int m3, int n3)
{
    if (m3 == 0)
        return n3 + 1;
    if (m3 > 0 && n3 == 0)
        return Akkerman(m3 - 1, 1);
    else
        return Akkerman(m3 - 1, Akkerman(m3, n3 - 1));
}