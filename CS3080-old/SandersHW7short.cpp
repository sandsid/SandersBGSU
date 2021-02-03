

#include <cstdlib>
#include <cstdlib>
#include <stdio.h>
#include <iostream>
#include <stdlib.h>
#include <iostream>


using namespace std;

int main()
{
    //creating 4*4 for storing matrices
    int a[4][4], b[4][4], sum[4][4];
    int row, col;
    int i, j;
    int randomint;

    //seed for rand
    srand(123);

    //rand num for the row and col
    row = rand() % 999;
    col = rand() % 999;

    //first matrix 
    for(i = 0; i < row; ++i)
    {
       for(j = 0; j < col; ++j)
       {
           randomint = (rand()% 100);
           a[i][j] = randomint;
       }
    }

    //second matrix 
    for(i = 0; i < row; ++i)
    {
       for(j = 0; j < col; ++j)
       {
           randomint = (rand()% 100);
           b[i][j] = randomint;
       }
    }
    // Adding Two matrices
    for(i = 0; i < row; ++i)
    {
        for(j = 0; j < col; ++j)
            sum[i][j] = a[i][j] + b[i][j];
    }

    // Result of addition: sum matrix
    cout << endl << "Result of Addition: " << endl;
    for(i = 0; i < row; ++i)
    {
        for(j = 0; j < col; ++j)
        {
            cout << sum[i][j] << "  ";
            if(j == col - 1)
                cout << endl;
        }
    }

    return 0;
}