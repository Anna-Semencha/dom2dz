// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


int [] numbers = new int [8];
for (int i = 0; i < 9; i++)
{
    numbers [i] = new Random().Next(0, 15);
 Console.Write(numbers[i] + ";");
}
 Console.WriteLine();