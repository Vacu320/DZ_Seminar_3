//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Является ли число палиндромом, введите число: ");

string n = Console.ReadLine();

int fay = n.Length;

if (fay == 5)
{
    if (n[0] == n[4] && n[1] == n[3])
    {
        Console.WriteLine($"{n} -> ДА");
    }
    else
    {
        Console.WriteLine($"{n} -> НЕТ!");
    }
}
else
{
    Console.WriteLine($"ОШИБКА: {n} - не является пятизначным");
}