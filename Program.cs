//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
Console.Clear();

Console.WriteLine("Введите натуральное число N:");

int n = Convert.ToInt32(Console.ReadLine());

void NaturalNumbersList (int n)
{
    if (n >= 1)
    {
        Console.Write($"{n} ");
    
        NaturalNumbersList(n-1);
    }
}

NaturalNumbersList(n);
