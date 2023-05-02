/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

int[,] CreateArray (int length1, int length2)
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
    System.Console.Write($"Enter the {arg}");
    int a = int.Parse(Console.ReadLine());
    return a;
}

int ReadNamber()
{
	Console.Write($"Entered number: ");
	int n = int.Parse(Console.ReadLine());
	return n;
}

int ReadNumber(string number)
{
	Console.WriteLine($"Enter the number {number}: ");
	int n = int.Parse(Console.ReadLine());
	return n;
}


int m = CreateSizeArray("number of rows: "); 
int n = CreateSizeArray("number of columns: "); 
int[,] array = CreateArray(m, n);
PrintArray(array);
Console.WriteLine();

int a = ReadNumber("column"); 
int b = ReadNumber("line"); 

if (a > array.GetLength(0) || b > array.GetLength(1))
{
    Console.WriteLine("There is no such number in the array!"); 
}
else
{
    Console.Write($"The value of the element located on the {a} column and {b} line: {array[a-1, b-1]}"); 
}