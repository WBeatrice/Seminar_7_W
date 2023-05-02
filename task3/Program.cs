/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int[,] CreateArray(int length1, int length2)
{
    int[,] array = new int[length1, length2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int CreateSizeArray(string arg)
{
    Console.Write($"Enter the {arg}"); //Введите
    int a = int.Parse(Console.ReadLine());
    return a;
}

void ArithmeticMeanString(int[,] array, int m) // Среднее арифметическое строк
{
    Console.Write("Arithmetic mean of strings: "); // Среднее арифметическое строк

    for (int i = 0; i < array.GetLength(0); i++)
    {
        double mean = 0; // среднее
        for (int j = 0; j < array.GetLength(1); j++)
        {
            mean += array[i, j];
        }
         mean /= m;
        Console.Write(mean + "; ");  
    }
    Console.WriteLine();
}

void ArithmeticMeanColumn(int[,] array, int n) // Среднее арифметическое столбцов
{
    Console.Write("Arithmetic mean of columns: "); // Среднее арифметическое столбцов

    
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double mean = 0; // среднее
        for (int i = 0; i < array.GetLength(0); i++)
        {
            mean += array[i, j];
        }
        mean /= n;
        Console.Write(mean + "; ");
    }
    Console.WriteLine();
}

int m = CreateSizeArray("number of rows: "); //Введите количество строк
int n = CreateSizeArray("number of columns: "); //Введите количество столбцов
int[,] array = CreateArray(m, n);
PrintArray(array);
Console.WriteLine();

ArithmeticMeanString(array, m);
ArithmeticMeanColumn(array, n);