#!/bin/python
import sys

def diagonal_difference(n, array):
    j = 0
    first = 0
    for i in range(0, n):
        j = i
        first += array[i][j]

    second = 0
    j = 0
    for i in range(n-1, -1, -1):
        second += array[i][j]
        j += 1

    return abs(first - second)

n = int(raw_input().strip())
a = []
for a_i in xrange(n):
    a_temp = map(int,raw_input().strip().split(' '))
    a.append(a_temp)

print diagonal_difference(n, a)
