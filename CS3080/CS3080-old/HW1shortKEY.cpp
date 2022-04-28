/*******************************************************
//        HW1short KEY
//        use of fork                                   *
//        create two processes
//        print each process id
          RUN output shon below

g++ HW1shortKEY.cpp
$ a.out parentStuff childStuff
I am child: childStuff my ID 47888
I am parent: parentStuff my ID: 47887 my child ID 47888

$ a.out 123 "hello world"
I am parent: 123 my ID: 83263 my child ID 83264
I am child: hello world my ID 83264

*/

#include <stdio.h>
#include <sys/types.h>
#include <iostream>
#include <unistd.h>
#include <stdlib.h>

using namespace std;

int main(int argc, char* argv[]) {

	int pid;
	int num1=0, num2=0, num3=0;
	cin >> num1;
	cin >> num2;
	cin >> num3;
	cout << endl;

	//pid = fork();
	
	leftC = fork();
	leftPID = getpid();

	if (leftC == 0)
	{
		//complete left fork cout
		cout << "C " << leftPID << " " << getppid() << endl;
		//break left fork
		leftC = -1
	}
	else if (leftC < 0)
	{
		rightC = fork();
		rightPID = getpid();

		if (rightC == 0)
		{
			//complete right cout 
			cout << "C " << rightPID << " " << getppid() << endl;
			//break right fork 
			rightC = -1
		}
		else if (right < 0)
		{
			//parent cout and sum
			//must subtract the random number from the pipe number
			cout "P ";

		}
	}

	
	/*
	if (pid == 0) {
		// child 
		cout << "C " << getpid() << endl;
		exit(1);
	}

	else {
		cout << "A " 
                     << argv[1] << endl << " my ID: " << getpid() 
                     << " my child ID " << pid << endl;

	}
	*/
}

