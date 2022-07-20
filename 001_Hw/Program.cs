//Задайте двумерный массив размером m×n, заполненный случайными 
//вещественными числами.

double[,] CreateMatr(int n, int m)
{
    double[,] matrix = new double[n, m];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().NextDouble()*100;
        }
    }
    return matrix;
}

void PrintMatr(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0,8:F2}", matrix[i, j]);
        }
        Console.WriteLine();
    }
}
Console.Write("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());

PrintMatr(CreateMatr(n, m));
