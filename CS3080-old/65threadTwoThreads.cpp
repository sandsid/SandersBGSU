//	Creates  two threads; each thread works through a loop.
//	Loop index is a global variable. 
//	Output  MAY be unpredicatable.

//      How to compile on BGLinux.bgsu.edu
//      g++ fileName.cpp -lpthread

#include <stdio.h>
#include  <iostream>
#include <pthread.h>
#include <unistd.h>

using namespace std;

void *status;
void *bothThreadsDoThis(void *);
 
int usleep(useconds_t useconds);
//extern "C" {
//int usleep(int);
//}

int globalIndex;	// shared between threads

int main (int argc, char *argv[]) {
	pthread_t threadID;
	pthread_t threadID2;
	int retValue;
        char msg[] = "Hello world";
        if (pthread_create(&threadID, NULL, bothThreadsDoThis,
                        (void *) msg) != 0) {
                perror  ("pthread_create failed" );
                exit (1);
        }
        if (pthread_create(&threadID2, NULL, bothThreadsDoThis,
                        (void *) msg) != 0) {
                perror  ("pthread_create failed" );
                exit (1);
        }

	//Wait for the two threads to finish
	retValue = pthread_join(threadID, &status);
	retValue = pthread_join(threadID2, &status);
}

//TWO threads do the same loop below. Result is unpredictable!
//Results may NOT be the same across runs!!
//globalIndex is GLOBAL to both threads

void *bothThreadsDoThis(void *message)
{
	int localData;	//Local (but unused...) NOT shared between threads
        char *messagePointer = (char *)message;
        cout << messagePointer << " " << pthread_self() << " " << endl;

	//Each thread may not go thru the full for loop!!
	for (globalIndex = 1; globalIndex <= 10; globalIndex++) {
		cout << globalIndex << endl;
		usleep(18);	//sleep for 10 microseconds
	}
	return (NULL);
}
