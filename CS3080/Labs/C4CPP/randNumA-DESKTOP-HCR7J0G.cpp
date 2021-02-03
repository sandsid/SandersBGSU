


#include <stdio.h>
#include <iostream>
#include <stdlib.h>
#include <fstream>
#include <string>

using namespace std;

int main (int argc, char* argv[]) 
{

    string fileName;
    int numItems;
    int rangeNum;
    int seedNum;

    //check if arg count is correct
    if (argc < 5 ) {
        cout << "Error: Expected number of arguments are: 5 " << endl;
        exit(0);
    }

    //initilize variables
    fileName = argv[1];
    numItems = atoi(argv[2]);
    rangeNum = atoi(argv[3]);
    seedNum = atoi(argv[4]);


    //writing to file
    ofstream outfile;

    outfile.open(fileName);
    if (outfile.is_open())
    {
        //continue working only if file opens
        srand(seedNum);

        //loop to generate data and adds to file
        for (int i = 0; i < numItems; i++)
        {
            outfile << rand()%rangeNum << endl;
        }

        //close file
        outfile.close(); 
    }
    else
    {
        //just to catch an error
        cout << "Error writting to File!"<< endl;
    }


    //reading from the file
    ifstream infile;
    string num;

    infile.open(fileName);
    //only if open do you read the file
    if(infile.is_open())
    {
        while (!infile.eof())
        {
            for (int i = 0; i < 5; i ++)
            {
                getline(infile, num);
                cout << num << "\t";
            }
            cout << endl << endl;
            
        }
        infile.close();
    }else
    {
        //just to catch an error
        cout << "Error reading File!"<< endl;
    }
    return 0;

}



