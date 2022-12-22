/*
Задача 15. Напишите программу, котороая принимает на вход цифру, обозначающую день недели
и проверяет, является ли этот день выходным
6 -> да
7 -> да
1 -> нет
*/

Console.Clear();

Console.WriteLine ("Введите число от 1 до 7: ");
int number = int.Parse(Console.ReadLine()!);

if (number > 0 && number < 8)
{
    if (number == 6 || number == 7)
    {
        Console.WriteLine("Является выходным");
    }
    else
    {
        Console.WriteLine("Не является выходным");
    }
}
else
{
    Console.WriteLine ("Ошибка! Введите число от 1 до 7");
}