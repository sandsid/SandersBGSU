

#include <sys/types.h>
#include <iostream>
#include <unistd.h>
#include <stdlib.h>




using namespace std;

int main (int argc, char *argv[])
{
    int flag;
    char buffer[512];
    int pid;
    int pipe1[2];
    //int pipe2[2];

    int returnV = pipe (pipe1);
    if (returnV < 0)
    {
        perror("Error in pipe1");
        return(-1);

    }


    pid = fork();
    if (pid == 0) 
    {
        //child is open
        //cout << "C 1 ID:" << getpid() << " " << endl;


        //cin >> buffer;

        buffer = arg[0]; //getting first arg from terminal;

        close(1);
        flag = fcntl(pipe1[1], F_DUPED, 1);
        exit(2);

    }
    else
    {
        //cout << "I am the parent; my ID: " << getpid(); << endl;

        close(0);

        flag = fcntl(pipe1[0],F_DUPED, 0);
        cin >> buffer; // from pipe

        cout<< buffer; // printing line from terminal gotten from pipe


    }
    


}

//don't think i use this
void tokens (char *source)
{

    char *myToken = strtok(source,"");
    while (myToken != NULL) 
    {
        myToken = strtok(NULL, "");
    }

}