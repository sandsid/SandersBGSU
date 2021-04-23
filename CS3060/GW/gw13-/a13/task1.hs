

myFunc :: [Int] -> Int
myFunc [] = 1
myFunc (h:t) = 2 * h * (myFunc t)

foo :: [Char] -> Int
foo [] = 0
foo (h:t) = 1 + (foo t)

players = ["x", "y", "z"]
matches = [(m, n) | m <- players, n <- players, m < n]
perm = [(m, n) | m <- letters, n <- letters, m /= n]
letters = ["a","b","c"]
main :: IO ()
main= do
    print(matches)
    print(perm)
    




    