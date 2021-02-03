//      Pass multiple arguments  to a thread -- use struct
//
#include <stdio.h>
#include  <iostream>
#include <pthread.h>
#include <unistd.h>

using namespace std;

struct bankAccount {
 int checking,savings;
 float balance;
};

typedef struct bankAccount accountStructure;

void* computeSum (void* accHandle) {

 accountStructure *accHandle2 =  (accountStructure*)accHandle;
 accHandle2->balance = accHandle2->checking + accHandle2->savings;
 cout << "Compute total balance: " << 
        accHandle << " " << accHandle2 << " " <<  accHandle2->balance << endl;
 return 0;
}

int main() {
 pthread_t myThread;

 accountStructure *myAccount = new accountStructure ;
 myAccount->checking=123;
 myAccount->savings = 456;

 pthread_create(&myThread,NULL,computeSum,(void*) myAccount);
 pthread_join(myThread,NULL);

 return 0;
}

