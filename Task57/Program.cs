// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
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

int[] MatrixToOneLine(int[,] matrix)
{
    int[] oneLine = new int[matrix.GetLength(0) * matrix.GetLength(1)]; //[matrix.length]
    int q = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            oneLine[q] = matrix[i, j];
            q++;
        }
    }
    Array.Sort(oneLine);
    return oneLine;
}

void PrintDictionary(int[] array)
{
    int n = array[0];
    int count = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == n)
        {
            count++;
        }
        else
        {
            Console.WriteLine($"{n} встречается {count} раз");
            n = array[i];
            count = 1;
        }
    }
    Console.WriteLine($"{n} встречается {count} раз");
}


int[,] array2D = CreateMatrixRndInt(3, 3, 0, 10);
PrintMatrix(array2D);
int[] matrixToOneLine = MatrixToOneLine(array2D);
PrintDictionary(matrixToOneLine);