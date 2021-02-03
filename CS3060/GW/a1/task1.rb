
price = [400, 80, 2 ,60 ,50 ,3, 40]    # fill up the blanks

i = 0
sum = 0
while i < 7 
  sum += price[i]
  i += 1
end
avg =  sum/i
p "average price is #{avg}"


price = [400, 80, 2 ,60 ,50 ,3, 40]    # fill it up

i = 0
sum = 0
until i == 7 
  sum += price[i]
  i += 1
end
avg =  sum/i
p "average price is #{avg}"
