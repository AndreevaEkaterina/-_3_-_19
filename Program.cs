// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
// Console.Clear();
// void Pal(int n)
// {
//     //a1.b1.c.b2.a2
//     int a1 = n / 10000;
//     int a2 = n % 10;
//     int b1 = n / 1000 % 10;
//     int b2 = n % 100 / 10;
//     if (a1 == a2 && b1 == b2)
//     {
//         Console.Write($"{n} -> палиндромом. ");
//     }
//     else
//     {
//         Console.Write($"{n} -> не палиндромом.");
//     }
// }
// Console.Write("Введите пятизначное число: ");
// int num = int.Parse(Console.ReadLine()!);
// if (num > 9999 && num < 100000)
// {
//     Console.Write($"{Pal(num)}");
// }
// else
// {
//     Console.Write("Попробуйте снова!");
// }
Console.Clear();
Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine()!);
if (num > 9999 && num < 100000)
{
    //a1.b1.c.b2.a2
    int a1 = num / 10000;
    int a2 = num % 10;
    int b1 = num / 1000 % 10;
    int b2 = num % 100 / 10;
    if (a1 == a2 && b1 == b2)
    {
        Console.Write($"{num} -> палиндромом. ");
    }
    else
    {
        Console.Write($"{num} -> не палиндромом.");
    }
}
else
{
    Console.Write("Попробуйте снова!");
}