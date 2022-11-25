// Программа, которая задаёт значение N и выводит все натуральные числа в промежутке от N до 1

Console.WriteLine("Введите значение N: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine();
int m = 1;
if (n < 1) Console.WriteLine("Неверный ввод");
else Console.WriteLine(NumbersFromNTo1(n, m));
Console.WriteLine();

int NumbersFromNTo1(int n, int m)
{
    if (n == m) return n;
    else Console.Write(NumbersFromNTo1(n, m + 1) + ", ");
    return m;
}