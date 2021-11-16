function fib(n) {
    if (n <= 2) {
        return 1;
    } else {
        return fib(n - 1) + fib(n - 2);
    }
}

var startTime = Date.now();

for (let i = 1; i < 41; i++) {
    fib(i);
}

console.log((Date.now() - startTime) / 1000);