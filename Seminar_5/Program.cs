// 1. задание 31. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9,9]. 
// Найдите сумму отриц.и полож.элементов массива.
//[3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма полож. 29, сумма отриц.-20

int [] array = new int[12];

int posSum = 0;
int negSum = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9,10);
    if (array[i] > 0)
    {
        posSum+=array[i];
    }
    else
    {
        negSum+=array[i]; 
    }
}
Console.WriteLine (String.Join(",",array));
Console.WriteLine ("Сумма положительных элементов= " + posSum
+ " | Сумма отрицательных элементов=" + negSum);

// 2. задание 32. напишите программу замены элементов массива: положительные элементы замените на соотв.
// отриц, и наоборот
//[-4,-8,8,2]  - [4,8,-8,-2]

int [] array1 = {-4,-8,8,2};

for (int i = 0; i < array1.Length; i++)
{
    array1[i] = -array1[i];
}
Console.WriteLine (String.Join(",",array1));

// 3. задание 33. Задайте массив. Напишите программу, которая определяет,
// присутсвует ли заданное число в массиве.
// 4, массив [6,7,19,345,3] нет, 3, массив [6,7,19,345,3] да.

Console.WriteLine ("Введите число");
int num = int.Parse(Console.ReadLine());

int [] array2 = {-4,-8,8,16,0,2};
bool res = false;

for (int i = 0; i < array2.Length; i++)
{
    if (array2[i] == num)
    {
        res = true;
    }
}
if (res == true)
{
     Console.WriteLine ("Да");
}
else 
{
    Console.WriteLine ("Нет");
}

// 4. задание 35. Задайте одномерный массив из пяти случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// массив [5,18,123,6,2] - 1, массив [10,11,12,13,14] - 5


int [] array3 = new int[5];
int count = 0;

for (int i = 0; i < array3.Length; i++)
{
    array3[i] = new Random().Next(0,120);

    Console.Write (array3[i]+"  ");

    if (array3[i]>=10 && array3[i]<100)
    {
        count++;
    }
}
Console.WriteLine ();
Console.WriteLine ("Количество чисел, которые входят в этот диапазон "+count);

// 5. задание 37. Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат пишем в новом массиве.
// [1 2 3 4 5] - 583, [6736] - 36 21

Console.WriteLine ("Введите длину массива");
int num1 = int.Parse(Console.ReadLine());

int [] array4 = new int[num1];
int [] array5 = new int[(num1/2) + (num1%2)];

for (int i = 0; i < array4.Length; i++)
{
    array4[i] = new Random().Next(0,10);
}
for (int j = 0; j < array5.Length; j++)
{
    array5[j] = array4[j]*array4[num1-j-1];

    if (j==num1-1-j)
    {
        array5[j] = array4[j];
    }

}
Console.WriteLine (String.Join(",",array4));
Console.WriteLine ();
Console.WriteLine (String.Join(",",array5));