
/**
 * 		Program name: Demonstrate use of Semaphores
 *
     g++ 50semaphoreExample.cpp /home/cs/kresman/3080/semaphore/semaphore.o

     Play with semaphore creation/use etc..
     Using instructor supplied member functions.

     Main creates two semaphores and initializes them.
     Main forks to create a child
     Parent does some (wait/signal) operations on the semaphores,
     Child does some too and exits.
     COUT shows the effect
     Parent destroys the two semaphores and gracefully exits.

*/

#include <stdio.h>
#include <iostream>
#include <stdlib.h>
#include <unistd.h>
#include <errno.h>
#include "/home/cs/kresman/3080/semaphore/semaphore.h" 
                        //instructor's header file above
using namespace std;

int main (int argc,char *argv[]) {

	int semZero, semOne;
        int pid;

	if (argc != 1) {
		perror("Usage-> programName \n");
		exit (1);
	}
	
//	Create TWO semaphores, called 0 and 1 
//	if you create 10 semaphores, they are called 0, 1, 2, ..., 9 
	cout << "Hello world, creating 2 semaphores..." << endl;
	Semaphore semaphore(123, 2);
	
//	intialize semaphore 0 to value 1 
	semaphore.Init(0, 1);

//	intialize semaphore 1 to value 0 */
	semaphore.Init(1, 1);


//	Just for fun.. check if initialization for sem 1 is correct 
	cout << "Inital val of Sem # 1 = 1? ... "<<semaphore.ReadValue(0)<<endl;

//	Just for fun , I am upping semaphore 0 twice 
	semaphore.Signal(0);
	cout << "Is Sem # 0 = 2? ... "<<semaphore.ReadValue(0) << endl;

	pid = fork ();

	if (pid == 0) {
	        semaphore.Signal(0);
		semZero = semaphore.ReadValue(0);
		cout<<"C: Is Sem # 0 = 3? ... "<<semaphore.ReadValue(0) << endl;

}
	else {

		//Just for fun, I am downing semaphore 1, ONCE 
		semaphore.Wait(1);

		semOne = semaphore.ReadValue(1);
		cout << "Is Sem # 1 = 0? ... "<< semOne << endl;


	        //If I down semaphore 1 again, it WILL BLOCK, Don't!!!! */

		//Remove ALL the (two) semaphores 

        	cout<< "Parent will sleep for 5 seconds." <<endl;
		sleep(5);

		semaphore.Destroy();

  	}
}
