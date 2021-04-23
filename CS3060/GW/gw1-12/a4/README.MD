## Group Activity 4; CS 3060

>Names of students in your group:    
Sidney Sanders, Amanda Collert, Quinci Drain, Madeline Reeves, Emily Endlish  


### output:
```

?- isGrandParent(What).  
What = grandma .  


?- grandParent(What, girl1).  
false.  

?- grandParent(What, grandma).  
What = boy1 ;  
What = girl1 ;  
What = boy2 ;  
What = boy3 ;  
What = girl2 ;  
What = boy3 ;  
false.  
  
?- nephewUncle(What, man1).    
What = boy2 ;  
What = boy3 ;  
false.  
  
?- hasDescendant(man1).   
true .  
   
?- match(tiger, lion).  
true.  

?- match(tiger, What).
What = lion ;
What = panther.

?- match(Team1, Team2).
Team1 = tiger,
Team2 = lion ;
Team1 = tiger,
Team2 = panther ;
Team1 = lion,
Team2 = tiger ;
Team1 = lion,
Team2 = panther ;
Team1 = panther,
Team2 = tiger ;
Team1 = panther,
Team2 = lion ;
false.


```