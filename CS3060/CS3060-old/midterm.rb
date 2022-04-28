#q1






#q2

=begin

class String
    def myFunc
        self.reverse
    end
end
x = ["abcd", "efg", ""]
x.each do |i|
    y = i.myFunc + "q"
    puts y.reverse
end
=end


#q5
=begin

def foo(n)
    step1res = Array(1..n)
    step2res = step1res.map {|x| x = (x*5+3)}
    step3res = step2res.inject(:*) 
    puts step3res
end

result1 = foo(15)

result2 = foo(20)
=end


#q15
=begin

class Roman     

    def self.method_missing name, *args             

           roman = name.to_s                

           roman.gsub!("IV", "IIII")               

           roman.gsub!("IX", "VIIII")                                     

           (roman.count("I") +               

           roman.count("V") * 5 +                   

           roman.count("X") * 10)          

    end

end  

puts Roman.VIX

=end



#q16
reg1 = /x*y/

reg2 = /x+y/

word = "abcxxyyz"

result1 = "pqr" if(reg1 =~ word)

result2 = "uvw" if (reg2 =~ word)

puts result1
puts result2