// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int[] week = {1,2,3,4,5,6,7};
Console.WriteLine("Введите день недели:");
string day = Console.ReadLine();
int i = Convert.ToInt32(day);
if (week[i]<=4)
{
  Console.WriteLine("Рабочий день");  
}
else
{
    Console.WriteLine("Выходной день");
}