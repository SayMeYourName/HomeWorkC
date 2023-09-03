using System;
using System.Security.Cryptography;
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов случайных целых чисел от 1 до 50 и выводит их на экран.

int Prompt(string mess)
{
    System.Console.WriteLine(mess);
    string readIn = System.Console.ReadLine();
    int result = int.Parse(readIn);
    return result;
}

int[] RndArray(int Lenght, int mValue, int maxVal)
{
    // int[] array = new int[Lenght];
    // Random rnd = new Random();
    // for (int i = 0; i < Lenght; i++)
    // {
    //     array[i] = rnd.Next(mValue, maxVal + 1);
    // }
    // return array;
    int[] randomArray = new int[Lenght];

    for (int i = 0; i < Lenght; i++)
    {
        randomArray[i] = new Random().Next(mValue, maxVal);
        Console.Write($"<{randomArray[i]}>");
    }
    return randomArray;
}

int Lenght = Prompt("длинна массива: ");
int mValue = Prompt("minimal: ");
int maxVal = Prompt("maximum: ");
int[] randomArray = RndArray(Lenght, mValue, maxVal);
