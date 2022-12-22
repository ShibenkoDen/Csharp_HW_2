/*
Задача 10. Напишите программу, которая принимает на вход трехзначное число и на выходе
показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.Clear();

Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine()!);

if (number <= 999 && number >= 100)
{
    int digit1 = number / 100;
    int digit3 = number % 10;
    int digit2 = (number - digit1 * 100 - digit3) / 10;
    Console.WriteLine ($"Второй цифрой числа {number} является {digit2}");
}
else
{
    Console.WriteLine ("Ошибка. Введено не трехзначное число!");
}
