// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// double Distance(double x1, double x2, double y1, double y2) 
// { 
//     double result = 0; 
//     result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)); 
//     return result; 
// } 

// System.Console.WriteLine("Введите первую координату точки X"); 
// double x1 = Convert.ToInt32(Console.ReadLine()); 
// System.Console.WriteLine("Введите вторую координату точки X"); 
// double x2 = Convert.ToInt32(Console.ReadLine()); 
// System.Console.WriteLine("Введите первую координату точки Y"); 
// double y1 = Convert.ToInt32(Console.ReadLine()); 
// System.Console.WriteLine("Введите вторую координату точки Y"); 
// double y2 = Convert.ToInt32(Console.ReadLine()); 


// System.Console.WriteLine(Distance(x1, x2, y1, y2));

public class Answer
{
    private static int Square(int number)
    {
        return number * number;
    }

    private static int SumSquare(int[] pointA, int[] pointB)
    {
        int sum = 0;
        for (int i = 0; i < pointA.Length; i++)
        {
            sum += Square(pointA[i] - pointB[i]);
        }
        return sum;
    }

    private static double Length(int[] pointA, int[] pointB)
    {
        double result = Math.Sqrt(SumSquare(pointA, pointB));
        return result;
    }
// Не удаляйте и не меняйте метод Main! 
public static void Main(string[] args)
{
    int x1, x2, x3, y1, y2, y3;

    if (args.Length >= 6)
    {
        x1 = int.Parse(args[0]);
        x2 = int.Parse(args[1]);
        x3 = int.Parse(args[2]);
        y1 = int.Parse(args[3]);
        y2 = int.Parse(args[4]);
        y3 = int.Parse(args[5]);
    }
    else
    {
        // Здесь вы можете поменять значения для отправки кода на Выполнение
        x1 = 3;
        x2 = 6;
        x3 = 8;
        y1 = 2;
        y2 = 1;
        y3 = -7;
    }

    // Не удаляйте строки ниже
    double result = Length(new int[] { x1, x2, x3 }, new int[] { y1, y2, y3 });
    Console.WriteLine($"{result:F2}");
}
}