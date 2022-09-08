/*Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.


Console.Write("Введите первое число:");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int n = Convert.ToInt32(Console.ReadLine());
int temp = m;

if (m > n)
{
    m = n;
    n = temp;
}

PrintSum(m, n, temp = 0);

void PrintSum(int m, int n, int sum)
{
    sum = sum + n;
    if (n <= m)
    {
        Console.Write($"Сумма элементов= {sum} ");
        return;
    }
    PrintSum(m, n - 1, sum);
}

Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
*/
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int FunctionAkkerrman(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return FunctionAkkerrman(m - 1, 1);
  else return FunctionAkkerrman(m - 1, FunctionAkkerrman(m, n - 1));
}
Console.WriteLine(FunctionAkkerrman(m,n));