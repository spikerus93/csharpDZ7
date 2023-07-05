//  Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количество строк матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] GetRandomArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
}

int[,] AverageNumbers = new int[m, n];
GetRandomArray(AverageNumbers);
for (int j = 0; j < AverageNumbers.GetLength(1); j++)
{
    double average = 0;
    for (int i = 0; i < AverageNumbers.GetLength(0); i++)
    {
        average = (average + AverageNumbers[i, j]);
    }
    average = average / m;
    Console.Write(average + "; ");
}
Console.WriteLine();

void PrintArray(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t ");
        }
        Console.WriteLine();
    }
}

PrintArray(AverageNumbers);
