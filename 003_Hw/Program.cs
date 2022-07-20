//Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateMatrix(int n)
{
    int[,] matrix = new int[n, n];
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

void AvgMatrix(int[,] matrix)
{
    Console.WriteLine();
     
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        double avg = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            avg =  avg + matrix[j, i];
            
        }
        
        Console.WriteLine(i + 1 + " столбец: " + avg / matrix.GetLength(0) + "\t");
    }
    Console.WriteLine();
}

Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());

AvgMatrix(CreateMatrix(n));