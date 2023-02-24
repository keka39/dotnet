// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка.

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

void FindNumber(int[,] inArray)
{
    int minSumRowIndex = 0; 
    int minSumRow = int.MaxValue; 
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        int rowSum = 0;
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
         rowSum += inArray[i, j];
        }
            if (rowSum < minSumRow)
            {
                minSumRow = rowSum; 
                minSumRowIndex = i; 
            }
    }
        Console.WriteLine("row with min sum: " + (minSumRowIndex + 1));
            
}

Console.Clear();
Console.Write
("Введите кол-во строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int col = int.Parse(Console.ReadLine()!);

int[,] array2D = GetArray(row, col, 0, 5);

PrintArray(array2D);
Console.WriteLine();
FindNumber(array2D);





