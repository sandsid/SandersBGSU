Project 1: 


To compile and run a certain sorting algorythm:
g++ INSERTIONSORT.cpp

to exicute the file enter into the next line './a.out' and enter in the name of the file 
desired for testing. 

example of command line run

$ g++ INSERTIONSORT.cpp
$ ./a.out
Enter Filename: SORTED-80000.txt
80000,   79999,   271


A way to compile and call the entirty of an algorythm is to enter
this into the command line when in the project directory one at a time
this will open the algorythm for you to test all 16 files for the
algorythm you desire. You have to manually enter in the names of all the 
files.

$ g++ INSERTIONSORT.cpp ; ./a.out ; ./a.out ;  ./a.out ;  ./a.out \
; ./a.out ; ./a.out ;  ./a.out ;  ./a.out \
; ./a.out ; ./a.out ;  ./a.out ;  ./a.out \
; ./a.out ; ./a.out ;  ./a.out ;  ./a.out

$ g++ MERGESORT.cpp ; ./a.out ; ./a.out ;  ./a.out ;  ./a.out \
; ./a.out ; ./a.out ;  ./a.out ;  ./a.out \
; ./a.out ; ./a.out ;  ./a.out ;  ./a.out \
; ./a.out ; ./a.out ;  ./a.out ;  ./a.out

$ g++ QUICKSORT.cpp ; ./a.out ; ./a.out ;  ./a.out ;  ./a.out \
; ./a.out ; ./a.out ;  ./a.out ;  ./a.out \
; ./a.out ; ./a.out ;  ./a.out ;  ./a.out \
; ./a.out ; ./a.out ;  ./a.out ;  ./a.out

$ g++ QUICKSORT-MID.cpp ; ./a.out ; ./a.out ;  ./a.out ;  ./a.out \
; ./a.out ; ./a.out ;  ./a.out ;  ./a.out \
; ./a.out ; ./a.out ;  ./a.out ;  ./a.out \
; ./a.out ; ./a.out ;  ./a.out ;  ./a.out


Example output of calling this command line is as follows

~/cs4120ts/Project1$ g++ INSERTIONSORT.cpp ; ./a.out ; ./a.out ;  ./a.out ;  ./a.out \
> ; ./a.out ; ./a.out ;  ./a.out ;  ./a.out \
> ; ./a.out ; ./a.out ;  ./a.out ;  ./a.out \
> ; ./a.out ; ./a.out ;  ./a.out ;  ./a.out
Enter Filename: IDENTICAL-10000.txt
10000,   9999,   90

Enter Filename: IDENTICAL-20000.txt
20000,   19999,   60

Enter Filename: IDENTICAL-40000.txt
40000,   39999,   130

Enter Filename: IDENTICAL-80000.txt
80000,   79999,   241

Enter Filename: RAND-10000.txt
10000,   37285538,   102958

Enter Filename: RAND-20000.txt
20000,   148833080,   376996

Enter Filename: RAND-40000.txt
40000,   467970368,   1160621

Enter Filename: RAND-80000.txt
80000,   2179729071,   5644541

Enter Filename: REVERSED-10000.txt
10000,   50004999,   130914

Enter Filename: REVERSED-20000.txt
20000,   200009999,   504695

Enter Filename: REVERSED-40000.txt
40000,   800019999,   2013163

Enter Filename: REVERSED-80000.txt
80000,   3200039999,   8153799

Enter Filename: SORTED-10000.txt
10000,   9999,   30

Enter Filename: SORTED-20000.txt
20000,   19999,   65

Enter Filename: SORTED-40000.txt
40000,   39999,   118

Enter Filename: SORTED-80000.txt
80000,   79999,   264


