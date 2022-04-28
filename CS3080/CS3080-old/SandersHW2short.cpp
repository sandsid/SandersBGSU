/*******************************************************
//        HW2 short
//        use of fork and pipe          
//        create a parent and two children
//        use input from user to find a sum
//        

*/


#include <sys/types.h>
#include <unistd.h>
#include <stdlib.h>
#include <stdio.h>
#include <iostream>
#include <cstdlib>
#include <array> 


using namespace std;


//read from the pipe

void read_pipe (int file)
{
	/*
	FILE * stream;
	int c; 
	stream = fdopen (file, "r");
	while ((c = fgetc(stream)) != EOF)
	*/
}


//write to the pipe

void write_pipe (int file)
{



}


//main arg with forks

int main(int argc, char* argv[]) 
{

	int pid, child;
	int num1=0, num2=0, num3=0;
	int leftC, leftPID, rightC, rightPID, pNum;
	cin >> num1;
	cin >> num2;
	cin >> num3;
	int sum = num1+num2+num3;
	cout << endl;

	int pipe_fd[2];
	char buffer[20];
	pipe(pipe_fd);
	


	int randNum = rand();
	//cout << rand()

	pnum = randNum + num1;

	for (i=0; i<1; i++)
	{
		leftC = fork();
		leftPID = getpid();
		
		if (leftC == 0)
		{
			//complete left fork cout
			//add num 2 to pipe number
			cout << "C " << leftPID << " " << getppid() << endl;
			//break left fork
			//add num2 and pipe sum back to pipe
			break;
			//leftC = -1;
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
				break; 
				//rightC = -1;
			}
			else if (rightC < 0)
			{
				//parent cout and sum
				//must subtract the random number from the pipe number
				cout << "P "  << sum << endl;

			}
		}
	

	}

}

