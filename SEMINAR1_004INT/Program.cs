﻿// Напишите программу, которая на вход принимает одно число (N),
//а на выходе показывает все целые числа в промежутке от -N до N.

Console.WriteLine("Дорогой пользователь, введи N: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = num * (-1);

while (current <= num)
{
    Console.Write(current + " ");
    current++;
}