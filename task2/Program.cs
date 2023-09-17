// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("insert first number");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("insert second number");
int N = Convert.ToInt32(Console.ReadLine());

if (M > N)
{
    int temp = N;
    N = M;
    M = temp;
}
int SumNumbers(int M, int N)
{
    int sum = 0;
    for (; M <= N; N--)
    {
        sum += N;
    }
    return sum;
}
Console.WriteLine($" the summary of numbers between N and M is {SumNumbers(M, N)}");