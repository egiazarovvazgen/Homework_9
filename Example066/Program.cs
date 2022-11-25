// Программа, которая задаёт значения M и N и находит сумму натуральных элементов в промежутке от M до N

Console.WriteLine("Введите значение M: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.WriteLine("Введите значение N: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine();
if (m < 1 | n < m | n < 1) Console.WriteLine("Неверный ввод");
else Console.WriteLine(SumFromMToN(m, n));
Console.WriteLine();

int SumFromMToN(int m, int n)
{
    if (m == n) return m;
    return n + SumFromMToN(m, n - 1);
}