// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Введите колличество строк в массиве");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов в массиве");
int n = Convert.ToInt32(Console.ReadLine());

double[,] numbers = new double [m,n];
GetArreyRandom(numbers); // для заполнения случайными вещ. числами
PrintArray(numbers); // печать массива


void GetArreyRandom(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) //описание строк
    {
        for (int j = 0; j < array.GetLength(1); j++) //описание столбцов
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
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