// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

void Main(string[] args)
{
    Console.Write("Введите длину массива: ");
    int length = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[length];
    // Заполняем массив случайными трёхзначными числами
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-1000, 1000);
        // Выводим сгенерированный массив
    }
    Console.WriteLine("Массив: ");
    Console.WriteLine();
    foreach (int element in array)
    {
        Console.Write("{0} ", element);
    }
    // Находим сумму элементов на нечетных позициях
    int sum = 0;
        for (int i = 0; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    // Выводим результат
    Console.WriteLine();
    Console.WriteLine($"Сумма нечетных элементов : {sum}");
}
Main(args);
