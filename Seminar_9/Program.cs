// Задача 63.Задайте значение N.  Напишите программу, которая выведет все натуральные числа 
// в промежутке от 1 до N.
// N = 5 -> "1,2,3,4,5"
// N = 6 -> "1,2,3,4,5,6"

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());

string PrintNumber(int start, int end)
{
    if (start == end)
    {
        return start.ToString();
    }
    return (start+" "+ PrintNumber(start+1, end));
}
Console.WriteLine(PrintNumber(1,n));

// Задача 65.Задайте значение M и N.  Напишите программу, которая выведет все натуральные числа 
// в промежутке от M до N.
// M = 1, N = 5 -> "1,2,3,4,5"
// M = 4, N = 8 -> "4,5,6,7,8"

Console.WriteLine("Введите число M");
int m1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N");
int n1 = Convert.ToInt32(Console.ReadLine());

string PrintNumber1(int start1, int end1)
{
    if (start1 == end1)
    {
        return start1.ToString();
    }
    if ( start1 > end1)
    {
        return ("Числа введены некоректно");
    }
    return (start1+" "+ PrintNumber(start1+1, end1));
}
Console.WriteLine(PrintNumber1(m1,n1));

// Задача 67. Напишите программу, которая будет принимать на вход число и  
// возворащать сумму его цифр.
// 453 -> 12
// 45 -> 9


Console.WriteLine("Введите число n2");
int n2 = Convert.ToInt32(Console.ReadLine());

int SumNumber(int number)
{
    if (number == 0)
    {
        return 0;
    }
    return (number%10 + SumNumber(number/10));
}
Console.WriteLine(SumNumber(n2));

// Задачa 69. Напишите программу, которая на вход принимает два числа А и В, 
// и возводит число А в целую степень В с помощью рекурсии
// А = 3, В = 5 -> 243
// А = 2, В = 3 -> 8

Console.WriteLine("Введите число a");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень b");
int b = Convert.ToInt32(Console.ReadLine());

int SumNumber1(int A, int B)
{
    if (B == 0)
    {
        return 1;
    }
    if (B == 1)
    {
        return A;
    }
    return (A*SumNumber1(A,B-1));
}
Console.WriteLine(SumNumber1(a,b));