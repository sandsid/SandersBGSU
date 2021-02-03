#read from a file

aFile = File.new("filename", "r")
aFile.each{|x| p x} # print each line

# aFile.rewind # check effect of this line on below
# aFile.each_line{|line| puts line.dump}

aFile.close


#Write to a file

aFile = File.new("filename", "w")
aFile.write("abcd \n")
aFile.close


=begin
    
Code block
•A code block is a function without a name
•You can pass it as a parameter to another function
•Code block is basically a chunk of code between braces 
    or between do and end.
Examples:
1. {puts "Hi"}
2. do
        puts "Hello"
        puts "Hello"
    end

=end

animals = ["human", "tiger", "bird"]

animals.each {|x| puts x}

def animal_does_what

    yield("human", "talk")
    yield("dog", "bark")
    
end
    
# below we call the func and pass a code block
    
animal_ does_what {|x, y| puts "#{x} makes sound #{y}"}
    
#What if the code block expects extra parameters?
def animal_does_what
yield("human", "talk")
yield("dog", "bark")
end

animal_does_what {|x, y, z| puts"#{x} makes sound like #{y} and #{z.class}"}
#Run the above code and check that z is nil


#Array and Hash
a = ['human', 'tiger', 'dog']
a[0] # gives us ‘human’
a[2] # gives us ‘dog’
sound = {'human' => 'talk', 'dog' => 'bark', 'tiger' => 'roar'}
p sound['dog']

=begin
How to split a line in words?

You can use String class’s split function
"abc's def ghi".split #=> [”abc's", ”def", ”ghi"]
You can also String class’s scan function
"abc def ghi".scan(/\w+/) #=> [“abc”, “def”, “ghi”]
def ghi".scan(/[\w’]+/) #=> [“ab’c”, “def”, “ghi”]
=end

#Range
#.5) is an example of Range. See code below.

for i in 0..5
    puts "Value of local variable is #{i}"
end

(0..5).each do |i|
    puts "Value of local variable is #{i}"
end


#Regular Expression

line = gets
x = /hardware|software/
if line =~ x
    puts "line includes pattern #{x}"
end


