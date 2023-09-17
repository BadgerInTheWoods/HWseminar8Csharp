// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
Console.WriteLine("insert first number");
double M = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("insert second number");
double N = Convert.ToDouble(Console.ReadLine());

double ack(double m, double n)
{
    while (n != 0)
    {
        if (m == 0)
        {
            m = 1;
        }
        else
        {
            m = ack(n, m - 1);
        }
        n = n - 1;
    }
    return m + 1;
}
Console.WriteLine(ack(M, N));