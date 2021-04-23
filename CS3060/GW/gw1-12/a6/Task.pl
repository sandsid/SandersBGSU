suffix(S, S).    % base case. S is a suffix of itself.
suffix([ X | Tail ], S) :- suffix(Tail, S).

