// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] Multiplication(int[,] array1, int[,] array2)
{ 
    int[,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];
    {
    for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                for (int k = 0; k < array2.GetLength(0); k++)
                {
                    array3[i,j] += array1[i,k] * array2[k,j];
                }
            }
        }
        return array3;
    }
}

Console.Clear();
Console.Write("Введите кол-во строк первой матрицы: ");
int row1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов первой матрицы: ");
int col1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во строк второй матрицы: ");
int row2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов второй матрицы: ");
int col2 = int.Parse(Console.ReadLine()!);
int[,] array1 = GetArray(row1, col1, 0, 10);
int[,] array2 = GetArray(row2, col2, 0, 10);


PrintArray(array1);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();

if(col1 != row2)
{
Console.WriteLine("cannot be multiplied");
}
else
{
int[,] result = Multiplication(array1, array2);
PrintArray(result);
}
Console.WriteLine();