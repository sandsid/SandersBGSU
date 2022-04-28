=begin
    
In this task, your code creates a random list of 100 shape objects, then traverses the list from 
start to end, and computes the total area of the shape objects. First you need to implement the 
class hierarchy diagram of the shape types, which is attached. 
    
Shape is an abstract class which has only a "color” attribute whereas Circle class and Rectangle class are 
concrete children of Shape class, and they have more attributes and constructors. 

Note that you do not know beforehand the order of the shape objects (i.e. Circles and Rectangles) created 
in the random list, e.g. you do not know beforehand whether the 1st item is Circle or Rectangle. 
    
Writing README carries 1 point. 
Note. When you traverse the list to calculate the total area, you call 
the area() function of each shape object (without considering if it is Rectangle or 
Circle). 

That means, you will use the concept to f polymorphism. Hint: While building the list of 
shape objects, use rand(2) to generate a random number 0 or 1; if 0, then you may add a Rectangle 
object, else add a Circle object to the list.

=end

class Shape 
    attr_accessor :color, :area
    #constructor
    def initialize
        @color = "blue" 
    end

    def initialize(color)
        @color = color
    end

    def has_area
        area
    end

end

class Circle < Shape
    attr_accessor :color, :radius

    def initialize
        super
        @radius = 2.0
        @area = 3.14*radius*radius
    end

    def initialize(color, radius)
        super(color)
        @radius =radius
        @area = 3.14*radius*radius
    end

end

class Rectangle < Shape
    attr_accessor :color, :width, :len

    def initialize
        super
        @width = 1.0
        @len = 1.0
        @area = len*width
    end

    def initialize(color, width, len)
        super(color)
        @width = width
        @len   = len
        @area = len*width
    end

end


#testing the code

s = []

for i in 0..100
    num = rand(2)
    if num == 0
        c = Circle.new("Purple", 3.0)
        s.push(c)
    else
        r = Rectangle.new("Grey", 4.0, 2.0)
        s.push(r)
    end

end 
puts

totalArea = s.inject(0){|totalArea, item| totalArea + item.has_area}
totalArea.round(2)

puts "Total area: #{totalArea}"
    


    
 





