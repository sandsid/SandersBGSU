


mylist = [1, 3 .. 9]

foo m list = map(\y -> y^m)  list 

f  x  = foldl (+) 0 (foo x mylist) 


main :: IO ()
main= do
    print (f 2)