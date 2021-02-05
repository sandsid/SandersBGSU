# Lab Assignment #2 -- Pseudocode

```
main start
    create randSeed from argument array 
    create rand variable
    create numItem variable
    create range variable
    create pipe 
    create fork 
    check for error 

    if child 
        start child
        close write-end pipe
        for loop with numitems items
            read number from pipe
            calculate if num is min
            calculate if num is max
            add to the average
        end for loop 
        calculate the average
        close read-end pipe
        get the child PID
        print the child with the PID and the calculations
        end child
    end child if

    if parent 
        close read-end pipe
        for loop with numItems items
            generate rand number within range
            write rand number to pipe
        end for loop
        close write-end pipe
        wait for child
        print parent with id and the number of items written to the pipe
    end parent if

    exit 
main end
```