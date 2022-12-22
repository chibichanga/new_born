// напишите программу, которая будет выдавать название недели по заданому номеру.
// 3 -> среда,  5 -пятница.

Console.WriteLine("Введите число");
int number1 = Convert.ToInt32 (Console.ReadLine());

if(number1 == 1)
{
    Console.WriteLine("Понедельник");
}
else if(number1 == 2)
{
    Console.WriteLine("Вторник");
}
else if(number1 == 3)
{
    Console.WriteLine("Среда");
}
else if(number1 == 4)
{
    Console.WriteLine("Четверг");
}
else if(number1 == 5)
{
    Console.WriteLine("Пятница");
}
else if(number1 == 6)
{
    Console.WriteLine("Суббота");
}
else if(number1 == 7)
{
    Console.WriteLine("Воскресенье");
}
else 
{
    Console.WriteLine("Такого дня нет");
}