

class Shape 
    attr_accessor :color

    def initialize()
        @color = "red"
    end
end

class Square < Shape
    attr_accessor :color, :side

    def initialize(side)
         
        @side = side
    end
    def area
        @side**2
    end
end

class Circle < Shape
    attr_accessor :color, :radius

    def initialize(radius)
        
        @radius = radius
    end

    def area
        @radius**2 * 3.14
    end
end

shapes = []

for x in 0..100
    n = rand(2)
    if n == 0
        shapes.push(Square.new(2.0))
    else 
        shapes.push(Circle.new(1.5))
    end 
end

totalArea = shapes.inject(0){|total, item| total + item.area}

puts "Total Area:\t #{totalArea}"



