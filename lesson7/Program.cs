// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.Clear();

// double[,] GetArray(int m, int n)
// {
//     double[,] result = new double[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = Math.Round(new Random().NextDouble() * 10, 2);
//         }
//     }
//     return result;
// }

// void PrintArray(double[,] inArray)
// {
//     for (int row = 0; row < inArray.GetLength(0); row++)
//     {
//         for (int column = 0; column < inArray.GetLength(1); column++)
//         {
//             Console.Write($"{inArray[row, column]} ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Write("Введите количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// double[,] array = GetArray(rows, columns);
// PrintArray(array);

// -----------------------------------------------------------------------

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет


// Console.Clear();

// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int row = 0; row < inArray.GetLength(0); row++)
//     {
//         for (int column = 0; column < inArray.GetLength(1); column++)
//         {
//             Console.Write($"{inArray[row, column]} ");
//         }
//         Console.WriteLine();
//     }
// }
// void CheckElement(int a, int b, int[,] array)
// {
//     if (a >= array.GetLength(0) || b >= array.GetLength(1)) System.Console.WriteLine($"{a}, {b} такого числа в массиве нет");
//     else { System.Console.WriteLine($"You ask index {a},{b}, and element {array[a, b]} "); }
// }


// Console.Write("Введите количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);

// System.Console.WriteLine("Input element index:");
// int a = Convert.ToInt32(System.Console.ReadLine());
// int b = Convert.ToInt32(System.Console.ReadLine());

// CheckElement(a, b, array);

// -----------------------------------------------------------------------

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// Console.Clear();

// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int row = 0; row < inArray.GetLength(0); row++)
//     {
//         for (int column = 0; column < inArray.GetLength(1); column++)
//         {
//             Console.Write($"{inArray[row, column]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void Sum41(int[,] inArray)
// {
//     double[] arr = new double[inArray.GetLength(1)];
//     for (int row = 0; row < inArray.GetLength(1); row++)
//     {
//         double sum = 0.0;
//         for (int column = 0; column < inArray.GetLength(0); column++)
//         {
//             sum = sum + inArray[column, row];
//         }
//         arr[row] = Math.Round(sum / inArray.GetLength(0), 2);
//     }

//     string s = string.Join(", ", arr);
//     System.Console.Write("Среднее арифметическое каждого столбца: ");
//     System.Console.WriteLine(s);

// }


// Console.Write("Введите количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);

// Sum41(array);