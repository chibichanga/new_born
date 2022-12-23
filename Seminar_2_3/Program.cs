// напишите программу, которая будет принимать на вход два числа и выводить, является ли
// второе число кратным первому. Если число два не кратно числу 1, то программа
// выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

int num1 = new Random().Next(10,100);
int num2 = new Random().Next(1,10);

Console.WriteLine(num1);
Console.WriteLine(num2);

int result = num1%num2;

if (result == 0)
{
    Console.WriteLine("Кратно");
}
else
{
Console.WriteLine("Остаток " + result);
}
