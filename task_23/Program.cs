﻿// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 4, 9.
// 5 -> 1, 8, 27, 64, 125
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.WriteLine("введите число N");
int num = int.Parse(Console.ReadLine());

Console.WriteLine("|{0,10}|{1,10}|", "число", "куб");
for (int i = 1; i <= num; i++)
{
    Console.WriteLine("|{0,10}|{1,10}|", i, i*i*i);
}