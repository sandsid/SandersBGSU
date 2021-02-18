//*********************************************************************
// Lab 2 -	Inter-Process Communications
//			
// Objective:
//          • Practice writing Pseudocode first[program design]
//          • Understand process creationand task assign
//          • Understand write/readcommunications between processes
//          • Practice withfork & pipesystem calls
//
// Programmer:	Sidney Sanders
// Class:		CS 3080-1001 Spring 2021
//
// File:    pipeLab.cpp
//
//*********************************************************************

#include <iostream>
#include <stdio.h>
#include <stdlib.h>
#include <pthread.h>
#include <bits/stdc++.h>
#include <sys/wait.h>
#include <unistd.h>

using namespace std;

int main (int argc, char* argv[])
{
int numItems;
    int rangeNum;
    int seedNum;
    float avg = 0;
    int sum = 0;
    int min = 0;   
    int max = 0;

    int fd[2];
    int buffer;
    pid_t cpid;
    
    numItems = atoi(argv[1]);
    rangeNum = atoi(argv[2]);
    seedNum = atoi(argv[3]);
    srand(seedNum);

    pipe(fd);
    cpid = fork();
    if (cpid == 0)
    {
        close(fd[1]);
        while(read(fd[0], &buffer, sizeof(buffer)) > 0 )
        {
            if (buffer < min)
                min = buffer;
            
            if (buffer > max)
                max = buffer;

            sum += buffer;
        }
        avg = sum / numItems;

        cout << "Child ID:  " << getpid() << "  items received:  " << numItems << "  min :  " << min << "  max:  " << max << "  avg:  " << avg << endl;
    }
    else
    {
        close(fd[0]);
        
        for (int i = 0; i < numItems; i++)
        {
            int randNum = rand() % rangeNum;
            write(fd[1], &randNum, sizeof(randNum));
        }
        close(fd[1]);
        cout<<"Parent ID:   "<< getpid() <<" number of items written into the pipes are: "<< numItems <<endl;
        wait(NULL);
    }

    return 0;
}
