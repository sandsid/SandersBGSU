class Animal # this is an abstract class
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
    def initialize (age)
            super
            @legs = 2
            @sound = "talk"
    end
end

class Dog < Animal
    attr_accessor :legs
    def initialize (age)
            super
            @legs = 4
            @sound = "bark"
    end
end

list = []
for i in 0..10
        toss = rand(2)
        if toss == 0
                h = Human.new(20)
                list.push(h)
        else
                d = Dog.new(10)
                list.push(d)
        end
end

list.each{|item| p item.makes_sound}