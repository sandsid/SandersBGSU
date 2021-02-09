## Task #1: (7 points) 
>Write a program that takes a string x and a filename f as input, and checks whether  
string x appears in file f . Your program needs to print each line (in file f ) that contains string x. Your  
program should also print the line numbers of the matching lines.   

### sample input/output
```
> ruby task1.rb data.txt dog
Line 1:   “Scram!” shouted the stall managers, flailing their arms around in front the small dog. It whimpered 
Line 3:   turned the corner, the dog pulled out a piece of juicy meat from behind him. Success! He thought, biting
Line 4:   into the middle, savouring the taste. He heard a scurry of footsteps behind him, and the dog gave a low
Line 21:          to her, unaware that she was there. The dog ran manically onto the road, determined to get her to safety.
Line 30:          think about was how her parents would react to her being saved by the dog that they thought was a mangy
Line 40:          faces, and didn't know the result of their talking. "Darling, we know you have wanted this dog for ages"
Line 50:          “Scram!” shouted the stall managers, flailing their arms around in front the small dog. It whimpered
Line 52:          the corner, the dog pulled out a piece of juicy meat from behind him. Success! He thought, biting into the
Line 53:          middle, savouring the taste. He heard a scurry of footsteps behind him, and the dog gave a low growl.
Line 58:          "He is darling" replied her parents, kneeling down to give the dog a pat. Jack leapt up at the girl,
Line 62:          squealed Lucy, wrapping her arms around the dog's neck. As they walked back home, Lucy thought of all the
Line 63:          good things that had happened to her over the past few weeks. Getting saved, having a new dog, she could
```

##  Task #2: (8 points) 
>Write a function that takes an array A of strings as the input and does the following:  
(a) Uses each method to print the length of each element of A,   
(b) Uses select method to find all the strings (inA) whose lengths are multiple of 3,   
(c) Uses map method to build a new array with all-caps-version of the strings of A, and   
(d) Uses inject method to find the sum of the length of all strings of A.   
To test the function, build an array A of 10 random strings, and pass A into the function as a parameter.  

### sample input/output
```
> ruby task2.rb
this:    4
is:      2
a:       1
random:  6
array:   5
of:      2
string:  6
's:      2
yayyyy:  6
!:       1

random is multiple of 3
string is multiple of 3
yayyyy is multiple of 3

["this", "is", "a", "random", "array", "of", "string", "'s", "yayyyy", "!"]
["THIS", "IS", "A", "RANDOM", "ARRAY", "OF", "STRING", "'S", "YAYYYY", "!"]

Total length: 35
```

##  Task #3:. (10 points)
> calculates the Fibonacci Series (Fn = Fn−1 + Fn−2) iteratively. Calculate  
all Fibonacci numbers (Fn) for n = 1 to 35. Function3B calculates the same Fibonacci Series but using  
the recursion technique. After implementing the above two functions, compare the computation time  
(for doing the above calculation) using Ruby’s benchmark library.   

### sample input/output
```
> ruby task3.rb
Time for fibA:   5.780009087175131e-05
Time for fibB:   18.700440300046466
```

##  Task #4: (13 points)
>The Tree class presented in the textbook (Day 2) chapter is interesting, but it does not allow you   
to specify a new tree with a clean user interface.   
(a) Update the constructor and all other methods to accomodate the creation of a tree using a Hash.  
The initializer should accept a nested structure of Hashes. You should be able to specify a tree as below.  
To test your functionality, you should traverse (by calling visit_all method on the tree i.e. root   
node) this entire tree and print out the node names.   
(b) Write another method (like visit_all) which counts the total number of nodes in the tree.  

### sample input/output
```
> ruby task4.rb
ggrandparent
grandparent1
grandparent2
grandparent1
parent1
parent2
parent1
child1
child1
parent2
child2
child3
child2
child3
grandparent2
parent3
parent4
parent3
child4
child4
parent4
child5
child6
child5
child6
Total nodes:     13
```

##  Task #5: (12 points)
>In this task, your code creates a random list of 100 shape objects, then traverses the  
list from start to end, and computes the total area of the shape objects. First you need to implement the  
class hierarchy diagram of the shape types, which is attached. Shape is an abstract class which has only a  
"color" attribute whereas Circle class and Square class are concrete children of Shape class, and they have  
more attributes and constructors. Note that you do not know beforehand the order of the shape objects  
(i.e. Circles and Squares) created in the random list, e.g., you do not know beforehand whether the 1st item  
is Circle or Square.  

### sample input/output
```
> ruby task5.rb
Total Area:      560.315
```
