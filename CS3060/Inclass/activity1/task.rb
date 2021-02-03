aFile = File.new("ticketOwner.txt", "r")
h = Hash.new(0)
i = 0

aFile.each do |line|
    words = line.split  # split func breaks line in words
    h[words[0]] = words[1] # storing “key => value” pairs in h
    i +=1
end

p "number of tickets: #{i}"  # i.e. n
 
# Now draw the lucky number between 1 and n

luckyNum = rand(i)+1
luckyPerson = h[luckyNum.to_s]

p luckyNum
p luckyPerson

  aFile.close
