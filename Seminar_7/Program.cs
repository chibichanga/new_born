// Задание 1. Задача 47. Задайте двумерный массив размером m*n
// заполненный случайными целыми числами.
// m = 3, n = 4; 
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

Console.WriteLine ("Введите количиство строк");
int rows= Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Введите количиство стоблцов");
int columns= Convert.ToInt32 (Console.ReadLine());

int [,] matrix = new int [rows,columns]; //[0,1] 0 - это строки, 1 - это колонки

for (int i = 0; i < matrix.GetLength(0); i++) // цикл перходит на след строку
{
    for (int j = 0; j < matrix.GetLength(1); j++) // цикл перходит в след. столбец
    {
        matrix[i,j] = new Random().Next(10); // будут числа от 0 до 9, можно записать Next(0,10)
        Console.Write(matrix[i,j]+" ");
    }
    Console.WriteLine();
}

// Задание 2. Задача 48.Задайте двумерный массив размером m*n
// каждый элемент в массиве находится по формуле Amn = m+n
// Выведете полученный массив на экран.
// m = 3, n = 4; 
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5 

Console.WriteLine ("Введите количиство строк для мартицы 1");
int rows1 = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Введите количиство стоблцов для мартицы 1");
int columns1= Convert.ToInt32 (Console.ReadLine());

int [,] matrix1 = new int [rows1,columns1]; 

for (int i = 0; i < matrix1.GetLength(0); i++) 
{
    for (int j = 0; j < matrix1.GetLength(1); j++) 
    {
        matrix1[i,j] = i + j;
        Console.Write(matrix1[i,j]+" ");
    }
    Console.WriteLine();
}

// Задание 3. Задача 49.Задайте двумерный массив.
// Найдите элементы, у которых оба индекса четные, и замените эти элементы
// на их квадраты.
// 1 4 7 2   1 4 7 2 
// 5 9 2 3   5 81 2 9 
// 8 4 2 4   8 4 2 4

Console.WriteLine ("Введите количиство строк для мартицы 2");
int rows2 = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Введите количиство стоблцов для мартицы 2");
int columns2= Convert.ToInt32 (Console.ReadLine());

int [,] matrix2 = new int [rows2,columns2]; 

for (int i = 0; i < matrix2.GetLength(0); i++) 
{
    for (int j = 0; j < matrix2.GetLength(1); j++) 
    {
        matrix2[i,j] = new Random().Next(10);
        Console.Write(matrix2[i,j]+" ");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int i = 0; i < matrix2.GetLength(0); i++) 
{
    for (int j = 0; j < matrix2.GetLength(1); j++) 
    {
        if (i%2 == 0 && j%2 == 0)
        {
        Console.Write(matrix2[i,j]*matrix2[i,j]+" ");
        }
        else
        {
        Console.Write(matrix2[i,j]+" ");
        }
    }
    Console.WriteLine();
}

// Задание 4. Задача 51. Задайте двумерный массив.
// Найдите элементы  на главной диагонали и сложить их.
// Диагональ - это эл. 1.1, 2.2, 3.3
// 1 4 7 2   
// 5 9 2 3   
// 8 4 2 4   
// 1+9+2 = 12 

Console.WriteLine ("Введите количиство строк для мартицы 3");
int rows3 = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Введите количиство стоблцов для мартицы 3");
int columns3= Convert.ToInt32 (Console.ReadLine());

int [,] matrix3 = new int [rows3,columns3]; 
int sum = 0;

for (int i = 0; i < matrix3.GetLength(0); i++) 
{
    for (int j = 0; j < matrix3.GetLength(1); j++) 
    {
        matrix3[i,j] = new Random().Next(10);
        if (i==j)
        {
        sum = matrix3[i,j] + sum;
        }
        else
        {
        Console.Write(matrix3[i,j]+" ");
        }
    } Console.WriteLine();
}
Console.WriteLine("Сумма элементов диагонали" + sum);

