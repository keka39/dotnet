// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clear();

int a = 145;
int b = 43;

int max = a;
int min = a;

if(b > max) max = b;
if(b < min) min = b;

Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min);