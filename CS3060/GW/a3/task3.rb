class Array   
    def find    
         for i in 0...size       
            item = self[i]       
            return item if yield(item)     
        end    
         return nil   
    end 
end 
a = [1, 3, 5, 7, 9]
b = a.find {|v| v*2 > 10 }
p   b 
