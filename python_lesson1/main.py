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


# x = float(input("Input positive X coordinate "))
# y = float(input("Input positive Y coordinate "))

# if (x == 0 and y == 0):
#     print("Point is on start")
# elif (y == 0):
#     print("Y is on y line")
# elif (x == 0):
#     print("X is on x line")
# elif (x > 0 and y > 0):
#     print(f"Point {x}:{y} is on first chapter")
# elif (x < 0 and y > 0):
#     print(f"Point {x}:{y} is on second chapter")
# elif (x < 0 and y < 0):
#     print(f"Point {x}:{y} is on third chapter")
# elif (x > 0 and y < 0):
#     print(f"Point {x}:{y} is on fourth chapter")
# else:
#     print("Input correct coordinates")

# ******************************************************************************


# Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).


# num = int(input("Input chapter number from 1 to 4 "))

# if (num == 1):
#     print(f"Coordinates are: x from 0 to positive infinity, y from 0 to positive infinity")
# elif (num == 2):
#     print(f"Coordinates are: x from 0 to negative infinity, y from 0 to positive infinity")
# elif (num == 3):
#     print(f"Coordinates are: x from 0 to negative infinity, y from 0 to negative infinity")
# elif (num == 4):
#     print(f"Coordinates are: x from 0 to positive infinity, y from 0 to negative infinity")
# else:
#     print("Input corret data")


# ******************************************************************************


#     Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

#     Пример:

# - A (3,6); B (2,1) -> 5,09
# - A (7,-5); B (1,-1) -> 7,21
# √(xb - xa)2 + (yb - ya)2

# from cmath import sqrt

# a_x = float(input("Input x coordinate A "))
# a_y = float(input("Input y coordinate A "))

# b_x = float(input("Input x coordinate B "))
# b_y = float(input("Input y coordinate B "))


# res = sqrt((b_x - a_x)**2 + (b_y - a_y)**2)
# print(res)
