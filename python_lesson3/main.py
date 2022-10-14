#   Задайте список из нескольких чисел. Напишите программу, которая найдёт сумму элементов списка, стоящих на нечётной позиции.
# Пример:
# o [2, 3, 5, 9, 3] -> на нечётных позициях элементы 3 и 9, ответ: 12


# numbers = [2, 3, 5, 9, 3, 5]
# sum_numbers = 0
# for i in range(len(numbers)):
#     if i % 2 > 0:
#         sum_numbers += numbers[i]
# print(sum_numbers)


################################ Новые задания ################################


#  Напишите программу, которая найдёт произведение пар чисел списка. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
# Пример:
# o [2, 3, 4, 5, 6] => [12, 15, 16];
# o [2, 3, 5, 6] => [12, 15]

# numbers = [2, 3, 4, 5, 6]
# new_numbers = list(reversed(numbers))
# multiple = 0
# res = []
# if (len(numbers) % 2 > 0):
#     length = round(len(numbers) / 2)
# else:
#     length = round(len(numbers) / 2 - 1)


# for i in range(length + 1):
#     multiple = numbers[i] * new_numbers[i]
#     res.append(multiple)

# print(res)


# Задайте список из вещественных чисел. Напишите программу, которая найдёт разницу между максимальным и минимальным значением дробной части элементов.
# Пример:
# o [1.1, 1.2, 3.1, 5, 10.01] => 0.19

# numbers = [1.1, 1.2, 3.1, 5, 10.01]
# new_numbers = []
# for i in numbers:
#     if str(i).find(".") > 0:
#         new_numbers.append("0" + str(i)[str(i).find("."):])

# new_numbers.sort()

# print(f"{numbers} => {float(new_numbers[-1]) - float(new_numbers[0])}")


# Напишите программу, которая будет преобразовывать десятичное число в двоичное.
# Пример:
# o 45 -> 101101
# o 3 -> 11
# o 2 -> 10

# print(str(bin(2)[2:]))


# x = int(input("Введите натуральное число: "))
# n = ""

# while x > 0:
#     y = str(x % 2)
#     n = y + n
#     x = int(x / 2)

# print(n)

# Задайте число N. Составьте список чисел Фибоначчи, N - количество чисел в списке


# fib1 = 1
# fib2 = 1

# n = input("Количество чисел Фибоначчи в списке: ")
# n = int(n)
# lst = []
# lst.append(fib1)
# lst.append(fib2)
# i = 0
# while i < n - 2:
#     fib_sum = fib1 + fib2
#     fib1 = fib2
#     fib2 = fib_sum
#     lst.append(fib_sum)
#     i = i + 1

# print(lst)
