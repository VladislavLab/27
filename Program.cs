// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// Программа принимает на вход число и выдает количество цифр в числе.
int Count(int A)
{
    int res = 0;
    for (int i=1; i<=A; i++)
    {
        res+=A%10;
        A=A/10;
    }    
    return res;

}
Console.Clear();
Console.Write("Введите число:");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр числа {N} равна {Count(N)}");