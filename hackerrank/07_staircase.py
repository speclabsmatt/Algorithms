#!/bin/python
import sys

def print_staircase(n):
    hashes = 1

    while hashes <= n:
        spaces = n - hashes
        print ' ' * spaces + '#' * hashes
        hashes += 1

n = int(raw_input().strip())
print_staircase(n)
