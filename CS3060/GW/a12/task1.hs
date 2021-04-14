
fibNextPair :: (Integer, Integer) -> (Integer, Integer)

fibNextPair (x, y) = (y, x + y)

fibNthPair :: Integer -> (Integer, Integer)

fibNthPair 1 = (1, 1)

fibNthPair n = fibNextPair (fibNthPair (n - 1))

takeFst :: (Integer, Integer) -> Integer

takeFst (x,y) = x

fib :: Integer -> Integer

fib = takeFst.fibNthPair


main :: IO ()
main= do
    print(fib 4)
    print(fib 6)
    