// 1. задание 40. Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.

Console.WriteLine ("Введите сторону А");
Console.WriteLine ("Введите сторону B");
Console.WriteLine ("Введите сторону C");

int num1 = Convert.ToInt32 (Console.ReadLine());
int num2 = Convert.ToInt32 (Console.ReadLine());
int num3 = Convert.ToInt32 (Console.ReadLine());

if (num1 + num2 > num3 && num1 + num3 > num2 && num3 + num2 > num1 )
{
    Console.WriteLine ("Такой треугольник может существовать");
}
else
{
    Console.WriteLine ("Такой треугольник не может существовать");
}

// 2. задание 42. Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 - 101101, 3 - 11, 2- 10.

Console.WriteLine ("Введите Число");

int num4 = Convert.ToInt32 (Console.ReadLine());

string str = "";

while (num4>0)
{
    str = num4%2 + str;
    num4/=2;
}
Console.WriteLine (str);

// 3. задание 44. Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.
// N=5 - 0 1 1 2 3. N=3 -0 1 1

Console.WriteLine ("Введите Число");

int num5 = Convert.ToInt32 (Console.ReadLine());

int num6 = 0;
int num7 = 1;

Console.WriteLine (num6);
Console.WriteLine (num7);

for (int i =3; i <=num5; i++ )
{
    int nextNum = num6 + num7;
    Console.WriteLine(nextNum);
    num6=num7;
    num7=nextNum;
}

// 4. задание 45. Напишите программу, которая будет создавать 
// копию заданного массива с помощью поэлементного копирования.

int [] array1 = {4335,0,21,8,-32};
int [] array2 = new int[array1.Length];

for (int i = 0; i < array1.Length; i++)
{
array2[i] = array1[i];
}

Console.WriteLine (String.Join("|",array2));

// 5. задание 39. Напишите программу, которая перевернет одномерный массив (последний элемент будет 
//на первом месте, а первый на последнем и т.д.)
//[1 2 3 4 5] - [5 4 3 2 1] 

int [] array3 = {4335,0,21,8,-32};

for (int i = 0; i < array3.Length/2; i++)
{
int ch = array3[i];
array3[i] = array3[array3.Length-1-i];
array3[array3.Length-1-i] = ch;
}
Console.WriteLine (String.Join("|",array3));

// array[i] = new Random().Next(0,2); от нуля до еденицы
// array[i] = new Random().Next(10); если от нуля, то можно первую цифру не указывать
