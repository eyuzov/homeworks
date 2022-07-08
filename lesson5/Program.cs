// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int[] CreateRandomArray(int N, int start, int end)
// {
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// void sumEven(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0) count++;
//     }
//     Console.WriteLine($"Sum even numbers = {count}");
// }

// Console.Clear();
// int[] myRandomArray = CreateRandomArray(10, 100, 1000);
// ShowArray(myRandomArray);
// sumEven(myRandomArray);


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


// int[] CreateRandomArray(int N, int start, int end)
// {
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// void sumOdd(int[] array)
// {
//     int sum = 0;
//     for (int i = 1; i < array.Length; i += 2)
//         sum += array[i];
//     Console.WriteLine($"Sum even numbers = {sum}");
// }

// Console.Clear();
// int[] myRandomArray = CreateRandomArray(5, -99, 101);
// ShowArray(myRandomArray);
// sumOdd(myRandomArray);

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


// int[] CreateRandomArray(int N, int start, int end)
// {
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// void difference(int[] array)
// {

//     int min = array[0];
//     int max = array[0];
//     int temp = 0;

//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < min)
//             min = array[i];
//         if (array[i] > max)
//             max = array[i];
//     }
//     System.Console.WriteLine($"min = {min}, max = {max}. Difference between min and max = {max - min} ");


// }

// Console.Clear();
// int[] myRandomArray = CreateRandomArray(10, 1, 99);
// ShowArray(myRandomArray);
// difference(myRandomArray);