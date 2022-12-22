//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите число");
int number1 = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("Введите число");
int number2 = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("Введите число");
int number3 = Convert.ToInt32 (Console.ReadLine());

int max = number1;

if(number2 > max)
{
    number2 = max;
}
else if(number3 > max)
{
    number3 = max;
}
else 
{
    Console.WriteLine(max);
}



