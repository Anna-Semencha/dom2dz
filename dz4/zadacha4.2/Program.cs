// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число");
int Number = int.Parse(Console.ReadLine());
int len = NumberLen(Number);
SumNumbers(Number, len);

int NumberLen(int d) //считаем длину массива
{
    int index = 0;
    while (d > 0)
    {
        d /= 10;
        index++;
    }
    return index;
}
void SumNumbers(int n, int len) //считаем сумму 
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine(sum);
}