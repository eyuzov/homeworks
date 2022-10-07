# Вычислить число π c заданной точностью d
# Пример:
# при d = 0.001,π = 3.141 10^(-1)≤d≤10^(-10)
# import math

# num = int(input("Input power in range between -1 and -10: "))
# num = abs(num) + 2
# pi = str(math.pi)[0:num]
# print(float(pi))


#  Задайте натуральное число N. Напишите программу, которая составит список простых множителей числа N.
# 70 = 2*5*7 => [2, 5, 7]
# 140 = 2*2*5*7 => [2, 2, 5, 7]
# 140|2
# 70|2
# 35|5
# 7|7


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

# numbers = [2, 6, 1, 4, 8, 6, 4, 3, 8, 1, 5, 9]
#         # print(numbers)
# new_numbers = []
# [new_numbers.append(i) for i in numbers if i not in new_numbers]
# print(new_numbers)
