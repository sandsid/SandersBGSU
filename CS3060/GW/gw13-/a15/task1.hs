import Data.List
data Genre = Fiction | NonFiction deriving (Show, Eq)
data Cover = Hard | Paperback | Ebook deriving (Show, Eq) 
type Book = (Genre, Cover, Double) 
          -- 3rd attribute represents book-price, which is a Double
type Collection = [Book] -- this represents a collection of books

price :: Book -> Double 
price (g,cov,p) = p 
 
totalVal :: Collection -> Double 
totalVal c = sum (map price c)  -- think about how this code works

book1 = (Fiction, Hard, 10.2)
book2 = (NonFiction, Paperback, 10) 
book3 = (Fiction, Ebook,8.5)
book4 = (NonFiction, Paperback, 20.0)
book5 = (Fiction, Ebook, 60.50)

        -- here create 2 additional books with random attributes
        -- so, now there are 5 books in total

collc = [book1,book2,book3,book4,book5] 
        -- include the additional 2 books in the above list

--task a (1 point): run the code below and check value of output1. 

output1 = totalVal collc 

-- What does output1 represent? 
-- Represent the total price of the collection combined

--task b (2 point): write a function foo which takes two books as input and foo returns the higher-price book.

-- what is the input and output type of foo? 
-- input: two Books, output: Book

foo :: Book -> Book -> Book -- fill in the blank

foo x y = if (price x > price y) then x else y    -- fill in the blank

output2 = foo book1 book2    

-- What does output2 represent?
-- Represents the higher priced book between the two given
-- (Fiction,Hard,10.2)

-- task c: write a function numFiction which takes a collection of books as input and returns the number of Fiction books present in the collection. A template is given below. Complete it.

-- what is the input and output type of numFiction? 
-- input: Collection  Output: Integer

numFiction  [] = 0
numFiction ((Fiction,_,_):t ) = 1 + numFiction t
numFiction ((_,_,_):t ) = numFiction t

output3 = numFiction collc

-- What does output3 represent?
-- Represents the total number of fiction books within the colection



-- task d: write a function listFiction which takes a collection of books as input and returns the list of 
    --Fiction books present in the collection.


-- what is the input and output type of listFiction? 
--input: Collection Output: List

listFiction  [] = []
listFiction ((g,c,p):t)
  | g == Fiction = (g,c,p) : listFiction t
  | otherwise = listFiction t

output4 = listFiction collc

-- What does output4 represent?
-- Represents a list filled with fiction only books


-- task e: write a function isFiction which takes a book as input ---and returns True if the book is a 
    --Fiction and False otherwise. --
    --Then, use Haskell filter to do the equivalent job of listFiction.

isFiction  (g,c,p)
    | g == Fiction = True
    | otherwise = False
    
output5 = filter isFiction collc

-- What does output5 represent?
-- Represents a list filled with fiction books only


main :: IO ()
main= do
    print(output1)
    print(output2)
    print(output3)
    print(output4)
    print(output5)
    