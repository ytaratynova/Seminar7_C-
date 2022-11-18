// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
Console.Clear();

int rowsNumber = new Random().Next(2, 10);
int columnsNumber = new Random().Next(2, 10);

int[,] array = GetArray(rowsNumber, columnsNumber, 0, 100);
Console.WriteLine("Задан случайный массив: ");
PrintArrayTwoDimensional(array);
Console.WriteLine();

Console.Write("Введите номер строки в массиве: ");
int rowUser = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите номер столбца в массиве: ");
int columnUser = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();

GetElement(rowUser, columnUser, array);


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


void PrintArrayTwoDimensional(int[,] arrToPrint)
{
    for (int i = 0; i < arrToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrToPrint.GetLength(1); j++)
        {
            Console.Write(String.Format("{0, 6}", arrToPrint[i, j]));
        }
        Console.WriteLine();
    }

}

void GetElement(int m, int n, int[,] arr) // Метод ищет элемент так, как это понятно пользователю - первый элемент (1, 1)
{
    if(m > 0 && n > 0 && m < arr.GetLength(0) + 1 && n < arr.GetLength(1) + 1)
    {
        Console.Write($"Данной позиции соответствует элемент: {arr[m-1, n-1]}");
    }
     else
    {
        Console.Write($"Позиции [{m}, {n}] в данном массиве не существует!");
    }
}

