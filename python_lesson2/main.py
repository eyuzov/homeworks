# 14.Напишите программу, которая принимает на вход вещественное число и показывает сумму его цифр.
# Пример:
# 67,82 -> 23
# 0,56 -> 11

# num = str(input("Input number "))
# res = 0
# for i in num:
#     if i.isdigit() == True:
#         res += int(i)
# print(f"{num} -> {res}")


#


# 16.Задайте список из n чисел последовательности   и выведите на экран их сумму.

# num = int(input("Input number "))
# res = []
# res2 = 0
# for i in range(1, num + 1):
#     res.append((1 + 1/i)**i)

# for i in res:
#     res2 = res2 + i

# print(res2)


# 18). Реализуйте алгоритм перемешивания списка.

# import random

# list = [1, 2, 3, 4, 5, 6, 7, 8, 9]
# random.shuffle(list)
# print(list)


################################ Новые задания ################################


# 15.Напишите программу, которая принимает на вход число N и выдает набор произведений чисел от 1 до N.
# Пример:
# пусть N = 4, тогда [ 1, 2, 6, 24 ] (1, 1*2, 1*2*3, 1*2*3*4)

# num = int(input("Input number "))
# res = []
# list = []
# res2 = 1
# for i in range(1, num + 1):
#     list.append(i)

# for i in list:
#     res2 = res2 * i
#     res.append(res2)

# print(res)


# Требуется найти наименьший натуральный делитель целого числа N, отличный от 1

# Пример:

# - Для n = 15:  Ответ: 3
# - Для n = 35:  Ответ: 5


# num = int(input("Input number "))

# for i in range(2, num + 1):
#     if num % i == 0:
#         print(f"Для n = {num}: Ответ: {i}")
#         break


# Задайте список из N элементов, заполненных числами из промежутка [-N, N]. Найдите произведение элементов на указанных ИНДЕКСАХ. Пять ИНДЕКСОВ хранятся в списке, который вы сами заполняете.
# Пример списка ИНДЕКСОВ [2, 4, 3, 1, 8]
# Ввод: 10
# [-10, -9, ...-4, -3, -2, -1, 0, 1, 2, 3,4....10]

# num = int(input("Input number "))
# idxs = [2, 4, 3, 1, 8]
# lst = []
# res = 1
# for i in range(-num, num + 1):
#     lst.append(i)
# print(lst)

# for i in idxs:
#     res = res * lst[i]
# print(res)


# Требуется посчитать сумму чётных чисел, расположенных между числами 1 и N включительно.

# num = int(input("Input number "))
# res = 0
# for i in range(2, num + 1, 2):
#     res += i

# print(res)
