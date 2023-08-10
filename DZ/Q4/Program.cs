// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");
Console.WriteLine("Enter a number");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter b number");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter c number");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;

if (a < b)
{
    max = b;
}   
    if (c > max)
    {
        max = c;
    }   
 
System.Console.Write($"{max} наибольшее число");
// Условия не подставлял, решил сделать универсальный вариант для любых чисел.