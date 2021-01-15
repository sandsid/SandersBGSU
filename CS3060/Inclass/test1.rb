
# 1/14/2021

=begin
#this code will error because you can not add two different data types
#this way

def add
    5 + 'five'
end
add 

=end 

#prints to terminal the data type(class)

i = 0
num = 5 
p num.class

num = "abc"
p num.class


=begin

The array arr has different types of elements (i.e. string and floating point),
but they can be considered as Integer as they (i.e. string and floating point 
class) support “to_i” method. This concept is known as “duck typing”.
    
=end


j = 0
arr = ['100', 100.0]
sum = 0w
hile j < 2  
    x = arr[j].to_i
    sum = sum + x  
j = j + 1
end
p sum


#How do I write output?

puts "Hello, World!"
p  "Hello, World!"
print "Hello, World!"

#How do I use a variable inside a string? This is called String Interpolation.
language = "Ruby"
puts "hello, #{language}" 



#Control Structures 

x = 4 
puts 'This appears to be false.' unless x == 4
puts 'This appears to be true.' if x == 4
if x == 4 
     puts 'This appears to be true. '
end


#also 

x = 4 
unless x == 4 
     puts 'This appears to be false.'
else     
    puts 'This appears to be true.'
end
puts 'This appears to be false.' if not true
puts 'This appears to be false.' if !true

#also

x = 1
x = x + 1 while x < 10
y = 100
y = y - 1 until y == 1
z = 1
while z < 10    
    z = z + 1    
    puts z
end

=begin

Caution!
Everything but nil and false evaluate to true.

Run this: print "ok" if 0
evaluates to true.
This is different from what your experienced in C++

=end 




