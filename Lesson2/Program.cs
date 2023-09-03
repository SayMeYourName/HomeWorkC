//Задача 9. Нахождение числа от 10 до 99 и наибольшую цифру (сравнение чисел)

// int num = new Random().Next(10,100);
// System.Console.WriteLine($"<Было сгенерировано число {num}>");
// int digit1 = num / 10;
// int digit2 = num % 10;
// if(digit1 > digit2)
//     System.Console.WriteLine($"наибольшее число {digit1}");
// else if(digit1 == digit2)
//     System.Console.WriteLine($"Числа равны");
// else
//     System.Console.WriteLine($"наибольшее число {digit2}");

// for (int i = 0; i < 11; i++)
//     System.Console.Write($"{i} ");

//Задача 11. Нахождение трехзначного числа и удаление 2ой цифры из него

// int num = new Random().Next(100,1000);
// System.Console.WriteLine($"<Было сгенерировано число {num}>");
// int n1 = num / 100;
// int n3 = num % 10;
// System.Console.WriteLine($"First number {n1}>");
// System.Console.WriteLine($"Thrith number {n3}>");
// System.Console.WriteLine($"Answer {n1 + "" + n3}");



//Задача 12. На вход два числа, проверка кратности второе кратное первому, если не крато то вывод остаток деления

// Console.WriteLine("Enter a2 number");
// int a2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter a1 number");
// int a1 = Convert.ToInt32(Console.ReadLine());
// double b = a2 % a1;
// if (b == 0)
//     System.Console.WriteLine($"Второе число кратно первому");
// else
// System.Console.WriteLine($"Не кратно, остаток - {b}");

//Задача 14. Кратно ли сразу 2м числам введеное число

// Console.WriteLine("Enter number");
// int num = Convert.ToInt32(Console.ReadLine());
// int a = num % 7;
// int b = num % 23;
// if(a == 0 && b == 0)
//     System.Console.WriteLine($"Оба кратны");
// else
// System.Console.WriteLine($"Не кратны");

//Задача 16. Принимает 2 числа и проверяет является ли одно квадратом другого

// Console.WriteLine("Enter first number");
// int n1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter second number");
// int n2 = Convert.ToInt32(Console.ReadLine());

// if (n2 * n2 == n1 || n1 * n1 == n2)
//     System.Console.WriteLine($"равно корню квадратному второго");
// else
// System.Console.WriteLine($"Не являются квадратом друг жругу");