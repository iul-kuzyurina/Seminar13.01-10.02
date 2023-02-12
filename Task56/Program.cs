﻿//Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
//находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
//наименьшей суммой элементов: 1 строка


int[,] CreateMatrixRndInt(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i,j] = rnd.Next(1, 5);
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

void Sort(int [,] matrix)
{
    int min= 0;
    int index = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;        
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        if (i == 0)
        {
            min=sum;
        }
        else if (sum < min)
        {
            min = sum;
            index=i;
        }
                    
    }    
    Console.WriteLine( $"Итог: {index+1} строка.");
        
}

Console.WriteLine("Исходный массив: ");
int[,] matrix=CreateMatrixRndInt(3,3);
PrintMatrix(matrix);
Sort(matrix);