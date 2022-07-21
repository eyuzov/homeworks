// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int PrintNumbersRecusiveType(int start, int end)
// {
//     if (start == end)
//     {
//         return start;
//     }
//     return (start + PrintNumbersRecusiveType(start + 1, end));
// }
// Console.Clear();

// Console.Write("Введите натуральное число M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите натуральное число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(PrintNumbersRecusiveType(M, N));

// --------------------------------------------------------------------------------

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 29

// int Akkerman(int m, int n)
// {
//     if (m == 0)
//         return n + 1;
//     else
//       if ((m != 0) && (n == 0))
//         return Akkerman(m - 1, 1);
//     else
//         return Akkerman(m - 1, Akkerman(m, n - 1));
// }
// Console.Clear();
// Console.Write("Введите неотрицательное число M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите неотрицательное число N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(Akkerman(M, N));