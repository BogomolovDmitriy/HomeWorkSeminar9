/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

Console.Write("Введите число m: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите число n: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine(FunctionAkkerman(n, m));

int FunctionAkkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return FunctionAkkerman(m - 1, 1);
    if (m > 0 && n > 0) return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
    return FunctionAkkerman(m, n);
}
