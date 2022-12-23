// Написать программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.
// 8,9-> нет, -4, 16 -> да , 25, 5 -> да, 5, 25-> да.


int num1 = new Random().Next(10,1000);
Console.WriteLine(num1);

int num2 = new Random().Next(10,1000);
Console.WriteLine(num2);

if ((num1 == num2*num2) || (num2 == num1*num1))
{
    Console.WriteLine("Да");
}
else
{
Console.WriteLine("нет");
}
