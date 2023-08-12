// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("№ Day of week");
int num = Convert.ToInt32(Console.ReadLine());
if(num > 7)
{
        System.Console.WriteLine("Введи число от 1 до 7");
        return;
}
if(num > 5)
{
    System.Console.WriteLine($"да, выходной");    
}
else
System.Console.WriteLine($"нет, не выходной");    
