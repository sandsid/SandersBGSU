


#include <iostream>
#include <stdio.h>
#include <chrono>
#include <string>


using namespace std;
using namespace chrono;

const int MAX = 30;

//will print the array given: 
//needs the array passed and the size of array
void printArray (int [], int);

int main()
{
    int array[MAX];
    int size = 0;
    bool done = false;
    int hold = 0;

    high_resolution_clock::time_point startTime;
    high_resolution_clock::time_point endTime;
    
    auto duration = 0;

    //get user input to fill array with n amount of integers
    do
    {
        //ask for valid user input
        cout << "Enter a positive integer(-1 to stop):  ";
        cin >> hold;
        //check for stopping point
        if (hold < 0)
        {
            if(hold == -1)
            {
                done = true;
            }
            else
            {
                cout << "Must enter a valid positive integer!(-1 to stop)" << endl;
            }
            
        }
        else // if no stopping point continue with filling array
        {
            array[size] = hold;
            size++;
        }
    } while ((size < MAX) && (done = false));
    

    //begin time 
    startTime = high_resolution_clock::now();

    //rod cutting here 

    //stop the time clock
    endTime = high_resolution_clock::now();


    duration = duration_cast<microseconds>(endTime - startTime).count();



    return 0;
}