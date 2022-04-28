/**
 * HW3 KEY barebones
 * Integrates ideas from program #
 *          15, 	20, 	30, 		35		40
 *          fork, 	pipe, 	pipe map, 	exec a process, and parsing
 *
 * Run snapshot:

HW3 "/home/49/kresman/3080/10arg 123 456 hello123" "/usr/bin/grep 123"
(Next) Arg is 123
(Next) Arg is hello123

Program Design: 
  Child:
  * Get 2nd arg from command line (parse it and get cmd#1 and its arguments)
  *        map write end of pipe to sdout so cmd1 output goes to pipe
  *        close unused pipe end (end 0)
  *        exec cmd1 with its arguments
  *
  *
  Parent:
  * Get 3rd arg from command line (parse it and get cmd#2 and its arguments)
  *        map read end of pipe to stdin so cmd$1 input comes from pipe
  *                 cmd#2 output displayed to screen 
  *        close unused pipe end (end 1)
  *        exec cmd#2 with its arguments
  *
  Output shown above consistent with what one would expect from shell:
      /home/49/kresman/3080/10arg " 123 456 hello123" "/usr/bin/grep 123"
  
*/

#include <iostream>
#include <string.h>
#include <unistd.h>
#include <fcntl.h>
#include <stdlib.h>

using namespace std;

int main(int argc, char *argv[]) {
       int pid, pipeName[2];
       pipe(pipeName);
       pid = fork();
       if (pid == 0)
/**        
  Child:
  * Get 2nd arg from command line (parse it and get cmd#1 and its arguments)
  *        map write end of pipe to sdout so cmd1 output goes to pipe
  *        exec cmd1 with its arguments
  *        
*/
       {
              int i = 0;
              char *myArguments_ = strtok(argv[1], " ");
              char *myArguments[60];
              while (myArguments_ != NULL)
              {
                     myArguments[i++] = myArguments_;
                     myArguments_ = strtok(NULL, " ");
              }
              close(1);
              close(pipeName[0]);
              fcntl(pipeName[1], F_DUPFD, 1);
              close(pipeName[1]);
              execv(myArguments[0], myArguments);
              exit(0);     //should not be reached
       }
       else
       {
/**
  Parent:
  * Get 3rd arg from command line (parse it and get cmd#2 and its arguments)
  *        map read end of pipe to stdin so cmd$1 input comes from pipe
  *                 cmd#2 output displayed to screen 
  *        close unused pipe end (end 1)
  *        exec cmd#2 with its arguments
*/

              int i = 0;
              char *myArguments_ = strtok(argv[2], " ");
              char *myArguments[60];
              while (myArguments_ != NULL)
              {
                     myArguments[i++] = myArguments_;
                     myArguments_ = strtok(NULL, " ");
              }
              close(0);
              close(pipeName[1]);
              fcntl(pipeName[0], F_DUPFD, 0);
              close(pipeName[0]);
              execv(myArguments[0], myArguments);
              exit(0);     //should not be reached
       }
}
