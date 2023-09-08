// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
}
void PrintArray(double[] array)
{
    foreach (double item in array)
        System.Console.Write($"{item:F2} ");
    System.Console.WriteLine();
}
double GetMax(double[] array)   
    {    
        double max = array[0];  
        foreach (double value in array)  
            if (value > max)  
                max = value;  
        
        System.Console.Write($"Максимальное значение числа в массиве: {max:F2}");
    System.Console.WriteLine();
    return max;
    }    
double GetMin(double[] array)    
    {      
        double min = array[0];          
        foreach (double value in array)      
            if (value < min)        
                min = value;      
        
        System.Console.Write($"Минимальное значение числа в массиве: {min:F2}");
    System.Console.WriteLine(); 
    return min; 
    }      
System.Console.WriteLine("Введите количество элементов массива");
int len = Convert.ToInt32(Console.ReadLine());
double[] array = new double[len];
FillArray(array);
PrintArray(array);
System.Console.WriteLine($"Разница равна: {GetMax(array)- GetMin(array)}");