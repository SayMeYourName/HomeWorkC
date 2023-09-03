// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел  
// от 1 до N. 

// 5 -> 1, 4, 9, 16, 25. 
// 2 -> 1,4 

// string Sqare(int num) 
// { 
//     string result = ""; 
//     for(int i = 1; i < num; i++) 
// { 
//     result += $"{i*i}, "; 
// } 
//     result += $"{num*num}."; 
//     return result; 
// } 

// System.Console.WriteLine("Введите число"); 
// int num = Convert.ToInt32(Console.ReadLine()); 

// System.Console.WriteLine(Sqare(num));

using System;

public class Answer
{
    static void ShowCube(int N)
    {
        // Введите свое решение ниже
        // Console.WriteLine("/*");
        for (int i = 1; i <= N+1; i++)
        {
            int square = i * i * i;
            if (i <= N)
            {
                Console.WriteLine("{0}", square, Math.Pow(i, 10));
            }
        // else
        // Console.WriteLine("/*");
            
        }
    }

    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args)
    {
        int N;

        if (args.Length >= 1)
        {
            N = int.Parse(args[0]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            N = 5;
        }

        // Не удаляйте строки ниже
        ShowCube(N);
    }
}