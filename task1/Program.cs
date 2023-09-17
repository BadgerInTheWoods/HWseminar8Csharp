// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1


int prompt()
{
    Console.WriteLine("insert positive natural number");
    int N = Convert.ToInt32(Console.ReadLine());
    
    if (N > 0)
    {
        return N;
    }
    else
    {
        Console.WriteLine("incorrect number, pls try again");
        return prompt();
    }
}


void NaturalNumbers(int N)
{
    if (N == 1)
    {
        Console.Write(N + " ");
        return;
    }
    Console.Write(N + " ");
    NaturalNumbers(N - 1);
}

NaturalNumbers(prompt());