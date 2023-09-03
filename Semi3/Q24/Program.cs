// Задача 24: Напишите программу, которая принимает на вход число (А)
//  и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int SumNumbers(int upper)
{
    int res = 0;
    for (int i = 1; i <= upper; i++)
        res += i;   //full write  res = res + i
    return res;
}

System.Console.WriteLine("Введите натуральное число ");
int num = Convert.ToInt32 (Console.ReadLine());
System.Console.WriteLine($"Сумма всех чисел от 1 до {num} равна {SumNumbers(num)}");