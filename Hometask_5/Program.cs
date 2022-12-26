// Задание 1. Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int [] array = new int[4];

int count = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100,1000);
    if (array[i]%2 == 0)
    {
        count++;
    }
}
Console.WriteLine (String.Join(",",array));
Console.WriteLine (count);

// Задание 2. Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19; [-4, -6, 89, 6] -> 0

int [] array1 = new int[4];

int sum = 0;

for (int i = 0; i < array1.Length; i++)
{
    array1[i] = new Random().Next(-99,100);
    if (i%2 == 1)
    {
        sum+=array1[i];
    }
}
Console.WriteLine (String.Join(",",array1));
Console.WriteLine (sum);

// Задание 3. Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int [] array2 = new int[6];

int mini = int.MaxValue;
int maxi = int.MinValue;

for (int i = 0; i < array2.Length; i++)
{
    array2[i] = new Random().Next(0,100);
    if (array2[i] > maxi)
    {
        maxi=array2[i];
    }
    if (array2[i] < mini)
    {
        mini=array2[i];
    }
}
Console.WriteLine (String.Join(",",array2));
Console.WriteLine (maxi-mini);