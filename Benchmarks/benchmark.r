fib <- function(n) {
   if (n <= 2) {
      return(1)
   } else {
      return(fib(n - 1) + fib(n - 2))
   }
}

ptm <- proc.time()

for (i in 1:40) {
   fib(i)
   print(i)
}

print(proc.time() - ptm)