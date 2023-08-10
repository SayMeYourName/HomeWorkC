// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Enter a number");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter b number");
int b = Convert.ToInt32(Console.ReadLine());
int max = 0;

if (a > b)
{
    max = a;
}
else
max = b;
System.Console.Write($"{max} наибольшее число");
