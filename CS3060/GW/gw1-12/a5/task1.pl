inDomain([ ], _). /* base case */
inDomain([H|T], ValList) :- 
    member(H, ValList), inDomain(T, ValList).

/* Note: ValList represents the list of values which are in the domain */

