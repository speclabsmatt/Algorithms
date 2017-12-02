#!/bin/python
import sys

def round_float(n, arr):
    neg_count = 0.0
    pos_count = 0.0
    zer_count = 0.0

    for i in arr:
        if i > 0:
            pos_count += 1.0
        elif i < 0:
            neg_count += 1.0
        else:
            zer_count += 1.0
            
    n = float(n)
    print round((pos_count / n), 6)
    print round((neg_count / n), 6)
    print round((zer_count / n), 6)

n = int(raw_input().strip())
arr = map(int,raw_input().strip().split(' '))

round_float(n,arr)
