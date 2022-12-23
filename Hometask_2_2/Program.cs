// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int num = new Random().Next(10,10000);
Console.WriteLine(num);

string aNum = Convert.ToString(num);

if (aNum.Length>2)
{
    Console.WriteLine(aNum[2]);
}
else
{
Console.WriteLine("Третьей цифры нет!");
}
