// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// // [1,0,1,1,0,1,0,0]

int[] Makearray()
{
    int[] array = new int[8];
    for (int i = 0; i < 8; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}
void Printarray(int[] A)
{
    for (int i = 0; i < 8; i++)
    {
        System.Console.Write($"{A[i]} ");
    }
    System.Console.WriteLine();
}
void Counting(int[] array)
{
    int count0 = 0;
    int count1 = 0;
    for (int i = 0; i < 8; i++)
    {
        if (array[i] == 0)
            count0 = count0 + 1;
        else
            count1 = count1 + 1;
    }
    if (count0 > count1)
        System.Console.WriteLine("Нулей больше, чем единиц");
    else
        System.Console.WriteLine("Единиц больше, чем нулей");
    System.Console.WriteLine();
}

int[] arr = Makearray();
Printarray(arr);
Counting(arr);
