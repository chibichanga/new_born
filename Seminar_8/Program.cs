// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

Console.WriteLine("Введите количество строчек");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());



int [,] GetArray()
{
    int[,] result= new int [rows,columns];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i,j] = new Random().Next(10);
        }
    }
    return result;
}
int [,] ChageRows(int[,] result)
{
    int  change=0;
    int rowsCount= result.GetLength(0)-1;
    for (int i = 0; i <result.GetLength(0); i++)
    {
        change = result[0,i];
        result[0,i]= result[rowsCount,i];
        result[rowsCount,i]=change;
    }
    return result;
}
void PrintArray(int[,] result)
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            Console.Write(result[i,j]);
            
        }
        Console.WriteLine();
    }
}
int [,] matrix= GetArray();
PrintArray(matrix);

Console.WriteLine();

PrintArray(ChageRows(matrix));


// Задача 55: Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. В случае, если это невозможно, 
// программа должна вывести сообщение для пользователя.

Console.WriteLine("Введите количество строчек");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns1 = Convert.ToInt32(Console.ReadLine());

if (rows1!=columns1)
{
    Console.WriteLine("Массив не подходит");
    return;
}

int [,] GetArray1()
{
    int[,] result= new int [rows1,columns1];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i,j] = new Random().Next(10);
        }
    }
    return result;
}
int [,] ChageArray(int[,] result)
{
    int [,] array_2= new int[result.GetLength(0),result.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            array_2[j,i] = result[i,j];
        }
    }
    return array_2;
}
void PrintArray1(int[,] result)
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            Console.Write(result[i,j]);
            
        }
        Console.WriteLine();
    }
}
int [,] matrix1= GetArray1();
PrintArray1(matrix1);

Console.WriteLine();

PrintArray1(ChageArray(matrix1));

/// Задача 59: Задайте двумерный массив из целых чисел.
//  Напишите программу, которая удалит строку и столбец
//  , на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:

Console.WriteLine("Введите количество строчек");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns2 = Convert.ToInt32(Console.ReadLine());

int minValue=int.MaxValue;
int minIndexRows=0;
int minIndexCol=0;
int [,] GetArray2()
{
    int[,] result= new int [rows2,columns2];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i,j] = new Random().Next(10);
            if ( result[i,j]<minValue)
            {
                minValue= result[i,j];
                int minIndexRows=i;
                int minIndexCol=j;
            }
        }
    }
    return result;
}
void ChageArray2(int[,] result)
{
    
    for (int i = 0; i < result.GetLength(0); i++)
    {
        if (i!=minIndexRows)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                if (j!=minIndexCol)
                {
                     Console.Write(result[i,j]+"\t");

                }
                
            }
            Console.WriteLine();
        }
        
    }
    
}
void PrintArray2(int[,] result)
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            Console.Write(result[i,j]);
            
        }
        Console.WriteLine();
    }
}
int [,] matrix2= GetArray2();
PrintArray2(matrix2);

Console.WriteLine();

ChageArray2(matrix2);
