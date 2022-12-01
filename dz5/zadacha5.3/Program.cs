// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Задайте размер массива ");
int size = Convert.ToInt32(Console.ReadLine());
double[] arrey = new double [size];
GetArreyRandom(arrey);
PrintArray(arrey);
double min = Int32.MaxValue;
double max = Int32.MinValue;
for (int i = 0; i < arrey.Length; i++)
{
    if (arrey[i] > max)
        {
            max = arrey[i];
        }
    if (arrey[i] < min)
        {
            min = arrey[i];
        }
}

Console.WriteLine($"Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница = {max - min}");


// заполнение массива  случайными числами
void GetArreyRandom(double[] numberss)
{
    for (int i = 0; i < numberss.Length; i++)
    {
        numberss[i] = Convert.ToDouble(new Random().Next(100, 1000))/100;
    }
}
// печать массива
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}