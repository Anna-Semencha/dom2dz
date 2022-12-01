// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine("Задайте размер массива ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arrey = new int [size];
GetArreyRandom(arrey);
PrintArray(arrey);
// счётчик чётных
int count = 0;
for (int i = 0; i < arrey.Length; i++)
{
    if (arrey[i] %2 == 0)
    count++;
} 
   
// заполнение массива 3х значными числами
void GetArreyRandom(int[] numberss)
{
    for (int i = 0; i < numberss.Length; i++)
    {
        numberss[i] = new Random().Next(100, 1000);
    }
}
// печать массива
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

Console.WriteLine($"массив  из {arrey.Length} чисел, содержит {count} чётных");
