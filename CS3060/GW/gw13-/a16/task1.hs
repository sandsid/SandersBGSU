data Measurement = Meter Int | Centm Int  deriving (Show)


-- measurements are either in meter unit or in centimeter unit
-- Centm 1200, Meter 12

instance Eq Measurement where   
    (Meter x) == (Meter y) =  x == y   
    (Centm x) == (Centm y) =  x == y   
    (Meter x) == (Centm y) =  x*100 == y   
    (Centm y) == (Meter x) =  x*100 == y

x = Meter 10
y = Centm 1000
z = Meter 20
w = Centm 1200
u = Meter 30
a = Centm 3000
e = Meter 30
collc = [x,y,z,w,u,a,e]  

-- task a: Include the additional 2 measurements in the above list
-- done
-- task b: Write a function listVal which takes a measurement x and a 
    --collection of measurements l as input and returns the sub-list which are equal to x.
-- what is the input and output type of listVal? 
-- Input: Measurement and a Collection
-- Ouput: List

-- listVal  u collc => [ w, u]

listVal _ [] = []
listVal p (h:t)
  | p == h = h:(listVal  p  t)
  |otherwise = listVal  p  t
output1 = listVal  x  collc

-- task c: Now use Haskell filter to do the equivalent job of listVal.

output2 = filter (\b  -> b == e) collc

main :: IO ()
main= do
    print(output1)
    print(output2)