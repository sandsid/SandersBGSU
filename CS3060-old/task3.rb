aFile = File.new("givenfile.txt", "r")
  h = Hash.new(0)
  i = 0

  aFile.each do |line|
     words = line.split  # split func breaks line in words
     h[words[0]] = words[2] # storing things in hash h
     i +=1
   end

  p " number of lines: #{i}"
  p "price of desk is: #{h["desk"]}"


  costliestName = ""
  costliestAmount = 0 

  
  h.each do |item, price|
    if costliestAmount.to_i < price.to_i 
        costliestAmount = price
        costliestName = item
    end
  end

  p "Costliest item is #{costliestName}"


  

aFile.close 







