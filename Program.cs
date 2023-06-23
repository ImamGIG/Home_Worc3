Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Write("Введите пятизначное число число: ");
string? number = Console.ReadLine();

void CheckingNumber(string number)
{
    if (number[0] == number[4] || number[1] == number[3])
    {
        Console.WriteLine($"Это число: {number} - Палиндром.");
    }
    else Console.WriteLine($"Это число: {number} - не Палиндром.");
}

if (number!.Length == 5)
{
    CheckingNumber(number);
}
else Console.WriteLine($"Введи пятизначное число");

Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double FindDistance(double xa, double ya, double da, double xb, double yb, double db)
{
    return Math.Round(Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(db - da, 2)), 2);
}

System.Console.WriteLine("Inpud X coordinate point A: ");
double xa = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Inpud Y coordinate point A: ");
double ya = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Inpud D coordinate point A: ");
double da = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Inpud X coordinate point B: ");
double xb = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Inpud D coordinate point B: ");
double db = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Inpud Y coordinate            point B: ");
double yb = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine($" Distance between point A and B {FindDistance(xa, ya, da, xb, db, yb)}");

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void SquareNumber(int N)
{
    int num = 1;
    while (num <= N)
    {
        System.Console.WriteLine($"{num} -> {Math.Pow(num, 3)}");
        num++;
    }
}

System.Console.WriteLine("Введите Число N: ");
int quad = Convert.ToInt32(Console.ReadLine());
SquareNumber(quad);