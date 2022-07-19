// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:

// 1 2 4 7
// 2 3 5 9
// 2 4 4 8


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

// void SortArray(int[,] inArray)
// {
//     int tmpMin = inArray[0, 0];
//     int tmp = inArray[0, 0];
//     for (int row = 0; row < inArray.GetLength(0); row++)
//     {
//         for (int column = 0; column < inArray.GetLength(1); column++)
//         {
//             for (int k = 0; k < inArray.GetLength(1) - column - 1; k++)
//             {
//                 if (inArray[row, k] > inArray[row, k + 1])
//                 {
//                     tmpMin = inArray[row, k];
//                     inArray[row, k] = inArray[row, k + 1];
//                     inArray[row, k + 1] = tmpMin;
//                 }
//             }
//         }

//     }
//     System.Console.WriteLine();
//     PrintArray(inArray);
// }

// Console.Write("Введите количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);

// SortArray(array);

// --------------------------------------------------------------------------------

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

// int[] GetSum(int[,] inArray)
// {
//     int[] arr = new int[inArray.GetLength(1)];
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             arr[j] = arr[j] + inArray[j, i];
//         }
//     }
//     return arr;
// }

// void Result(int[] sumArray)
// {
//     int min = sumArray[0];
//     int position = 0;
//     for (int i = 0; i < sumArray.Length; i++)
//     {
//         if (sumArray[i] < min)
//         {
//             min = sumArray[i];
//             position = i;
//         }
//     }

//     System.Console.WriteLine($"Минимальная сумма элементов в строке {position + 1}");

// }

// Console.Write("Введите количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] array = GetArray(rows, columns, 0, 10);

// PrintArray(array);

// int[] sumArr = GetSum(array);

// Result(sumArr);


// -----------------------------------------------------------------------------

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Например, заданы 2 массива:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// и

// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

// Их произведение будет равно следующему массиву:

// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49


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

// void Multiplication(int[,] array1, int[,] array2)
// {
//     int[,] multiArray = new int[array1.GetLength(0), array1.GetLength(1)];
//     for (int row = 0; row < array1.GetLength(0); row++)
//     {
//         for (int column = 0; column < array1.GetLength(1); column++)
//         {
//             multiArray[row, column] = array1[row, column] * array2[row, column];
//         }

//     }
//     System.Console.WriteLine();
//     PrintArray(multiArray);
// }

// Console.Write("Введите количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] array1 = GetArray(rows, columns, 0, 10);
// int[,] array2 = GetArray(rows, columns, 0, 10);

// PrintArray(array1);
// System.Console.WriteLine();
// PrintArray(array2);

// Multiplication(array1, array2);