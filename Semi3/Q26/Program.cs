// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
int digitnum (int num)
{
    int count = 1;
    while (num/10 != 0)
    {
        num = num/10;
        count=count+1;
    }
    return count;
}
System.Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(digitnum(n));