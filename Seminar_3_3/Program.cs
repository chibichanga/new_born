// напишите программу, которая принимает на вход число (N) и выдает таблицу квадратов 
// чисел от 1 до N/
// 5 - 1, 4, 9, 16, 25; 2- 1,4

Console.WriteLine ("введите число N");
int num1 = Convert.ToInt32 (Console.ReadLine());
int num2 = 1;

while (num2 <= num1)
{
    Console.WriteLine (num2*num2);
    num2 = num2 + 1;
}

// второй вариант

for(int i=1; i<=num1; i++)
{
    Console.WriteLine (i*i);
}
