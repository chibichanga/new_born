﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
// вторую цифру этого числа.
// 456 -> 5, 782 -> 8, 918 -> 1

int num = new Random().Next(100,1000);

Console.WriteLine(num);

int num1 = num%100;
int num2 = num1/10;


int result = num2;
Console.WriteLine(result);