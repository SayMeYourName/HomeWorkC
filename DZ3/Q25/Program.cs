// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Prompt(string mess)
{
    System.Console.WriteLine(mess);
    string readIn = System.Console.ReadLine();
    int result = int.Parse(readIn);
    return result;


}

int Anw(int Num, int exp)
{
    int n = 1;
    for (int i = 0; i < exp; i++)
    {
        n *= Num;
    }
    return n;
}

bool Exp(int exp)
{
    if (exp < 0)
    {
        System.Console.WriteLine("Не должно быть меньше 0");
        return false;
    }
    return true;

}

int Num = Prompt("Введите А:  ");
int exp = Prompt("Введите B:  ");
if (Exp(exp))
{
    System.Console.WriteLine($"Число {Num} в степени {exp} равно {Anw(Num, exp)}");
}
