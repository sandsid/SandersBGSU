## Sidney Sanders, Amanda Collert, Quinci Drain, Emily Endlish


## Task 1: (4 points) 


### (a) Say there are four baseball teams (tiger, lion, panther, bear), and each pair of teams play two matches (home and away).  Say, as the game scheduler, you need the list of all of these matches. Test the following Prolog code to serve your purpose. 


?- match(Team1,Team2).
Team1 = tiger,
Team2 = lion ;
Team1 = tiger,
Team2 = panther ;
Team1 = tiger,
Team2 = bear ;
Team1 = lion,
Team2 = tiger ;
Team1 = lion,
Team2 = panther ;
Team1 = lion,
Team2 = bear ;
Team1 = panther,
Team2 = tiger ;
Team1 = panther,
Team2 = lion ;
Team1 = panther,
Team2 = bear ;
Team1 = bear,
Team2 = tiger ;
Team1 = bear,
Team2 = lion ;
Team1 = bear,
Team2 = panther ;
false.


### (b) Now say tournament rules change and you need to schedule ONLY one match between any two teams. Test the following Prolog code to serve your purpose. 

?- match(Team1,Team2).
Team1 = lion,
Team2 = tiger ;
Team1 = lion,
Team2 = panther ;
Team1 = panther,
Team2 = tiger ;
Team1 = bear,
Team2 = tiger ;
Team1 = bear,
Team2 = lion ;
Team1 = bear,
Team2 = panther ;
false.


### (c) Briefly explain why we get all 2-size permutations in version 1 and all 2-size combinations in version 2.

In version one, we get permutations because there are multiple elements used in different orders and matches in this version. In version two, we get combinations because each unique element is used once within the combinations.


### (d) Also, test the following code and show results. What extra does it do

?- writeToFile.
give a filename
|: "data.txt".

true.

When calling the writeToFile your prompted to enter the fileNmae. the program then write the matches to the file.



## Task 2: (3 points). Given a bunch of father-child relational facts of a family (over multiple generations), write a prolog rule (pathFromRootTo(X)) to print the path of X from the root (i.e. ggrandpa) of the family. Test the following code.

?- pathFromRootTo(little).
ggrandpa -- sr -- jr1 -- little
true .



### Task 3: (1.5 points). Given a list of items, write a prolog rule (different(List)) to check whether all items in the list are differrent. Test the following code, which is from lecture ppt3.


?- different([3,4,5,7,4,9] ).
false.

?- different([3,4,5,7,9] ).
true.

### Task 4: (1.5 points). Given a list of items, write a prolog rule (inDomain(List, ValList)) to check whether all items in List are within the values given in ValList. Test the following code, which is from lecture ppt3.



?- inDomain([3,4,5,7,4,9] , _).
true .

?- inDomain([1,2,3] , [1, 2,3,4,5,6]).
true .

?- inDomain([3,4,3,5,7],[3,4,5,7]).
true .

?- inDomain([1,2,3,4,5,6] , [1, 2,3]).
false.