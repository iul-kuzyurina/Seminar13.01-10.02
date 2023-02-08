﻿//Напишите программу, которая на вход принимает позиции 
//элемента в двумерном массиве, и возвращает значение этого 
//элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1, 7 -> такого элемента в массиве нет


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

Console.WriteLine("Введите индекс строчки: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите индекс столбца: ");
int n2 = Convert.ToInt32(Console.ReadLine());

int[,] key = CreateMatrixRndInt(3, 4);

void ValueElement(int n1, int n2)
{
    for(int i = 0; i < key.GetLength(0); i++)
    {
        for(int j = 0; j < key.GetLength(1); j++)
        {
            if (n1 == i && n2 == j)
            {
                Console.Write($"{key[n1-1, n2-1]}");
            }
                        
        }
    }
    if (n1 > key.GetLength(0) && n2 > key.GetLength(1))
    {
        Console.Write("такого элемента нет");
    }
}

PrintMatrix(key);
ValueElement(n1, n2);