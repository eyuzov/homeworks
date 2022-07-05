// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// int myPow(int num, int pow)
// {
//     int result = 1;

//     for (int i = 0; i < pow; i++)
//     {
//         result = result * num;
//     }

//     return result;
// }
// Console.Clear();
// System.Console.WriteLine("Input number");
// int num = System.Convert.ToInt32(System.Console.ReadLine());

// System.Console.WriteLine("Input power");
// int pow = System.Convert.ToInt32(System.Console.ReadLine());

// System.Console.WriteLine($"{num} in power {pow} = {myPow(num, pow)}");

//============================================================================

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// int sumDigits(string number)
// {
//     int result = 0;

//     for (int i = 0; i < number.Length; i++)
//     {
//         result = result + System.Convert.ToInt32(number[i].ToString());
//     }
//     return result;
// }

// Console.Clear();
// System.Console.WriteLine("Input number");
// string num = System.Console.ReadLine();
// System.Console.WriteLine($"{sumDigits(num)}");


//============================================================================

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


// int[] CreateArray()
// {
//     int size = 8;
//     int[] RandomArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         Console.WriteLine($"Введите {i + 1} элемент массива");
//         RandomArray[i] = Convert.ToInt32(Console.ReadLine());
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

// Console.Clear();
// int[] myArray = CreateArray();
// ShowArray(myArray);
