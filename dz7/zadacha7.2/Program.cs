// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.WriteLine("Введите колличество строк в массиве");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов в массиве");
int n = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double [m,n];
GetArreyRandom(numbers); // для заполнения случайными числами
PrintArray(numbers); // печать массива

Console.WriteLine("Введите индекс строки: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс столбца: ");
int colums = Convert.ToInt32(Console.ReadLine());

if (rows < numbers.GetLength(0) && colums < numbers.GetLength(1)) Console.WriteLine(numbers.GetValue(rows, colums));
else Console.WriteLine($"{rows};{colums} -> такого элемента в массиве нет");

void GetArreyRandom(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) //описание строк
    {
        for (int j = 0; j < array.GetLength(1); j++) //описание столбцов
        {
            array[i, j] = Convert.ToDouble(new Random().Next(0, 20));
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}