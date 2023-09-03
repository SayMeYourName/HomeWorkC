//Принимает на вход X и Y не равные 0 и показывает четверть плоскости

void WCoorss(int x, int y)
{if(x > 0 && y > 0)
    System.Console.WriteLine("1 четверть");
else if(x > 0 && y < 0)
    System.Console.WriteLine("4 четверть");
else if(x < 0 && y < 0)
    System.Console.WriteLine("3 четверть");
else if(x < 0 && y > 0)
    System.Console.WriteLine("2 четверть"); 
else
    System.Console.WriteLine("точка на оси координат");
}


// Console.WriteLine("Enter X");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter Y");
// int y = Convert.ToInt32(Console.ReadLine());
// WCoorss(x, y);



int WCoorss2(int x, int y)
{
int res = 0;    
    if(x > 0 && y > 0)
    res = 1;
else if(x > 0 && y < 0)
    res = 4;
else if(x < 0 && y < 0)
    res = 3;
else if(x < 0 && y > 0)
   res = 2;
return res;
}

Console.WriteLine("Enter X");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Y");
int y = Convert.ToInt32(Console.ReadLine());
WCoorss(x, y);
System.Console.WriteLine($"это четверть № {WCoorss2(x, y)}");