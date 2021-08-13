
myfunc :: [Int] -> Int -> [Int]
myfunc  [ ] _ = [ ]
myfunc   (h:t)  x   
  | h == x  =  h : myfunc t  x   
  | otherwise = myfunc   t   x


main :: IO ()
main= do
    print(myfunc [2,7,12,7,19] 7)
    print(myfunc [23] 2)