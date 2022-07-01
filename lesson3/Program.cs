// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да
// int RevertNumber(int input)
// {
//     int revers = 0;
//     int a1 = input % 10;
//     int a2 = input / 10 % 10;
//     int a3 = input / 100 % 10;
//     int a4 = input / 1000 % 10;
//     int a5 = input / 10000 % 10;
//     revers = a1 * 10000 + a2 * 1000 + a3 * 100 + a4 * 10 + a5;

//     return revers;
// }

// System.Console.Write("Input number: ");
// int number = System.Convert.ToInt32(System.Console.ReadLine());

// if (number <= 9999) System.Console.WriteLine("Input correct number");
// else if (number == RevertNumber(number)) System.Console.WriteLine("Number " + number + " is polindrome");
// else if (number != RevertNumber(number)) System.Console.WriteLine("Number " + number + " is not polindrome");


// ==========================================================================================
// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// double distance(int x1, int y1, int z1, int x2, int y2, int z2)
// {
//     double dist = 0;

//     dist = Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2);
//     dist = Math.Sqrt(dist);

//     return dist;
// }


// System.Console.WriteLine("Input a1: ");
// int x1 = System.Convert.ToInt32(System.Console.ReadLine());
// System.Console.WriteLine("Input y1: ");
// int y1 = System.Convert.ToInt32(System.Console.ReadLine());
// System.Console.WriteLine("Input z1: ");
// int z1 = System.Convert.ToInt32(System.Console.ReadLine());
// System.Console.WriteLine("Input x2: ");
// int x2 = System.Convert.ToInt32(System.Console.ReadLine());
// System.Console.WriteLine("Input y2: ");
// int y2 = System.Convert.ToInt32(System.Console.ReadLine());
// System.Console.WriteLine("Input z2: ");
// int z2 = System.Convert.ToInt32(System.Console.ReadLine());

// System.Console.WriteLine(distance(x1, y1, z1, x2, y2, z2));

// ==========================================================================================
// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void ShowPow(int number)
// {
//     for (int i = 1; i <= number; i++)
//     {
//         System.Console.WriteLine(i + " -> " + Math.Pow(i, 3));
//     }
// }

// System.Console.WriteLine("Input number: ");
// int number = Convert.ToInt32(System.Console.ReadLine());
// ShowPow(number);