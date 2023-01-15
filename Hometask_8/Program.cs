//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
//по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine ("Введите количиство строк для задачи 1");
int rows= Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Введите количиство стоблцов для задачи 1");
int columns= Convert.ToInt32 (Console.ReadLine());

int range = InputNumbers("Введите диапазон для задачи 1: от 1 до ");

int[,] array = new int[rows, columns];
CreateArray(array);
WriteArray(array);

Console.WriteLine($"\n Отсортированный массив: ");
OrderArrayLines(array);
WriteArray(array);

void OrderArrayLines(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
//строку с наименьшей суммой элементов.
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
// суммой элементов: 1 строка

Console.WriteLine ("Введите количиство строк для задачи 2");
int rows2= Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Введите количиство стоблцов для задачи 2");
int columns2 = Convert.ToInt32 (Console.ReadLine());
int range2 = InputNumbers2("Введите диапазон для задачи 2: от 1 до ");

int[,] array2 = new int[rows2, columns2];
CreateArray2(array2);
WriteArray2(array2);

int minSumLine = 0;
int sumLine = SumLineElements(array2, 0);
for (int i = 1; i < array2.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(array2, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}

Console.WriteLine($"\n{minSumLine+1} - строка с наименьшей суммой ({sumLine}) элементов ");


int SumLineElements(int[,] array2, int i)
{
  int sumLine = array2[i,0];
  for (int j = 1; j < array2.GetLength(1); j++)
  {
    sumLine += array2[i,j];
  }
  return sumLine;
}

int InputNumbers2(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray2(int[,] array)
{
  for (int i = 0; i < array2.GetLength(0); i++)
  {
    for (int j = 0; j < array2.GetLength(1); j++)
    {
      array2[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray2 (int[,] array2)
{
  for (int i = 0; i < array2.GetLength(0); i++)
  {
    for (int j = 0; j < array2.GetLength(1); j++)
    {
      Console.Write(array2[i,j] + " ");
    }
    Console.WriteLine();
  }
}

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int m = InputNumbers("Введите число строк 1-й матрицы для задачи 3: ");
int n = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й) для задачи 3: ");
int p = InputNumbers("Введите число столбцов 2-й матрицы для задачи 3: ");
int range3 = InputNumbers3("Введите диапазон случайных чисел для задачи 3: от 1 до ");

int[,] firstMartrix = new int[m, n];
CreateArray3(firstMartrix);
Console.WriteLine($"\n Первая матрица:");
WriteArray3(firstMartrix);

int[,] secomdMartrix = new int[n, p];
CreateArray3(secomdMartrix);
Console.WriteLine($"\n Вторая матрица:");
WriteArray3(secomdMartrix);

int[,] resultMatrix = new int[m,p];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"\n Произведение первой и второй матриц:");
WriteArray(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

int InputNumbers3(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray3(int[,] array3)
{
  for (int i = 0; i < array3.GetLength(0); i++)
  {
    for (int j = 0; j < array3.GetLength(1); j++)
    {
      array3[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray3 (int[,] array3)
{
  for (int i = 0; i < array3.GetLength(0); i++)
  {
    for (int j = 0; j < array3.GetLength(1); j++)
    {
      Console.Write(array3[i,j] + " ");
    }
    Console.WriteLine();
  }
}

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int x = InputNumbers4("Введите X: ");
int y = InputNumbers4("Введите Y: ");
int z = InputNumbers4("Введите Z: ");
Console.WriteLine($"");

int[,,] array3D = new int[x, y, z];
CreateArray4(array3D);
WriteArray4(array3D);

int InputNumbers4(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void WriteArray4 (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Console.Write( $"Z({k})={array3D[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

void CreateArray4(int[,,] array3D)
{
  int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array3D.GetLength(0); x++)
  {
    for (int y = 0; y < array3D.GetLength(1); y++)
    {
      for (int z = 0; z < array3D.GetLength(2); z++)
      {
        array3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
}

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int n5 = 4;
int[,] sqareMatrix = new int[n5, n5];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
  sqareMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray5(sqareMatrix);

void WriteArray5 (int[,] array5)
{
  for (int i = 0; i < array5.GetLength(0); i++)
  {
    for (int j = 0; j < array5.GetLength(1); j++)
    {
      if (array5[i,j] / 10 <= 0)
      Console.Write($" {array5[i,j]} ");

      else Console.Write($"{array5[i,j]} ");
    }
    Console.WriteLine();
  }
}