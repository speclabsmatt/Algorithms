#!/bin/python
import sys

def big_sum(array):
    sum = 0
    for i in array:
        sum += i
        
    return sum

n = int(raw_input().strip())
arr = map(int,raw_input().strip().split(' '))

print(big_sum(arr))
