#   Задайте список из нескольких чисел. Напишите программу, которая найдёт сумму элементов списка, стоящих на нечётной позиции.
# Пример:
# o [2, 3, 5, 9, 3] -> на нечётных позициях элементы 3 и 9, ответ: 12


# numbers = [2, 3, 5, 9, 3, 5]
# sum_numbers = 0
# for i in range(len(numbers)):
#     if i % 2 > 0:
#         sum_numbers += numbers[i]
# print(sum_numbers)


#  Напишите программу, которая найдёт произведение пар чисел списка. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
# Пример:
# o [2, 3, 4, 5, 6] => [12, 15, 16];
# o [2, 3, 5, 6] => [12, 15]

numbers = [2, 3, 4, 5, 6]
new_numbers = list(reversed(numbers))
multiple = 0
res = []
if (len(numbers) % 2 > 0):
    length = round(len(numbers) / 2)
else:
    length = round(len(numbers) / 2 - 1)


for i in range(length + 1):
    multiple = numbers[i] * new_numbers[i]
    res.append(multiple)

print(res)
