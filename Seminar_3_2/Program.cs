// напишите программу, которая по заданому номеру четверти, показывает диапозон 
// возможных координат точек в этой четверти (x и y)

Console.WriteLine ("Введите номер четверти");
int num = Convert.ToInt32 (Console.ReadLine());

if (num == 1)
{
    Console.WriteLine ("Координаты точек x > 0 и y > 0");
}
else if (num == 2)
{
    Console.WriteLine ("Координаты точек x < 0 и y > 0");
}
else if (num == 3)
{
    Console.WriteLine ("Координаты точек x < 0 и y < 0");
}
// можно внутренние скобки не ставить.
else if (num == 4)
{
    Console.WriteLine ("Координаты точек x > 0 и y < 0");
}

// второе решение

Console.WriteLine ("Введите номер");
int num1 = Convert.ToInt32 (Console.ReadLine());

switch (num1)
{
    case 1:
    {
        Console.WriteLine ("Координаты точек x > 0 и y > 0");
        break;
    }
    case 2:
    {
        Console.WriteLine ("Координаты точек x < 0 и y > 0");
        break;
    }
    case 3:
    {
        Console.WriteLine ("Координаты точек x < 0 и y < 0");
        break;
    }
    case 4:
    {
        Console.WriteLine ("Координаты точек x > 0 и y < 0");
        break;
    }
    default:
    {
        Console.WriteLine ("Число не подходит");
        break;
    }
    
}

