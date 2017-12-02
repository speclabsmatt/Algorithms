#!/bin/python
import sys

def sum_array(array):
    sum = 0
    for i in array:
        sum += i
    return sum

n = int(raw_input().strip())
arr = map(int,raw_input().strip().split(' '))

print(sum_array(arr))
