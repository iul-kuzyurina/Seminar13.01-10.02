//Задайте двумерный массив. Напишите программу, которая упорядочит по 
//убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

int[,] CreateMatrixRndInt(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i,j] = rnd.Next(1, 50);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j]}, ");
            else Console.Write($"{matrix[i,j]}");
        }
        Console.WriteLine("]");
    }
}

void Bubble(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            for (int h = 0; h < matrix.GetLength(1) - 1; h++)
            {
                if (matrix[i, h] < matrix[i, h + 1]) 
                {
                    int temp = 0;
                    temp = matrix[i, h];
                    matrix[i, h] = matrix[i, h + 1];
                    matrix[i, h + 1] = temp;
                }
            }
        }
    }
}

Console.WriteLine("Исходный массив: ");
int[,] matrix  = CreateMatrixRndInt(4, 4);
PrintMatrix(matrix);

Console.WriteLine("Изменный массив: ");
Bubble(matrix);
PrintMatrix(matrix);