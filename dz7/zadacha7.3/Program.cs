// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int [,] numbers = new int [m,n];
GetArrayRandom(numbers);
PrintArray(numbers);
GetArraySum(numbers);


void GetArraySum(int[,] array)
{
      
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum =0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i,j];
        }
    Console.WriteLine($"В столбце {j+1} среднее арифметическое равно = {Math.Round(sum/m, 2)}");
    }

}

void GetArrayRandom(int[,] array) // заполнение массива
{
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(0,10);
    }
}
}

void PrintArray(int[,] array) // печать массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t ");
        }
       
        Console.WriteLine();
    }
}
