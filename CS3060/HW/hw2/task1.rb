#task1



def find()
    filename = ARGV[0]
    toFind = ARGV[1]

    aFile = File.new(filename, "r")
    count = 0
    aFile.each do  |line| 
        count += 1
        
        if (line.include? toFind)
            puts "Line #{count}:\t  #{line}"
        end
    end

    aFile.close();
end

find()

