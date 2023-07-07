// Задача 50: Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

int[,] GetRandomArray(int rows, int columns)
{
    int[,] matrix = new int[4, 5];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(1, 10);
        }

    }
    return matrix;
}

Console.WriteLine("Введите номер строки");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
int n = Convert.ToInt32(Console.ReadLine());

void MethodReturn(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t ");
        }
        Console.WriteLine();
    }

    if (m > matrix.GetLength(0)-1  || n > matrix.GetLength(1)-1  || m < 0 && n < 0)
    {
        Console.WriteLine("такого элемента нет");
    }
    else
    {
        Console.WriteLine($"значение элемента {m} строки и {n} столбца = {matrix[m,n]}");
    }
}

int[,] myMatrix = GetRandomArray(m, n);
MethodReturn(myMatrix);


