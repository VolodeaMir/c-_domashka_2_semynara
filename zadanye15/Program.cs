﻿/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет

С этой зачей проблем небыло
*/


Console.Clear();
Console.Write("Ведите цыфру от 1 до 7 : ");
int num = int.Parse(Console.ReadLine());

if (num == 6 || num == 7)
{
    Console.WriteLine($"{num} день недели, выходной.");
}
else if (num > 0 && num < 6)
{
    Console.WriteLine($"{num} не является выходным днем.");
}
else
{
    Console.WriteLine($"Ваша цыфра {num} - > или меньше 1 или больше 7, \nчто не соответствует номерации дней недели.");
}