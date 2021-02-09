=begin
    
Write a function that takes an array A of integers as the input and does the following: 
(a) Uses each method to print the cube of each element of A, 
(b) Uses each_slice method to print the elementswhile printing 3 elements at a time, 
(c) Uses select method to find the integers (in A) which are multipleof 5, 
(d) Uses map method to build a new array of cubes of the elements of A, and 
(e) Uses inject methodto find the product of all elements of A. 
To test the function, generate an array A of 50 random integers between 10 and 100, 
and pass into the function as a parameter.Writing README carries 1 point.


=end


    
def foo(a)

    #(a)
    a.each do |x| 
        puts "Cube of #{x} = #{x*x*x}"
    end

    #(b)
    a.each_slice(3){|x| p x}

    #(c)
    a.select { |x|  
        if x%5 == 0
            puts "#{x} is a multiple of 5."
        end
    }
    #(d)
    b = a.map{|x| puts x*x*x}

    #(e)
    result = a.inject(:*)
    p result

end

A = Array.new(50)
i = 0
while i < 50
    A[i] = rand(10..100)
    i+=1
end

foo(A)



