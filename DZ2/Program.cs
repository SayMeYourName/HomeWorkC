//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Enter XXX number");
int num = Convert.ToInt32(Console.ReadLine());
int digit1 = (num / 10)*100;
int digit2 = num % 10;
System.Console.WriteLine($"Second number {num - digit1 - digit2}");