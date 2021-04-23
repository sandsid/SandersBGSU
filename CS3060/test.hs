v1 = [2*n | n <- take 4 [1..], even (n)]
v2  = foldl   (\x y ->  x + y + 1)   2   [2*n | n <- take 4 [1..], even (n)]

--myFunc:: [Char] -> Bool

--myFunc x = if (length x == 5)  then True else False  

--myFunc    =
--finalList = filter myFunc ["abc", "prst", "acts", "st"]

myRange start step = start:(myRange (start + step) step)


main :: IO ()

main = do 
    print (v2)
