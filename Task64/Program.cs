// Задача 64: Задайте значение N. Напишите метод, 
// который выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
AllNumbers(number);

int AllNumbers(int num)
{
    int i = default;
    if (num == 0) return 1;
    else
    {
        Console.Write($"{num - i} ");
        i++;
        return AllNumbers(num - i);
    }
}