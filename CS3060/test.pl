myrule(Y, [Y|T]).
myrule(Y, [_|T]) :- myrule(Y,T).
