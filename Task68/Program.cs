// Задача 68: Напишите метод вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите значение 1: ");
int digitFirst = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение 2: ");
int digitSecond = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Значение функции Аккермана = {Akkerman(digitFirst, digitSecond)} ");


int Akkerman(int first, int second)
{
    if (first == 0) return second + 1;
    if (first != 0 && second == 0) return Akkerman(first - 1, 1);
    return Akkerman(first - 1, Akkerman(first, second - 1));
}