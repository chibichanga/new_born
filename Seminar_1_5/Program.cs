// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает
// последнюю цифру этого числа. 456 -> 6 782 -> 2 918 ->8

Console.WriteLine("Введите число");
int number1 = Convert.ToInt32 (Console.ReadLine());

int result = number1%10;

Console.WriteLine(result);


