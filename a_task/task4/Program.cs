//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear();

int a = 44;
int b = 5;
int c = 89;

int max = a;

if(b > max) max = b;
if(c > max) max = c;

Console.Write("max= ");
Console.WriteLine(max);