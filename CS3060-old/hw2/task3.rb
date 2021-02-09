

=begin

Function3A calculates the Fibonacci Series (Fn = Fn−1 + Fn−2) iteratively. Calculate
all Fibonacci numbers (Fn) for n = 1 to 35 (if it takes long time, try until 32 or so). 
Function3B calculates the same Fibonacci Series but using the recursion technique. 
After implementing the above two functions, compare the computation time (for doing the above 
calculation) using Ruby’s benchmark library, and also compare lines of code between the two 
implementations. Writing README carries 1 point. Hint: if necessary, lecture slides can 
help you write the iterative version


=end


require 'benchmark'
a = (1..100).map { rand(-10..10) }
Benchmark.bm(7) do |b|  
    b.report("Sort")    { a.sort }  
    b.report("Sort by") { a.sort_by { |i| i*i } }
end
time1 = Benchmark.measure {

def fiba n
    if n == 1 
        return 1
    elsif n == 2
        return 1
    else 
        return (fiba(n-1) + fiba(n-2))
    end 
end 

 for n in 1..32
    puts fiba(n)
 end

}



time2 = Benchmark.measure {
def fibUpTo(max) 
    i1, i2 = 1, 1        
    while i1 <= max
        yield i1  
        i1, i2 = i2, i1+i2  
    end 
end

for n in 1..32
    fibUpTo(n) {|n| puts n}
end
}



puts "Computation time for fib function 1: #{time1.real}"
puts "Computation time for fib function 2: #{time2.real}"

