
/********************************************************

*	  system calls: pipe 		        *	
*	  Parent reads, Child writes			*
*	  Map terminal output to pipe...		*
*	     so cout goes to pipe
*	     similarly, cin
********************************************************/
#include <sys/types.h>
#include <iostream>
#include <unistd.h>
#include <stdlib.h>
#include <fcntl.h>

using namespace std;

int main (int argc, char *argv[]) {
 int flag;
 char buffer[512];
 int pid, pipeName[2];

 int returnValue = pipe (pipeName);  
 if( returnValue <  0  ) {          //<======= Good programming tip
      perror("Some bad, bail out! ");
      return(-1);
 }

 pid = fork();

 if (pid == 0) {

     	/* child */ 

	cout << "I am the child; my ID" << getpid() << " "<<  endl;
        cout << "what is your name? " ;
        cin >> buffer;                  // read from the terminal window
	close(1);                         /* close STDOUT */
        flag = fcntl(pipeName[1], F_DUPFD, 1);  /* map STDOUT to pipe write */
        cout << buffer << endl;         // print to term window
					//   ...goes to pipe!
        exit(2);

  } 
   
 else{      /* parent */
	cout << "I am the parent; my ID = " << getpid() << endl;
	close(0);                               /* close STDIN */
        flag = fcntl(pipeName[0], F_DUPFD, 0);  /* map STDIN to pipe[0] */

        cin >> buffer;                  // read from  PIPE!


        cout << "Received at parent: " << buffer << endl ;



 } 
}

/**
bgunix% !g
g++ pipeMap.cpp
bgunix% a.out
I am the parent; my ID = 5123
I am the child; my ID5124
hello
Received at parent: hello
*/




