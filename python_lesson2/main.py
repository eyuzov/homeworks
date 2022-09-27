# 14.Напишите программу, которая принимает на вход вещественное число и показывает сумму его цифр.
# Пример:
# 67,82 -> 23
# 0,56 -> 11

num = str(input("Input number "))
res = 0
for i in num:
    if i.isdigit() == True:
        res += int(i)
print(f"{num} -> {res}")
