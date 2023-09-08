// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

void Main(string[] args)
{
    Console.Write("Введите длину массива: ");
    int length = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[length];
    int count = 0;
    // Заполняем массив случайными трёхзначными числами
    Random random = new();
    for (int i = 0; i < array.Length; i++)
    {
    array[i] = random.Next(100, 1000);
        // Выводим сгенерированный массив
    }
    Console.WriteLine("Массив: ");
    Console.WriteLine();   
    foreach (int element in array)
    {
        Console.Write("{0} ", element);
    }
    foreach (int number in array)
        {
            if (number % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine();
    Console.Write($"Количество четных чисел в массиве: {count}");

}

Main(args);