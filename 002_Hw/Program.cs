//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] CreateMatr(int n, int m)
{
    int[,] matrix = new int[n, m];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");

        }
        Console.WriteLine();
    }
    return matrix;
}

void CheckMatr(int i, int j, int[,] matrix)
{
    Console.WriteLine();
    if(i < matrix.GetLength(0) && j < matrix.GetLength(1) && i >=0 && j >=0)    
    Console.WriteLine(matrix[i, j]);
    else Console.WriteLine("Такого элемента не существует!");
}

Console.Write("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите i: ");
int i = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите j: ");
int j = Convert.ToInt32(Console.ReadLine());

CheckMatr(i, j, CreateMatr(n, m));


