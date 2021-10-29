from timeit import default_timer as timer

def fib(n):
    if n <= 2:
        return 1
    else:
        return fib(n - 1) + fib(n - 2)

start = timer()

for i in range(1, 41):
    fib(i)

print("First 40 Fibonnaci numbers in: ", (timer()-start) * 100, "milliseconds")