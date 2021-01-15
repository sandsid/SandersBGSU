#Loops

i = 0
num = 5
while i < num ; 
      # instead of ‘;’ we can use ‘do’ or newline   
    puts("Inside the loop i = #{i}" )   
    i +=1
    end
p "after first loop i= #{i}"

#also 

begin
    puts("Inside the loop i = #{i}" )
    i +=1
end while i < 10
# what will happen if we have 5 in place of 10
p "after second loop i= #{i}"

#also 

i = 0
num = 5
until i > num do
    puts("Inside the loop i = #{i}" )
    i +=1;
end

