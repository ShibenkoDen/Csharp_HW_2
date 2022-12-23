/*
Задача 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает,
что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Clear();

int FindNumberLength (int number)
{
    int length = 1;
    int divider = 10;
    while (number / 10 > 0)
    {
        length = length + 1;
        divider = divider * 10;
        number = number / 10;
    }
    return length;
}

Console.WriteLine ("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int numberLength = FindNumberLength (number);

if (number < 100 && number > -100) 
{
    Console.WriteLine ($"Третьей цифры в числе {number} нет!");
}
else
{
    double divider = Math.Pow (10, numberLength-3); // возведение делителя 10 в степень (длины числа -3)
// чтобы попасть в третью цифру числа (тип double предусмотрен системой)
int digits123 = number / (int) divider; // отсекаем все, что остается после 3 цифры + переводим тип данных
int digit3 = digits123 % 10; // находим последнюю цифру из цифр 1,2,3
Console.WriteLine ($"Третьей цифрой числа {number} является {digit3}");
}