#Example 1: Fibonacci function


def fib n
    if n == 1
        return 1
    elsif n == 2
        return 1
    else
        return (fib(n-1) + fib(n-2))
    end
end
p fib 10


