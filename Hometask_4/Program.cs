//Задача 1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
// в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 32, 4 -> 16

Console.WriteLine ("Введите число A");
int num1 = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Введите число B");
int num2 = Convert.ToInt32 (Console.ReadLine());

double FunPow()
{
    double sum = Math.Pow(num1, num2);
    return sum;
}
Console.WriteLine($"Число возведенное в степень {FunPow()}");

// Задача 2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11, 82 -> 10, 9012 -> 12

Console.WriteLine ("Введите число");
int num3 = Convert.ToInt32 (Console.ReadLine());

int sum = 0;

int Func()
{
    while(num3>0)
    {
    int temp = num3%10;
//sum = sum + temp;
    sum+= temp;
    num3 = num3/10;
    }
     return sum;
}
Console.WriteLine ("Сумма цифр в числе:" + Func());

// Задача 3. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] Print()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine ("Введите элемент массива \n");
        array[i] = Convert.ToInt32 (Console.ReadLine());
    }
    return array;
}
Console.WriteLine (string.Join(",", Print()));
