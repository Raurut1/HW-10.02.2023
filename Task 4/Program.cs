﻿Console.Write("Enter a number 1: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Enter a number 2: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Enter a number 3: ");
int c = int.Parse(Console.ReadLine()!);
int max = a;
if (a > max)  max = a;
if (b > max)  max = b;
if (c > max)  max = c;
Console.Write("Max = " + max);