// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

int[,] GetArray(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
}

int SumRow(int[,] array,int i)
{
        int rowSum = array[i,0];
        for (int j = 1; j < array.GetLength(1); j++)
        {
            rowSum += array[i,j];
        }
    return rowSum;
}

int MinSumRow(int[,] array)
{
int minSum = 0;
int sumRow = SumRow(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSumRow = SumRow(array, i);
  if (sumRow > tempSumRow)
  {
    sumRow = tempSumRow;
    minSum = i;
  }
}
return minSum;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное значение: ");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное значение: ");
int max = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(rows, columns, min, max);
PrintArray(array);
Console.WriteLine();
int minSumRow = MinSumRow(array);
Console.WriteLine("Номер строки с наименьшей сумой: " + minSumRow);