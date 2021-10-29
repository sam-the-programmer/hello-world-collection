package main

import (
	"fmt"
	"time"
)

func fib(n int) int {
	if n <= 2 {
		return 2
	} else {
		return fib(n-1) + fib(n-2)
	}
}

func main() {
	start := time.Now()
	for i := 0; i < 40; i++ {
		fib(i)
	}
	fmt.Println("First 40 Fibonnaci numbers in:", time.Since(start).Milliseconds(), "milliseconds.")
}
