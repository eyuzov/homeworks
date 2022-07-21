// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int PrintNumbersRecusiveType(int start, int end)
{
    if (start == end)
    {
        return start;
    }
    return (start + PrintNumbersRecusiveType(start + 1, end));
}
Console.Clear();

Console.Write("Введите натуральное число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(PrintNumbersRecusiveType(M, N));