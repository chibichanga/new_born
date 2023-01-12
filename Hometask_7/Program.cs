// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


Console.WriteLine("Введите количество строчек");
int linesVol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columnsVol = Convert.ToInt32(Console.ReadLine());

double[,] numbers = new double[linesVol,columnsVol];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = Convert.ToDouble(new Random().Next(-100, 100))/10;
        }
    }
}
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.Write(" ]");
        Console.WriteLine("");
    }
}

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите номер строки");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
int m = Convert.ToInt32(Console.ReadLine());

int [,] numbers2 = new int [10,10];
FillArrayRandomNumbers2(numbers2);

if  (n>numbers2.GetLength(0) || m>numbers2.GetLength(1))
{
Console.WriteLine("Нет такого элемента");
}
else 
{
 Console.WriteLine($"Значение элемента {n} строки и {m} столбца равно {numbers [n-1,m-1]}");   
}
PrintArray2(numbers2);

void FillArrayRandomNumbers2(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(-100, 100)/10;
        }
    }
}

void PrintArray2(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.Write(" ]");
        Console.WriteLine("");
    }
}



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
// в каждом столбце. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.WriteLine("Введите номер строки");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
int m2 = Convert.ToInt32(Console.ReadLine());


int [,] numbers3 = new int [n2,m2];
FillArrayRandomNumbers3(numbers3);

for (int j = 0; j < numbers3.GetLength(1); j++)
    {
        double avarage = 0;
        for (int i = 0; i < numbers3.GetLength(0); i++)
        {
        avarage = (avarage + numbers3 [i,j]);
        }
        avarage = avarage / n;
        Console.Write(avarage + "; ");
}
Console.WriteLine();
PrintArray3(numbers3);

void FillArrayRandomNumbers3(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray3(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.Write(" ]");
        Console.WriteLine("");
    }
}