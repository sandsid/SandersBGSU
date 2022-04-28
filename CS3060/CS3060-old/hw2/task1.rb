#imput would be "eggs", file is hardcoded into function



#############################
#Sidney Sanders    02-20-2020#
#############################

=begin
Task #1: Implement a myGrep program that takes a string x 
as input, and prints the lines of a ﬁle having any occurences
of string x anywhere in a line. The output should also include
the line numbers. Writing README carries 1 point.
=end

def itemToSearch (x)
    word = /x/
    aFile = File.new("sample.txt", "r")
    count = 0
    aFile.each_line { |line| 
        count +=1
        words = line.split 
        words.each { |w|
        if w =~ word
            puts "line #{count} contains #{x}"
        end
        }
    }
    aFile.close()

end

puts "Enter word to search: "
x = gets

itemToSearch(x)

