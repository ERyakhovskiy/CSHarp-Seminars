﻿// Задача №2
// Напишите программу, которая принимает на вход координаты точки(X и Y), причем X неравно 0, Y неравно 0, 
// и выдает номер координатной четверти плоскости, в которой находится эта точка.

int x = -1;
int y = -2;
if (x > 0 && y > 0)
{
    Console.WriteLine ("I Четверть");
}
if (x < 0 && y > 0)
{
    Console.WriteLine("II четверть");
}
if (x < 0 && y < 0)
{
    Console.WriteLine("III четверть");
}
if (x > 0 && y < 0)
{
    Console.WriteLine("IV четверть");
}