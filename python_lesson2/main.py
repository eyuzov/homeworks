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


# 15.Напишите программу, которая принимает на вход число N и выдает набор произведений чисел от 1 до N.
# Пример:
# пусть N = 4, тогда [ 1, 2, 6, 24 ] (1, 1*2, 1*2*3, 1*2*3*4)

num = int(input("Input number "))
res = []
list = []
res2 = 1
for i in range(1, num + 1):
    list.append(i)

for i in list:
    res2 = res2 * i
    res.append(res2)

print(res)
