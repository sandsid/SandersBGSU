## Task 1: (3 points) 
Sort this hash as required. Submit the test results in a readme.

> ruby task1.rb
{"13"=>"sd roy", "22"=>"ed nelson", "12"=>"adam smith"}
[["12", "adam smith"], ["22", "ed nelson"], ["13", "sd roy"]]

## Task 2: (3 points) 
(a) Use the find_all or select function to filter out strings from a1, which start with character “c” 
(b) Use inject function to compute the total length of all strings in array1.

> ruby task2.rb
["aadfg", "kjhg"]
14

## Task 3: (3 points) 
Run the following code. What is the outcome? Give a brief explanation. Submit the test results in a readme.

> ruby task3.rb
7

The outcome is 7. The function traverses the list only to find the first element that satisfies the statement making it return once it hits 7 and does not continue onto the rest of the list. 


## Task 4: (3 points) 
Why is Animal an abstract class? We need a precise answer. 

It's an abtract clas because there is no set instance of animal or sound. The class itself can be assigned and manipulated in many ways. There can be many instances derived from the class such as human or dog, and many more can be created like cat or goat. An abstract method like animal has declarations with no implimentations within. 


Traverse the list, and on each animal invoke the makes_sound function. Submit the test results in a readme.

> ruby task4.rb
"talk"
"bark"
"bark"
"talk"
"bark"
"bark"
"talk"
"talk"
"bark"
"bark"
"talk"