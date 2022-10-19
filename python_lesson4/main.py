# Пользователь вводит число, Вам необходимо вывести число Пи с той точностью знаков после запятой, сколько указал пользователь(БЕЗ ИСПОЛЬЗОВАНИЯ МОДУЛЕЙ/БИБЛИОТЕК)

# import math

# num = int(input("Введите количество знаков после запятой у числа PI "))
# num = num + 2
# pi = str(math.pi)[0:num]
# print(float(pi))


# Задайте натуральное число N. Напишите программу, которая составит список простых множителей числа N.
# N = 6 | N = 12 | 32 | 13 | 9 | 18 | 21
# 2 * 3 | 2 * 2 * 3 | 2 * 2 * 2 * 2 * 2 | 13 | 3 * 3 | 2 * 3 * 3 | 3*7


# num = int(input("Input number: "))
# list_simple = []
# i = 2

# while i <= num:
#     if num % i == 0:
#         list_simple.append(i)
#         num //= i
#         i = 2
#     else:
#         i += 1

# print(list_simple)

# Задайте последовательность чисел. Напишите программу, которая выведет список неповторяющихся элементов исходной последовательности.

# numbers = [1, 2, 3, 3, 4, 5, 5, 2]
# # print(numbers)
# new_numbers = []
# [new_numbers.append(i) for i in numbers if i not in new_numbers]
# print(new_numbers)


# numbers = [1, 2, 3, 3, 4, 5, 5, 2]
# result = []
# for i in numbers:
#     if numbers.count(i) < 2:
#         result.append(i)
# print(result)
