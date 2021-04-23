female(grandma).
female(girl1).
female(woman1).
female(girl2).
female(girl3).
male(man1).
male(man2).
male(boy1).
male(boy2).
male(boy3).

descParent(boy1, man1). 
descParent(girl1, man1). 
descParent(man1, grandma). 
descParent(boy2, man2).
descParent(boy3, man2).
descParent(man2, grandma). 
descParent(girl2, woman1).
descParent(boy3, woman1).
descParent(woman1, grandma).


isGrandParent(X) :- descParent(Z, Y), descParent(Y,X).
grandParent(X, Y):- descParent(X, Z), descParent(Z, Y).
nephewUncle(X, Y):- descParent(X, Z), male(X), male(Y), descParent(Z,Y).
hasDecendent(X):- descParent((Y,X).



