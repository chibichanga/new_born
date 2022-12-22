// Напишите программу, которая на вход принмает одно число (N), а на выходе показывает все целые числа 
// в промежутке от -N до N.
// 4 -> "-4 -3 -2 -1 0 1 2 3 4"
// 2 -> "-2 -1 0 1 2"

Console.WriteLine("Введите число");
int number1 = Convert.ToInt32 (Console.ReadLine());

int numberNeg = -number1;

while(numberNeg <= number1)
{
    Console.WriteLine(numberNeg);
    numberNeg = numberNeg + 1;
}
