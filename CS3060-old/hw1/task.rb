

def function1
    # Complete this function

    aFile = File.new("function1.txt", "w")

    #get user response 
    puts "Enter a two line response:   "
    sentence1 = gets
    sentence2 = gets

    #Write the sentences saved to the file
    File.write(sentence1)
    File.write(sentence2)

    aFile.close()
   
end


def function2
    # Complete this function

    print "Enter the name of a file: "
    fname = gets 
    fname = fname.strip

    x = /Java|java|Python|python/
    y = /ruby|Ruby/

    aFile = File.new("#{fname}", "r") 
    
    #when traversing the file this loop will assign a number to filetype 
    aFile.each{ |z| 
        if z =~ x
            puts "The file is interesting."
        elsif z =~ y
            puts "The file is extraordinary!"
        else
            puts "The file is so so."
        end

    }

    aFile.close()
   
end


def function3
    # Complete this function
    # Finished

    x=0
    loop do
        x+=1
        p "The square of integer #{x} is #{x*x}"
        if x==100
            break
        end
    end

   
end


def function4
    # Complete this function
    # Finsihed 

    num = false 
    x = 0
    loop do

        print "Pick number x between 10 and 100: "
        x = gets.chomp.to_i
        if x <101 and x>9
            num = true
        end

        if num == true
            break
        end
    end

    ary = Array.new(x)

    
    i=1
    while i <x
        ary[i] = rand(2)
        i+=1
    end 

    head = 0
    tail = 0 
    
    ary.each do |item|
        if item == 0
            head+=1
        else
            tail+=1
        end

    end
    
    puts "amount of heads #{head}"
    puts "amount of tails #{tail}"


end


def function5
    # Complete this function
    
    file = File.new("story.txt", "r")
    #words = []
    freq = Hash.new   
    file.each_line { |line|
        words = line.split
        words.each { |wrds|
            if freq.has_key?(wrds)
                freq[wrds] = freq[wrds] + 1
            else 
                freq[wrds] = 1
            end
        }
    }

    #sorting the hash to find the most used words
    freq.sort{|a,b| a[1]<=>b[1]}
    puts freq.length
    freqWord3 = freqWord3
    freqWord3 = freqWord3-3 

    puts freq[freqWord3]

    puts "The third most frequent word has #{freqWord3} occyrrences"



end


# Now call the functions as the following.
#function1 #Finihsed
function2 #Finished
#function3 #Finished
function4 #Finished
#function5 #Finished
