/*
 *     This C++ program prints the command line arguments (CLA)
 *     The C verstion of the program is similar, needs only
 *     replacing C++ stuff with the C stuff [e.g, printf etc.]
 *
 *     Usage:  ProgNameExec arg1 arg2 arg3 ...
 *
 */

//      This demo program illustrate how to use argc & argv in the main
//      to pass parameter from the command line to the program
//
//      Example for lab1: we need to pass (4+1) items to the program
//              ./randA datafileA.txt 20 1000 3127
//
//      Author Dr. Rajaei
//      Purpose: Demo
//      Date: 1/11/2021
//


#include <stdio.h>
#include <iostream>

using namespace std;

int main (int argc, char *argv[])
{
        int index;

        // This is a Demo only

        if (argc < 5 ) {
                cout << "*** Error: Expected number of arguments are: 5 "
                        << endl;
                exit(0);
        }

        cout << "Program name is: " << argv[0] << endl;

        for (index = 1; index < 5; index++)
                cout << "[Next] Argument is: " << argv[index] << endl;

        return 0;
}

