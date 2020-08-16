# class Sort_fnc():
#     def __init__(this):
#         this.is_sorted = False
#         this.count = 0
# from visuallize import result
import numpy as np


def bubblesort(x: list) -> list:
    end = 0
    result = []
    flag = True
    while flag:
        flag = False
        for i in range(len(x) - 1 - end):
            if x[i] > x[i+1]:
                x[i], x[i+1] = x[i+1], x[i]
                # print(x)
                result.append(x.copy())
                flag = True
        end += 1
    return result
