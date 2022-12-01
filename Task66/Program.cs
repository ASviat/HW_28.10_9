// Задача 66: Задайте значения M и N. Напишите метод, который найдёт сумму 
// натуральных элементов в промежутке от M до N. Через рекурсию!

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите значение 1: ");
int digitFirst = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение 2: ");
int digitSecond = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

SumIt(digitFirst, digitSecond, 0);

int SumIt(int first, int second, int sum)
{
    if (first <= second)
    {
        sum += first++;
        return SumIt(first, second, sum);
    }
    else
    {
        Console.WriteLine($"{sum}");
    }
    return 0;
}