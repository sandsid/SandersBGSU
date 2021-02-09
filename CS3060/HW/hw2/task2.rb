
def function(arr)


    #part a
    arr.each do |item|
        puts "#{item}:\t #{item.length}"
    end
    puts

    #part b
    arr.select { |item| 
        if item.length % 3 == 0
            puts "#{item} is multiple of 3"
        end
    }
    puts 

    #part c
    p arr
    arrB = arr.map {|item| item.upcase}
    p arrB
    puts 

    #part d

    totalLeng = arr.inject(0) {|total, item| total += item.length}
    puts "Total length: #{totalLeng}"
    puts

end


a = ["this", "is", "a", "random", "array", "of", "string", "'s", "yayyyy", "!"]

function(a)