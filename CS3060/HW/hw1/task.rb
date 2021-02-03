
# completed
def function1
    # Complete this function
    aFile = File.new("savedText.txt", "w")

    #get user response 
    puts "Enter a four line response:   "
    line1 = gets
    line2 = gets
    line3 = gets
    line4 = gets

    #Write the sentences saved to the file
    aFile.write(line1)
    aFile.write(line2)
    aFile.write(line3)
    aFile.write(line4)

    aFile.close()

    #read words from the file
    lines = File.readlines("savedText.txt") 
    line_count = lines.size
    words = lines.join 
    word_count = words.split.length 
    puts "Number of Words:\t#{word_count}"
end

#completed
def function2
    # Complete this function
    print "Enter the name of a file: "
    fname = gets 
    fname = fname.strip

    x = /Java|java|Haskell|haskell/
    y = /ruby|Ruby|Python|python/

    aFile = File.new("#{fname}", "r") 
    
    #when traversing the file this loop will assign a number to filetype 
    aFile.each{ |z| 
        if z =~ x
            puts "The file is not important."
        elsif z =~ y
            puts "The file is superb!"
        else
            puts "The file is uninteresting."
        end
    }
end

#completed
def function3
    # Complete this function
    x=2
    while x < 12
        y = 1
        z = x 
        while y < x
            z = z * x 
            y+=1
        end
        puts "The n-th power of integer #{x} is #{z}"
        x+=1
    end
end

#completed
def function4
    # Complete this function
    num = false 
    x = 0

    #input checking that between 50-100
    loop do
        print "Pick number x between 50 and 100: "
        x = gets.chomp.to_i
        if x <101 and x>49
            num = true
        end

        if num == true
            break
        end
    end

    ary = Array.new(x)

    #fill array with random numbers
    i=1
    while i <x
        ary[i] = rand(2)
        i+=1
    end 

    head = 0
    tail = 0 
    
    #count which were heads/tails
    ary.each do |item|
        if item == 0
            head+=1
        else
            tail+=1
        end

    end
    
    
    #finding ratio
    puts "Heads:\t#{head}"
    puts "Tails:\t#{tail}"

    ratio = (head.to_f/tail.to_f)
    puts "Ratio of Heads<->Tails:\t#{ratio}"
end

def function5
    # Complete this function
    aFile = File.new("story1.txt", "r")
    words = []
    freq = Hash.new(0)   
    #complete the hash for story 1
    aFile.each do |line|
        words = line.split
        words.each do |loneWord|
            if freq.has_key?(loneWord)
                freq[loneWord]= freq[loneWord]+1
            else
                freq[loneWord] = 1
            end
        end
    end
    aFile.close()

    puts "Number of unique words in story 1:\t #{freq.length}"

    #do the hash for story 2
    bFile = File.new("story2.txt", "r")
    wordsB = []
    freqB = Hash.new(0)
    bFile.each do |lineB|
        wordsB = lineB.split
        wordsB.each do |loneWordB|
            if freqB.has_key?(loneWordB)
                freqB[loneWordB] = freqB[loneWordB] + 1
            else
                freqB[loneWordB] = 1
            end
        end
    end
   
    puts "Number of unique words in story 2:\t #{freqB.length}"

    #combine the list
    freqB.each_key do |key|
        if freq.has_key?(key)
            freq[key] = freq[key] +freqB[key]
        else 
            freq[key] = freqB[key]
        end
    end

    #merging using each
    puts "Number of combined unique words:\t#{freq.length}"

    frequent = freq.sort_by {|k,v| [-v]}
    #p frequent.first(3).to_h #testing first three items in hash
    thirdK = frequent.to_a[2][0]
    thirdV = frequent.to_a[2][1]
    puts "Third frequent word was (  #{thirdK}  ) and had #{thirdV} occurances."


end

# Now call the functions as the following.
#function1 #finished
#function2 #finished
function3 #finsihed
#function4 #finsished
#function5 #finished
