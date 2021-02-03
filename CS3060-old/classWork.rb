
=begin 

def add
    4 +'four'
end
#abone runs with no error

=end


=begin
j = 0
a = ['100',100.0]
sum = 0
while j<2
 x=a[j].to_i
 sum=sum+x
 j=j+1
end
p sum

=end



=begin

#write out with new line
puts "Hello World!"

#prints the value of the expression
p "Hello World!"

#prints without a new line 
print "Hello World!"
=end



############
#using variable inside string
############


=begin
language = "Nick"
p "I love #{language}"

p "I love #{language + language}"

=end




############
#Control Structures
############

=begin

x = 4
#puts 'This appears to be false.' unless x==4
#puts 'This appears to be true. ' if x==4
unless x==4
    puts 'This appears to be flase.'
else
    puts 'This appears to be true. '
end 

#only boolion that are false are nil, and false
#that means 0 is true 

=end


###############

#Fiboacci function

###############

=begin

def fib n 
    if n==1
        return 1
    elsif n== 2
        return 1
    else
        return (fib(n-1)+fib(n-2))
    end
end

p fib 10

=end 



##############
#loops
##############

=begin

$i = 0
$num = 5
while $i < $num ; # or do or newline   
    puts("Inside the loop i = #$i" )   
    $i +=1
end

p "after first loop i= #{$i}"


#alternative way of creating the while loop
begin   
    puts("Inside the loop i = #$i" )   
    $i +=1
end while $i< 10 
# what will happen if we have 5 in place of 10
p "after second loop i= #{$i}"

=end



#####################
#Regular Expressions
#####################

=begin

#will wait for user to input and 'get' it

line = gets 

#represent ANY string that has 'hardware' or 'software' in 
#the string that contain what is within // the '|' acts as 
#a comma to add multipple words to the string search 

x =/hardware|software/

#the '~' operater is the matching operator that connects the 
#line and the regular expression searching for the x. And if
#the ~ finds a match it then print a match if any.

if line =~x
 puts "line matches with {x}"
end

=end

####################################
#Reading from Command Line: Example 
####################################

=begin

#must hit ctl + d to stop this program 
while line = gets
    print line
end

=end



#######################
#Reading from a file 
#######################



aFile = File.new("filename.txt", "r")
aFile.each{|line| p line} # print each line
aFile.rewind # check effect of this line on below
aFile.each_line{|line| puts line.dump} 
aFile.close



















