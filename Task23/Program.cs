﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.WriteLine("Напишите число");
int N = Convert.ToInt32(Console.ReadLine());
int i=1;
if(N>0)
{
while (i<=N)
{
    Console.WriteLine(Math.Pow (i , 3));
    i++;
}
}
else
{
    i=-1;
while (i>=N)
{
    Console.WriteLine(Math.Pow (i , 3));
    i--;
}
}

