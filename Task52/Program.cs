// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "0");

int[,] array = GetArray(rows, columns, 0, 100);
Console.WriteLine();

Console.WriteLine("Ваш массив: ");
PrintArrayTwoDimensional(array);
Console.WriteLine();

Console.WriteLine("Среднее арифметическое значение в столбце: ");
PrintArrayOneDimensional(AverageColume(array));

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArrayOneDimensional(double[] arrToPrint)
{
    for (int i = 0; i < arrToPrint.Length; i++)
    {
        Console.Write(String.Format("{0, 13}", Math.Round((arrToPrint[i]), 2)));
    }

}

void PrintArrayTwoDimensional(int[,] arrToPrint)
{
    for (int i = 0; i < arrToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrToPrint.GetLength(1); j++)
        {
            Console.Write(String.Format("{0, 13}", arrToPrint[i, j]));
        }
        Console.WriteLine();
    }

}

double[] AverageColume(int[,] array)
{
    double[] sum = new double[array.GetLength(1)];
    double[] average = new double[array.GetLength(1)];
    
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum[j] = sum[j] + array[i, j];
        }
        average[j] = sum[j]/array.GetLength(1);
    }
    return average;
        
}