// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int m = ReadInt("Задайте количество строк матрицы 1: ");
int n = ReadInt("Задайте количество столбцов матрицы 1 и количество строк матрицы 2: ");
int[,] matrixOne = new int[m, n];

int k = ReadInt("Задайте количество столбцов матрицы 2: ");
int[,] matrixTwo = new int[n, k];

int[,] matrixResult = new int[m, k];

FillArray(matrixOne);
PrintArray(matrixOne);
Console.WriteLine();

FillArray(matrixTwo);
PrintArray(matrixTwo);
Console.WriteLine();

MatrixProduct(matrixOne, matrixTwo, matrixResult);
PrintArray(matrixResult);

void MatrixProduct(int[,] matrOne, int[,] matrTwo, int [,] matrRes)
{
    for (int i = 0; i < matrOne.GetLength(0); i++)
    {
        for (int j = 0; j < matrTwo.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrTwo.GetLength(1); k++)
            {
                sum += matrOne[i, k] * matrTwo[k, j];
            }
            matrRes[i,j] = sum;            
        }
    }
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}