/*
* HW2short  KEY
* Secure multiparty computation using pipe
* HW2shortKEY.cpp
*/

#include <string.h>
#include <sys/types.h>
#include <unistd.h>
#include <stdlib.h>
#include <iostream>
using namespace std;

int main(int argc, char *argv[])
{
    int AtoBWrite, AtoBRead, BtoCWrite, BtoCRead, CtoAWrite, CtoARead;
    int pidA, pidB, AtoB[2], BtoC[2], CtoA[2];
    pipe(AtoB);
    pipe(BtoC);

    pidA = fork();
    if (pidA == 0)
    {
        /* child B */
        close(AtoB[1]);
        close(BtoC[0]);

        int inputB;

        read(AtoB[0], &AtoBRead, sizeof(AtoBRead));
        close(AtoB[0]);
        cin >> inputB; close (0);

        BtoCWrite = AtoBRead + inputB;

        write(BtoC[1], &BtoCWrite, sizeof(BtoCWrite));
        close(BtoC[1]);

        cout << "C " << getpid() << " " << getppid() << " " 
               << inputB << " " << AtoBRead << " " << BtoCWrite << endl;
        exit(1);
    }
    else
    {
        pipe(CtoA);
        pidB = fork();
        if (pidB == 0)
        {

            /* child C */
            close(AtoB[0]);
            close(AtoB[1]);
            close(BtoC[1]);
            close(CtoA[0]);

            int inputC;

            read(BtoC[0], &BtoCRead, sizeof(BtoCRead));
            close(BtoC[0]);
            cin >> inputC;  close (0);

            CtoAWrite = BtoCRead + inputC;

            write(CtoA[1], &CtoAWrite, sizeof(CtoAWrite));
            close(CtoA[1]);

            cout << "C " << getpid() << " " << getppid() << " " 
                << inputC << " " << BtoCRead << " " << CtoAWrite << endl;
            exit(1);
        }
        else
        {

            /* parent A */
            close(AtoB[0]);
            close(BtoC[0]);
            close(BtoC[1]);
            close(CtoA[1]);

            int inputA;
            cin >> inputA; close (0);

            srand(atoi(argv[1]));
            int randomNum = rand();

            AtoBWrite = randomNum + inputA;

            write(AtoB[1], &AtoBWrite, sizeof(AtoBWrite));
            close(AtoB[1]);

            read(CtoA[0], &CtoARead, sizeof(CtoARead));
            close(CtoA[0]);

            int sum;
            sum = CtoARead - randomNum;

            cout << "P " << getpid() << " " << getppid() << " " 
                 << inputA << " " << CtoARead << " " << AtoBWrite << endl;
            cout << "P " << sum << endl;
        }
    }
}
