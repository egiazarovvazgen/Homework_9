// Программа вычисления функции Аккермана (даны два неотрицательных числа M и N)

Console.WriteLine("Введите значение M: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.WriteLine("Введите значение N: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine();
if (m < 0 | n < 0) Console.WriteLine("Неверный ввод");
else Console.WriteLine(AckermannFunction(m, n));
Console.WriteLine();

int AckermannFunction(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return AckermannFunction(m - 1, 1);
    else return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
}