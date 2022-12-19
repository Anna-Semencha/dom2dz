// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
int f = functionAkkermanck(m, n);

int functionAkkermanck(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return functionAkkermanck(m - 1, 1);
  else return functionAkkermanck(m - 1, functionAkkermanck(m, n - 1));
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
Console.Write($"Функция Аккермана = {f} ");