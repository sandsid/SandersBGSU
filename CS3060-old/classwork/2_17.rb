#code blocks explained

=begin

def foo(&block)
    block.call 
    puts "abc"
end

def bar(&block)
    block.call "def"
end


#foo {|x| puts x} #given a parameter x, print it



foo {|x| puts "xyz"}



=end


#classes
#starts with a capitol C
#instance is an object 
#variable is called an instance variable or a field means
##some attributes of the object(not the class)
#methods are lowercase


=begin
class Song
    def initialize(name, artist, duration)
        @name = name #single @ means its an object variable
        @artist = artist
        @duration = duration
    end
    def to_s
        "name = #{@name}-- artist = #{@artist}-- duration = #{@duration}"
    end
    def self.num
        @@num #means thats a class variable 
    end
    attr_reader:name, :artist, :duration
end


aSong = Song.new("Loved by you", "KIRBY", 000)
bSong = Song.new("When the party is over", "Billie Eilish", 000)

puts aSong.to_s

puts bSong.to_s

=end

=begin

class Tree
    attr_accessor :children, :node_name
    def initialize(name, children=[])
        @children = children
        @node_name = name
    end
    def visit_all(&block)
        visit &block : children.each {|c| c.visit_all.block} 
    end
    def visit(&block)
        block.call self
    end
end

=end



=begin

class Node
    attr_accessor :next, :name

    def initialize(name, nxt=nil)
        @name= name
        @next = nxt
    end

    def visit_all(&block)
        visit(&block)
        if(self.next != nil)
            self.next.visit_all(&block)
        end
    end

    def visit (&block)
        block.call self
    end
end

r = Node.new("c")
q = Node.new("b", r)
p = Node.new("a", q)
p.visit_all{|x| puts x.name}



class Node     
    attr_accessor :next, :name     
    def initialize(names)         
        s = names.size         
        if(s > 0)          
            @name = names[0]            
            if(s > 1)              
                @next = Node.new(names[1..(s-1)])            
            else #  s = 1, i.e. there is only one node, so @next should be nil              
                @next = nil             
            end          
        end      
    end      
    def visit_all(&block)         
        visit(&block)         
        if(self.next != nil)          
            self.next.visit_all(&block)         
        end      
    end      
    def visit(&block)         
        block.call self     
    end 
end

a = Node.new(["a", "b", "c"])
a.visit_all{|x| puts x.name}

=end




#class inheritence 

=begin

class Animal 
    attr_accessor :age, :sound
    def initialize(age)
        @age = age
    end
    
    def makes_sound 
        sound
    end
end

class Human < Animal
    attr_accessor :legs
    def initialize(age)
        super 
        @legs = 2
        @sound = "talk"
    end
end

class Dog < Animal
    attr_accessor :legs

    def initialize(age)
        super
        @legs = 4
        @sound = "bark"
    end
end

#implement a random list of human and dog objects
#it will have 5 objects in total

list =[]
for i in 0...5
    toss = rand(2)
    if toss == 0
        h = Human.new(50*rand)
        list.push(h)
    else
        d = Dog.new(5*rand)
        list.push(d)
    end
end


#traverse the list and computer the average age of all the animals 

list.each{|item| p item.makes_sound}
list.each{|item| p item.age}
sum = list.inject(0){|sum, item| sum + item.age}
p "average age = #{(sum + 0.0)/list.size}"

=end

require 'benchmark'
a = (1..100).map { rand(-10..10) }
Benchmark.bm(7) do |b|  
    b.report("Sort")    { a.sort }  
    b.report("Sort by") { a.sort_by { |i| i*i } }
end