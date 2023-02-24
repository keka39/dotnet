// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] GetArray(int m, int n, int h)
{   
    int[,,] result = new int[m, n, h];
    int num = 10;

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < h; k++)
            {   
                result[i, j, k] = num;
                num++;
            }
        }
    } num += 10;
    return result;
}

void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.Write($"{inArray[i, j, k]}" + (i,j,k));
            }
        }
        Console.WriteLine();
    }
}


Console.Clear();
Console.Write("Введите кол-во строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int col = int.Parse(Console.ReadLine()!);
Console.Write("Введите высоту: ");
int height = int.Parse(Console.ReadLine()!);

if(row * col * height <= 90)
{
int[,,] array3D = GetArray(row, col, height);
PrintArray(array3D);
}
else
Console.WriteLine("превышение кол-ва двухзначных чисел");

