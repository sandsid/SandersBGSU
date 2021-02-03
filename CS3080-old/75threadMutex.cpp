//	Explores how global variables can be used safely
//	Thread 1: Transfer monies from checking to saving
//	Thread 2: Prints a/c balance.  
//	Balance is consistent if one thread does not interleave the other.

#include <stdio.h>
#include  <iostream>
#include <pthread.h>
#include <unistd.h>

using namespace std;

#include <unistd.h>
void perror(const char *s);

struct bankAccount {	// Account info structure
	int checking;	// checking balance
	int saving;
};

pthread_mutex_t critSectionLock = PTHREAD_MUTEX_INITIALIZER;

struct bankAccount myAccountInfo;

void *checkToSaving(void *);
void *printBalance(void *);

main () {
	pthread_t threadID,threadID2;
	int error,retValue;
	void *status;
	int amountToTransfer = 123;  // from checking to saving

	myAccountInfo.checking = 456;
	myAccountInfo.saving =  789;  

	if (pthread_create(&threadID, NULL, checkToSaving, 
			(void *) &amountToTransfer) != 0) {
		perror  ("pthread_create failed" );
		exit (1);
	}
	if (pthread_create(&threadID2, NULL, printBalance, 
			(void *) &status) != 0) {
		perror  ("pthread_create failed" );
		exit (1);
	}
	if (pthread_join(threadID2, &status) != 0) {;
		perror  ("pthread_Join failed" );
                exit (1);
	}
}

void * checkToSaving(void *formalParameter) {
	int *amtPointer = (int *) formalParameter;
       
	pthread_mutex_lock(&critSectionLock);
        cout << "checkToSaving thread ID: " << pthread_self() << " " << endl;
	myAccountInfo.checking -= *amtPointer;

        sleep (40);
	myAccountInfo.saving  += *amtPointer;
	pthread_mutex_unlock(&critSectionLock);
	return (NULL);
}

void * printBalance(void *status) {
        cout << "printBalance thread ID: " << pthread_self() << " " << endl;
	pthread_mutex_lock(&critSectionLock);
	cout << "Total Balance " << 
			myAccountInfo.checking + myAccountInfo.saving << endl;
	pthread_mutex_unlock(&critSectionLock);
	return (NULL);
}
