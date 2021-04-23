aFile = File.new("data.txt", "r")
  h = Hash.new(0)
  i = 0

  aFile.each do |line|
     words = line.split  # split func breaks line in words
     h[words[0]] = words[2].to_i # storing important things in hash h
     i +=1
   end

  p "number of lines: #{i}"
  p "price of desk is: #{h["desk"]}"

  # Below write code to find the costliest item

   #print h.max_by()
   #print h.max_by{ |object, price| price }
   h = h.sort_by{ |object, price| price }.reverse

   p " Costliest item in list:  #{h[0][0]}"
   p "Second Costliest item in list:  #{h[1][0]}"

aFile.close()
