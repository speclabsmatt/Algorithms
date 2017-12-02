#!/bin/python
import sys

def print_scores(array1, array2):
    a_score = 0
    b_score = 0
    
    for i in range(0,len(array1)):
        if array1[i] > array2[i]:
            a_score += 1
        if array1[i] < array2[i]:
            b_score += 1
        
    print("%s %s" % (a_score, b_score))

a0,a1,a2 = raw_input().strip().split(' ')
a0,a1,a2 = [int(a0),int(a1),int(a2)]
b0,b1,b2 = raw_input().strip().split(' ')
b0,b1,b2 = [int(b0),int(b1),int(b2)]

print_scores([a0,a1,a2],[b0,b1,b2])
