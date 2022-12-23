// Написать программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.
// 14 -> нет, 46 -> нет, 161 -> да.


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
