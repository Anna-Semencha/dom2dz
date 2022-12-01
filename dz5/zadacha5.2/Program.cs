// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
Console.WriteLine("Задайте размер массива ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arrey = new int [size];
GetArreyRandom(arrey);
PrintArray(arrey);
// сумма элементов, стоящих на нечётных позициях
int sum = 0;
for (int i = 0; i < arrey.Length;)
{
    sum += arrey[i];
    i = i+2;
} 
// заполнение массива  случайными числами
void GetArreyRandom(int[] numberss)
{
    for (int i = 0; i < numberss.Length; i++)
    {
        numberss[i] = new Random().Next(10, 110);
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
Console.WriteLine($"массив  из {arrey.Length} чисел, сумма элементов, стоящих на нечётных позициях  {sum}");