// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт 
//  произведение чисел от 1 до N. 
// 4 -> 24  
// 5 -> 120 
 
int Сomposition(int n) 
{ 
    int result = 1; 
    for (int i = 1; i <= n; i++) 
    { 
        result *= i; 
    } 
    return result; 
} 
 
System.Console.WriteLine("Введите число: "); 
int n = Convert.ToInt32(Console.ReadLine()); 
System.Console.WriteLine($"Произведение чисел от 1 до n равно: {Сomposition(n)}");
