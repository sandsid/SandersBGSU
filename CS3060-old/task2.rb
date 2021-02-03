


priceMap = {"computer" =>400, "board" => 80,"pen" =>2,"chair"=>60,"desk"=>50,"eraser"=>3,"light"=>40 }


chairPrice = priceMap["chair"]
deskPrice = priceMap["desk"]

total = chairPrice + deskPrice

p "total price of chair and desk is #{total}"


i = 0
sum = 0
while i<7
    sum += priceMap.to_a[i][1]
    i += 1
end

avg = sum / 7
p "average of item price is #{avg}"


