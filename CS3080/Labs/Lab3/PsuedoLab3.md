# Lab Assignment #3 -- Pseudocode

``` 
constant num of items
constant buffer size

inizialize buffersize
initialize arrayOfThreads


start main 

    create pthread producer
    create pthread consumer

    initialize min, max, avg, total

    for loop  up to numofthreads
        pthread join threads
    end for loop

    for loop up to buffer size
        conpare max 
            assign if needed 

        compare min
            assign if needed 
        
        add to avg

    end for loop

    compute avg

    print the min, max and avg report

end main 

start consumer 
    
    pthread wait

    inizialixe variables

    wait for status

    while nextItemOut is less than NumItems
        print item
    end while 

    clear pthread signal
    pthread exit
end consumer


start producer

    while nextItem is less than numItems
        num = rand number 

        assign num to buffer 
    end while

    pthread signal full 

    pthread exit

end produceer


```