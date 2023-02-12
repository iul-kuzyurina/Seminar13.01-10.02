//Задайте две матрицы. Напишите программу, которая будет находить 
//произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

int rc=3; //переменная количеста строк и столбцов

int[,] CreateMatrixRndInt(int rows, int columns) // функция создания массива
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i,j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix) //функция вывода массива на экран
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



void UmnogMatrix(int [,] a, int [,] b) //функция умножения матриц
{
    int [,] matrixC=new int[rc,rc];
    for (int i=0; i<rc;i++)
    {
        for(int j=0; j<rc;j++)
        {
            for(int h=0; h<rc; h++)
            {
                matrixC[i,h]+=a[i,j]*b[j,h];
            }
        }
    }

    Console.WriteLine("Итоговая матрица: ");
    PrintMatrix(matrixC);
}

Console.WriteLine("матрица 1: ");
int[,] matrixA =CreateMatrixRndInt(rc,rc);
PrintMatrix(matrixA);

Console.WriteLine("матрица 2: ");
int[,] matrixB =CreateMatrixRndInt(rc,rc);
PrintMatrix(matrixB);

UmnogMatrix(matrixA, matrixB);