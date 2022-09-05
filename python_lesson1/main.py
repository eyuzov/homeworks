# ******************************************************************************

#     Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

#     Пример:

# - 6 -> да
# - 7 -> да
# - 1 -> нет


# week_days = ["Monday", "Tuesday", "Wednesday",
#              "Thursday", "Friday", "Saturday", "Sunday"]

# day = int(input("Input number between 1 and 7 "))

# if (day > 7 or day < 1):
#     print("Wrong day of week ")
# elif (day == 6 or day == 7):
#     print(f"{week_days[day - 1]} is weekend")
# else:
#     print(f"{week_days[day - 1]} is workday")

# ******************************************************************************

#     Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка (или на какой оси она находится).

#     Пример:

# - x=34; y=-30 -> 4
# - x=2; y=4-> 1
# - x=-34; y=-30 -> 3


x = int(input("Input positive X coordinate "))
y = int(input("Input positive Y coordinate "))

if (x == 0):
    print("X is on x line")
elif (y == 0):
    print("Y is on y line")
elif (x > 0 and y > 0):
    print("Point is on first chapter")
elif (x < 0 and y > 0):
    print("Point is on second chapter")
elif (x < 0 and y < 0):
    print("Point is on third chapter")
elif (x > 0 and y < 0):
    print("Point is on fourth chapter")
else:
    print("Input correct coordinates")

# ******************************************************************************
