#include <stdio.h>
#include <iostream>
#include <stdlib.h>
#include <unistd.h>
#include <errno.h>
#include "/home/cs/kresman/3080/semaphore/semaphore.h" 

using namespace std;


int main (int argc,char *argv[]) {

	int semZero, semOne;
    int pid;
    int rand1,rand2;
    char fn = argv[3];

	if (argc < 1) {
		perror("Invalid arg amount.");
		exit (1);
	}
	//generating random numbers 
    srand(123);
    rand1 = rand() % 100;
    rand2 = rand() % 100;


//  TWO semaphores, 0 and 1, for F and N
	Semaphore semaphore(argv[2], 1);
	
//	intialize semaphores and set values to random number
	semaphore.Init(0, rand1);
	semaphore.Init(1, rand2);

//  fork process to start the first or next printing
	pid = fork ();



	if (pid == 0) {
        if (fn == "F")
        {
            //read F semaphore then the second one
            semaphore.Signal(0);
            semZero = semaphore.ReadValue(0);
            cout<< fn << "   " << getpid() <<  "   " <<  semZero << endl;
            semephore.Signal(1);
            semOne = semaphore.ReadValue(0);
            cout<< fn << "   " << getpid() <<  "   " << semOne << endl;
        }
        else 
        {
            //read N semaphore then the first one
            semaphore.Signal(1);
            semOne = semaphore.ReadValue(0);
            cout<< fn << "   " << getpid() <<  "   " << semOne << endl;
            semaphore.Signal(0);
            semZero = semaphore.ReadValue(0);
            cout<< fn << "   " << getpid() <<  "   " << semZero << endl;
        }
    }
	else {


		//Remove ALL the (two) semaphores 
		sleep(5);

		semaphore.Destroy();

  	}
}
