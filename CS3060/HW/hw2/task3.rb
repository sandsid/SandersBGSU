
require 'benchmark'


time = Benchmark.measure do 
    def fibA(num)
        item1 = 0 
        item2 = 1
        temp = 0

        num.times do 
            temp = item1
            item1 = item2
            item2 = temp + item1 
        end
        return item1
    end

    n = 35
    
    for x in 1 .. n
       fibA(n) 
    end
end

puts "Time for fibA:\t #{time.real}"

time2 = Benchmark.measure { 

    def fibB(n)
        if n<=2
            return 1
        else 
            return(fibB(n-1) + fibB(n-2))
        end
    end

    n = 35

    for x in 1 .. n
        fibB(n) 
     end

    }

puts "Time for fibB:\t #{time2.real}"


