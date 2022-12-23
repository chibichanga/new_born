// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int num = new Random().Next(10,1000);
Console.WriteLine(num);

int result = num/100;

if (result == 0)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
Console.WriteLine(result);
}
