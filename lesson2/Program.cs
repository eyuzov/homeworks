// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// int number = new Random().Next(100, 1000);
// System.Console.WriteLine(number + " -> " + number / 10 % 10);

// ================================================================================

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


// int number = new Random().Next(1, 1000000);

// if (number / 100 > 0)
// {
//     System.Console.WriteLine(number + " -> " + (number / 1000) % 10);
// }
// else System.Console.WriteLine("No third digit");


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// void dayOfWeek(int day)
// {
//     if (day >= 1 && day <= 5)
//     {
//         System.Console.WriteLine(day + " working day");
//     }
//     else if (day == 6 || day == 7)
//     {
//         System.Console.WriteLine(day + " weekend");
//     }
//     else
//     {
//         System.Console.WriteLine(day + " not correct input");
//     }
// }

// int number;
// System.Console.WriteLine("Input day of week");
// number = System.Convert.ToInt32(System.Console.ReadLine());
// dayOfWeek(number);
