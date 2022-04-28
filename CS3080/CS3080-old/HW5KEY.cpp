/**                  
              HW 5 KEY barebones
  g++ HW5KEY.cpp /home/cs/kresman/3080/semaphore/semaphore.o
  a.out 5 123 F &
  a.out 5 456 N &
*/

#include <stdio.h>
#include <iostream>
#include <stdlib.h>
#include <unistd.h>
#include <errno.h>
#include "/home/cs/kresman/3080/semaphore/semaphore.h"
//instructor's header file above
using namespace std;

int main(int argc, char *argv[])
{

    int num = atoi(argv[1]);
    srand(atoi(argv[2]));
    Semaphore semaphore(123456, 2);

    if (*argv[3] == 'F')
    {
        semaphore.Init(0, 0);
        for (int i = 0; i < num; i++)
        {
            cout << *argv[3] << " " << getpid() << " " << rand() << endl;
            semaphore.Signal(0);
            semaphore.Wait(1);
        }
    }
    else
    {
        for (int i = 0; i < num; i++)
        {
            semaphore.Wait(0);
            cout << *argv[3] << " " << getpid() << " " << rand() << endl;
            semaphore.Signal(1);
        }
        semaphore.Destroy();
        cout << "Semaphores all gone!" << endl;
    }
}
