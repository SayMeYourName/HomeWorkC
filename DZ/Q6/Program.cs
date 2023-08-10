// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
Console.WriteLine("Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)");
Console.WriteLine("Enter a number");
int a = Convert.ToInt32(Console.ReadLine());
int c = a % 2;
System.Console.WriteLine(c);
if (c == 0)
{
    System.Console.Write("Да, это число четное");
}
else
System.Console.Write("Нет, это число нечетное");