﻿int a = 1;
int b = 8;
int c = 5;
int d = 10;
int e = 3;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("max= ");
Console.WriteLine(max);