



#include <sys/wait.h>
#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
#include <bits/stdc++.h>
using namespace std;

int
main(int argc, char * argv[])
{
int pipefd[2];
pid_t cpid;
int buf;
int numItems= atoi(argv[1]);
int range= atoi(argv[2]);
int seed= atoi(argv[3]);
int min =9999999;
int max=-9999999;
float avg=0;
int sum=0;
pipe(pipefd); // create the pipe
cpid = fork(); // duplicate the current process
if (cpid == 0) // if I am the child then
{
close(pipefd[1]); // close the write-end of the pipe, I'm not going to use it

while (read(pipefd[0], &buf, sizeof(buf)) > 0) // read while EOF{}
{ //write(1, &buf, 1);
  

if (buf < min)
min =buf;

if (buf > max)
max =buf;
sum+=buf;
}
avg=sum/numItems;
close(pipefd[0]); // close the read-end of the pipe
cout<<"Child ID:"<< getpid()<<" number of items received: "<<numItems<<" min: "<<min<<" max: "<<max<<" avg: "<<avg<<endl;
}
else // if I am the parent then
{
close(pipefd[0]); // close the read-end of the pipe, I'm not going to use it
srand(seed);

for (int i=0;i< numItems ;i++){
  
int random = rand() % range;
  

write(pipefd[1],&random,sizeof(random)); // send the content to the reader
  
}
// close the write-end of the pipe, thus sending EOF to the reader
close(pipefd[1]);
cout<<"Parent ID:"<< getpid()<<" number of items written into the pipes are:  "<< numItems <<endl;
wait(NULL); // wait for the child process to exit before I do the same
}
return 0;
}