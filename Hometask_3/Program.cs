// напишите программу, которая принимает на вход число (N) и выдает таблицу квадратов 
// чисел от 1 до N/
// 5 - 1, 4, 9, 16, 25; 2- 1,4

Console.WriteLine ("введите число N");
int num1 = Convert.ToInt32 (Console.ReadLine());

for(int i=1; i<=num1; i++)
{
    Console.WriteLine (i*i);
}

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine ("введите число n");
int num2 = Convert.ToInt32 (Console.ReadLine());

for(int i1=1; i1<=num2; i1++)
{
    Console.WriteLine (i1*i1*i1);
}

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine ("Введите X для точки 1");
int x1 = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Введите Y для точки 1");
int y1 = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Введите X для точки 2");
int x2 = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Введите Y для точки 2");
int y2 = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Введите X для точки 3");
int z1 = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Введите Y для точки 3");
int z2 = Convert.ToInt32 (Console.ReadLine());

double d = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1),2)  + Math.Pow((z2-z1), 2));
Console.WriteLine (d);

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет 12821 -> да 23432 -> да

Console.WriteLine ("Введите пятизначное число");
int num3 = Convert.ToInt32 (Console.ReadLine());

string aNum = Convert.ToString(num3);

if (aNum[0] == aNum[4] && aNum[1] == aNum[3])
{
    Console.WriteLine ("Да");
}
else
{
    Console.WriteLine ("Нет");
}