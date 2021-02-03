priceMap = {"computer" => 400, 
    "board" => 80, 
    "pen" => 2,
    "chair" => 60,
    "desk"=> 50,
    "eraser" => 3,
    "light" => 40
              }
    

chairPrice = priceMap["chair"]
deskPrice = priceMap["desk"]

total = chairPrice + deskPrice
p "total price of chair and desk is #{total}"


