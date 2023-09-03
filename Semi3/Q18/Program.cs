// string Range(int a) 
// { 
//     string result = "Введите значение не более 4"; 
//     if (a == 1) 
//         result = "x > 0, y > 0"; 
//     else if (a == 2) 
//         result = "x < 0, y > 0"; 
//     else if (a == 3) 
//         result = "x < 0, y < 0"; 
//     else if (a == 4) 
//         result = "x > 0, y < 0"; 
//     return result; 
// } 

// Console.WriteLine("Введите номер четверти"); 
// int a = Convert.ToInt32(Console.ReadLine()); 

// System.Console.WriteLine($"Диапазон: {Range(a)}");


// public class Answer
// {
//     static bool IsPalindrome(int number)
//     {
//         int numLength = GetLength(number);
//         if (numLength > 5)
//         System.Console.WriteLine("Число не пятизначное");
//         int[] digits = new int[numLength];
//         for (int i = numLength - 1; i >= 0; i--)
//         {
//             digits[i] = number % 10;
//             number /= 10;
//         }
//         for (int i = 0; i < numLength / 2; i++)
//         {
//             if (digits[i] != digits[numLength - i - 1])
//                 return false;
//         }
//         return true;
//     }

//     static int GetLength(int num)
//     {
//         int n = 0;
//         while (num > 0)
//         {
//             num /= 10;
//             n++;
//         }
//         return n;
//     }

//     // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args)
//     {
//         int number;

//         if (args.Length >= 1)
//         {
//             number = int.Parse(args[0]);
//         }
//         else
//         {
//             // Здесь вы можете поменять значения для отправки кода на Выполнение
//             number = 234322;
//         }

//         // Не удаляйте строки ниже
//         bool result = IsPalindrome(number);
//         System.Console.WriteLine($"{result}");
//     }
// }