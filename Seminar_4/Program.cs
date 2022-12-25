// 1. Задача 24. напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А.
// 7 - 28, 4 - 10 8 - 36

// тип итоговой переменной + название метода + () + 
//{
//    return sum;
//}

Console.WriteLine ("Введите число");
int num = Convert.ToInt32 (Console.ReadLine());

// int sum = 0;
// for(int i=1; i<=num; i++)
// {
//    sum = sum + i;
// }
// Console.WriteLine (sum);

int GetSum()
{
    int sum = 0;

    for(int i=1; i<=num; i++)
    {
    sum = sum + i;
    }
    return sum; 
}

Console.WriteLine (GetSum());

// 2. Задача 26. напишите программу, которая принимает на вход число и выдает количество цифр в числе.
// 456 - 3, 78 - 2 89126 - 5

Console.WriteLine ("Введите число A");
int num1 = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine (GetCountNumb());

int GetCountNumb()
{
    int count =0;
    while(num1>0)
    {
        count++;
// num1 = num1/10; 
        num1/=10;
    }
     return count;
}

// 3. Задача 28. напишите программу, которая принимает на вход число N и выдает произведение чисел
// от 1 до N.
// 4 - 24, 5 - 120

Console.WriteLine ("Введите число N");
int num2 = Convert.ToInt32 (Console.ReadLine());

int GetNumb()
{
    int result = 1;
    for (int i = 2; i <= num2; i++)
    {
    result*=i;
    }
    return result;
}
Console.WriteLine (GetNumb());

// 4. Задача 30. напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int [] GetArray()
{
    int[] array = new int [8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,2);
    }
    return array;

}
Console.WriteLine(String.Join(",", GetArray()));


