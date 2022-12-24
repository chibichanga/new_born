// напишите программу, которая принимает на вход координаты точки (x и y), причем
// x не равно 0, и y не равно 0 и выдает номер четверти проскости, в которой находится эта точка.

Console.WriteLine ("Координата X");
int x = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Координата Y");
int y = Convert.ToInt32 (Console.ReadLine());

if ((x > 0) && (y > 0))
{
    Console.WriteLine ("Первая четверть");
}
else if ((x < 0) && (y > 0))
{
    Console.WriteLine ("Вторая четверть");
}
else if ((x < 0) && (y < 0))
{
    Console.WriteLine ("Третья четверть");
}
// можно внутренние скобки не ставить.
else if (x > 0 && y < 0)
{
    Console.WriteLine ("Четвертая четверть");
}
