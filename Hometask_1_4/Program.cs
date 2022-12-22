// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4; 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число");
int number1 = Convert.ToInt32 (Console.ReadLine());

int numberN = 1;

while(numberN <= number1)
{
if(numberN%2 == 0)
{
    Console.WriteLine(numberN);
}
numberN = numberN + 1;
}