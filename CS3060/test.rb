def foo(n)

    step1res =(1..n) 
    
    step2res = step1res.map {|x|    (x*5) + (x**3)   } 
    
    step3res = step2res.inject(1){|s, item|  s +item  }
    
end


result1 = foo(17)
result2 = foo(19) 
p result1
p result2
