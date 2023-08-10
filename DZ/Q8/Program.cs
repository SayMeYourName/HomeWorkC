// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.WriteLine("Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.)");
Console.WriteLine("Enter N number");
int N = Convert.ToInt32(Console.ReadLine());

int i = 1;
int N1 = N % 2;
Console.WriteLine(N1);
while (i < N)
{
    if (N1 <= 1)
    {
        i = i + 1;
    }
    System.Console.Write($"{i} ");
    i++;
}
// System.Console.WriteLine();