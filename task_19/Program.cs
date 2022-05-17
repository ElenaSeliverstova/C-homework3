// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да
Console.WriteLine("введите пятизначное число");
int num = int.Parse(Console.ReadLine());
string text = num.ToString();
if (text[0] == text[4] && text [1] == text[3]) Console.WriteLine("число является палиндромом");
else Console.WriteLine("число не является палиндромом");