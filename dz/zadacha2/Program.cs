//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число:");
string n = Console.ReadLine();
int count = n.ToString().Length;
if (count > 3)
{
 Console.WriteLine(n[2].ToString());
}
else
   {
    Console.WriteLine("третьей цифры нет"); 
   }
    