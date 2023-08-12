// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Enter number");
int num = Convert.ToInt32(Console.ReadLine());
if(num < 100)
{
        System.Console.WriteLine($"В числе нет 3 цифры");
        return;
}
int i = 3;
int digit = num.ToString()[i-1] - '0';
Console.WriteLine($"Find number {digit}");



// System.Console.WriteLine($"3 number {digit1}");