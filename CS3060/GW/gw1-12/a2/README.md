# Task 1: 
(4 points) Write a Ruby function foo which takes an array (whose name is arr) of integers (say i1, i2, …). In the body of foo, use the map (or collect) function to compute the remainder of each integer x (e.g., i1, i2, …) when x is divided by 3. Function foo should return the array of remainders.

## output 
> ruby task1.rb
[1, 0, 0, 2, 0, 1, 1, 0, 2]

# Task 2: 
(4 points) Implement a function genRandomMatrix to generate a matrix. The function genRandomMatrix should take one parameter n and return a matrix of size n x n. Use the given template below. Generate a variety of random matrices that are filled with random integers between 10 and 20. You should test your code for matrix sizes of 3x3 and 15x15. For visualization, you must also create one helper function printMatrix. The printMatrix(A) will print matrix A in a well-formatted fashion.

## output 
> ruby task2.rb
[14, 20, 14, 16, 10, 11, 14, 17, 14, 12, 20, 20, 17, 12, 15]
[11, 20, 15, 14, 19, 16, 14, 13, 10, 18, 19, 15, 11, 16, 17]
[11, 14, 13, 13, 16, 18, 17, 18, 10, 10, 12, 17, 11, 15, 18]
[16, 13, 14, 15, 14, 13, 10, 12, 17, 17, 18, 13, 12, 13, 12]
[17, 16, 16, 15, 15, 19, 15, 13, 14, 14, 19, 11, 16, 10, 12]
[19, 16, 14, 13, 20, 12, 10, 17, 16, 10, 17, 17, 20, 12, 13]
[12, 20, 18, 19, 17, 12, 15, 17, 16, 18, 19, 15, 19, 17, 17]
[11, 18, 12, 16, 13, 10, 11, 18, 19, 13, 12, 19, 15, 11, 13]
[11, 19, 20, 17, 16, 20, 13, 12, 11, 19, 11, 20, 14, 14, 18]
[15, 11, 20, 11, 17, 12, 14, 19, 11, 10, 15, 17, 16, 19, 14]

# Task 3: 
(4 points) Study the following code. This is about using code block.
def seriesUpTo(max) # this func receives a code block
  i = 1       
  while i <= max
    yield i*i    # see correspondence b/w i*i and x in block later.
    i = i + 2
  end
end

seriesUpTo(100) { |x| puts x } # this will print some series
puts "\n"

## Answer these questions: 
(a) how many times is the code block (in blue) executed in the above? Explain your answer. 
This code will print just 50 times because i is incrementing by 2.

(b) Edit the above code to print this series (i.e., only values): 12 + 1, 22 + 1, 32 + 1, …, 1002 + 1

def seriesUpTo(max) # this func receives a code block
  i = 1       
  while i <= max
    yield i*i + 1   # this line is changed to add 1
    i = i + 2
  end
end

