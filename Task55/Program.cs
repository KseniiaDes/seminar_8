// Задача 55: Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, 
// программа должна вывести сообщение для пользователя.

int[,] CreateMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    return matrix;
}

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // 0, 1
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // 3
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // 4
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("  |");
    }
}

int[,] RowsToColumns(int[,] matrix)
{
    int[,] newMatrix = CreateMatrix(matrix.GetLength(0), matrix.GetLength(1));
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            newMatrix[j, i] = matrix[i, j];
        }
    }
    return newMatrix;
}


int[,] array2D = CreateMatrixRndInt(4, 4, -10, 10);
PrintMatrix(array2D);
if (array2D.GetLength(0) != array2D.GetLength(1))
    Console.WriteLine("Ошибка! Заменить строки на столбцы невозможно.");
else
{
    Console.WriteLine();
    int[,] newArray2D = RowsToColumns(array2D);
    PrintMatrix(newArray2D);
}