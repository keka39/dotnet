﻿// Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

void Invers(int[,] inArray)
{
    
for (int i = 0; i < inArray.GetLength(0); i++) // проходим по строкам
    {
        for (int j = 0; j < inArray.GetLength(1); j++) // проходим по столбцам
        {
            for (int k = j + 1; k < inArray.GetLength(1); k++) // проходим по оставшимся элементам
            {
                if (inArray[i, k] > inArray[i, j]) // если текущий элемент больше предыдущего
                {
                        int temp = inArray[i, j]; // меняем их местами
                        inArray[i, j] = inArray[i, k];
                        inArray[i, k] = temp;
                }
            }
        }
    }
} 

Console.Clear();
Console.Write("Введите кол-во строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int col = int.Parse(Console.ReadLine()!);

int[,] array2D = GetArray(row, col, -10, 10);

PrintArray(array2D);
Console.WriteLine();
Invers(array2D);
PrintArray(array2D);