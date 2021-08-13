class String 
    def size
        9
    end
end

class Integer 
    def size 
        8
    end
end
class Any
    def size 
        4
    end 
end 

x = ["4567", 142, 1462, "567"]
x.each do |i|
    puts "(#{i.class}, #{i.size})"
end





