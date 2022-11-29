// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите a");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите b");
int b = int.Parse(Console.ReadLine());
double c = 1;
 if (b <= 10)
 {
    c = Math.Pow(a, b);
 }
 Console.WriteLine("Ответ " + c);