// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "0");

double[,] array = GetArray(rows, columns);
Console.WriteLine();

Console.WriteLine("Ваш массив: ");
PrintArrayTwoDimensional(array);


double[,] GetArray(int m, int n)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().NextDouble() + new Random().Next(0, 100 + 1);
        }
    }
    return result;
}


void PrintArrayTwoDimensional(double[,] arrToPrint)
{
    for (int i = 0; i < arrToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrToPrint.GetLength(1); j++)
        {
            Console.Write(String.Format("{0, 13}", Math.Round(arrToPrint[i, j], 2)));
        }
        Console.WriteLine();
    }

}

