// Напишете программу, которая на выход принмает 
// два числа и проверяет, является ли первое число квадротом второго
// а = 25, b = 5 -> да
// а = 2, b = 10 -> нет
// а = 9, b = -3 -> да
// а = -3, b = 9 -> нет

Console.WriteLine("Введите число");
int number1 = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("Введите число");
int number2 = Convert.ToInt32 (Console.ReadLine());

if(number1 == number2*number2)
{
    Console.WriteLine("Да");
}

else
{
    Console.WriteLine("нет");
}





