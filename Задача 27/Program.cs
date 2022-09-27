
// Задача 27: Напишите программу, которая принимает
//  на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.WriteLine("Введите число: " );
int n = Convert.ToInt32(Console.ReadLine());
int j =0;
int rev = 0;
while (n > 0)
{
    rev = n - n%10;
    j=j+(n-rev);
    n = n/10;
    Console.WriteLine(n + " " + j);
}
Console.WriteLine(j);
