Console.WriteLine("Enter integer number   ");
int num = Convert.ToInt32( Console.ReadLine() );
int square = num * num;
Console.WriteLine(square);
Console.WriteLine($"Квадратный корень введеного числа равен {square}");

if(num > 0)
{
    System.Console.WriteLine("Это положительное число");
}
else if(num == 0)
{
    System.Console.WriteLine("Это ноль");
}
else
    System.Console.WriteLine("Число отрицательное");

int i = 1;
while (i <= 10)
{
    System.Console.Write($"{i} ");
    i++;
}
System.Console.WriteLine();

                //Проверка является ли первое число корнем квадратным второго
// Console.WriteLine("Enter a number");
// int a1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter b number");
// int a2 = Convert.ToInt32(Console.ReadLine());
// int square = a2 * a2;
// // Console.WriteLine($"Квадратный корень введеного числа равен {square}");

// if (a1 == square)
// {
//     System.Console.WriteLine("Да, это квадрат второго числа");
// }
// else
//     System.Console.WriteLine("Нет, это не квадрат второго числа");


                //Вывод всех чисел от N числа до -N числа
// Console.WriteLine("Enter N number");
// int N = Convert.ToInt32(Console.ReadLine());
// int N1 = -N;
// System.Console.WriteLine(N1);
// while (N1 <= N)
// {
//     System.Console.Write($"{N} ");
//     N = N - 1;
// }
// System.Console.WriteLine();

                //Задача №3
// Console.WriteLine("Введите трехзначное число");
// int N = Convert.ToInt32(Console.ReadLine());
// // int N1 = N/10;
// // System.Console.WriteLine(N1);
// // int a = N - (N1*10);
// System.Console.WriteLine($"{N % 10}");



