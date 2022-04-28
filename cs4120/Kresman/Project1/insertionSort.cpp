/*
CS 4120 - Spring 2022
Sidney Sanders, Noah Jackson, Lucas Hufford
*/

#include<string>
#include<fstream>
#include<iostream>
#include<chrono>
#include <stdio.h> 
#include <stdlib.h> 
#include <time.h>  

using namespace std;
using namespace chrono;


long long comparisons;

//algorithm that takes the row number, the 2d array and the size of the list
//sorts the row its passed and returns
void insertionSort(int, int[], int);

//takes the array, and filename and fills a 2d array and returns
void fill_array(int[], string);


int main(int argc, char *argv[])
{
    
    high_resolution_clock::time_point startTime;
    high_resolution_clock::time_point endTime;
    

    int size;
    auto int time = 0;
    string fileArray[3] = {"5000rand.txt", "25000rand.txt", "50000rand.txt"};
    string filename = "";
    
    int seed = 1;
    srand(seed);

    string userDecision = argv[1];
    //‘D’  generates the datasets (10 sets for each size) and dumps them to a file(s)
    if(userDecision == "D")
    {
        //creation of  10 - 5000 dataset.
        ofstream outfile;
        outfile.open(fileArray[0]);
        int count = 0;
        for (int i = 0; i < 10; i++)
        {
            do
            {
                int temp = rand() %1000000 + 1;
                outfile << temp << "\n";
                count++;
            }while(count < 5000);
            outfile << "next\n";
            count = 0;
        }
        outfile.close();
        cout << endl;

        //creation of  10 - 25000 dataset.
        outfile.open(fileArray[1]);
        for (int i = 0; i < 10; i++)
        {
            do
            {
                int temp = rand() %1000000 + 1;
                outfile << temp << "\n";
                count++;
            }while(count < 25000);
            outfile << "next\n";
            count = 0;
        }
        outfile.close();

        //creation of  10 - 50000 dataset.
        outfile.open(fileArray[2]);
        for (int i = 0; i < 10; i++)
        {
            do
            {
                int temp = rand() %1000000 + 1;
                outfile << temp << "\n";
                count++;
            }while(count < 50000);
            outfile << "next\n";
            count = 0;
        }
        outfile.close();


    }
    //‘S’ sorts the dataset using the algorithms and produces comma separated output
    else if (userDecision == "S")
    {
        //needs to be a 2d array
        int data[9][500000];

        fill_array(data, filename);

        
        //initializing comparisons
        comparisons = 0;

        //call insertion for each individual size. 
        //send in one row at a time, nest a loop around the time clock 
        //5,000
        fill_array(data, fileArray[0]);
        for(int i = 0; i < 9; i++)
        {
            startTime = high_resolution_clock::now();
            insertionSort(i, data, 5000);
            endTime = high_resolution_clock::now();
            
            //cpu time for computation of each dataset
            time = duration_cast<microseconds>(endTime - startTime).count();
            
            //output: I for Insertion, Q for Quick sort
            //I, {row}, {comparisons}, {time}, {worst case number}
            cout << "Algorithm\t Comparisons\t Time\t Worst Case" << endl;
            cout << "I" << "\t" << comparisons << "\t" << time << endl; 
        }
        //25,000
        fill_array(data, fileArray[1]);
        for(int i = 0; i < 9; i++)
        {
            startTime = high_resolution_clock::now();
            insertionSort(i, data, 5000);
            endTime = high_resolution_clock::now();
            
            //cpu time for computation of each dataset
            time = duration_cast<microseconds>(endTime - startTime).count();
            
            //output: I for Insertion, Q for Quick sort
            //I, {row}, {comparisons}, {time}, {worst case number}
            cout << "Algorithm\t Comparisons\t Time\t Worst Case" << endl;
            cout << "I" << "\t" << comparisons << "\t" << time << endl; 
        }
        //50,000
        fill_array(data, fileArray[3]);
        for(int i = 0; i < 9; i++)
        {
            startTime = high_resolution_clock::now();
            insertionSort(i, data, 5000);
            endTime = high_resolution_clock::now();
            
            //cpu time for computation of each dataset
            time = duration_cast<microseconds>(endTime - startTime).count();
            
            //output: I for Insertion, Q for Quick sort
            //I, {row}, {comparisons}, {time}, {worst case number}
            cout << "Algorithm\t Comparisons\t Time\t Worst Case" << endl;
            cout << "I" << "\t" << comparisons << "\t" << time << endl; 
        }

    }
    else
    {
        //fail safe is the input doesnt match D or S
        cout << "There has been an error in input." << endl;
        return 0;
    }


    cout << endl;
    return 0;
}

//Insertion Sort
//needs to accept 2d array :
//accepts the row number so that the algorithm can run normally, while only 
//checking one array(row) at a time
void insertionSort(int row, int ary[][500000], int length)
{
    //resets the comparisons between each iteration.
    comparisons = 0;

    int key, j;
    int row;

    for (int i = 1; i < length; i++)
    {
        key = ary[row][i];
        j = i - 1;

        while (j >= 0 && ary[row][j] > key)
        {
            ary[row][j + 1] = ary[row][j];
            j = j - 1;
            comparisons++;
        }
        comparisons++;
    }
}

//Fill new array 
//takes the 2d array and the filename
//reads each line as a tring from the file
//comapres the string with the trigger, is != to the trigger
//convert to a integer and add to the array
//if it does equal the array, increment the row, and continure to read from the file
//do not add trigger to the array. 
void fill_array(int ary[][500000], string filename)
{
    int i = 0;

    ifstream infile;
    infile.open(filename);

    //trigger is line that separated the 10 arrays
    string trigger = "next";
    //temp holds the line from the file to be compared to the trigger
    string temp = "";
    //row is array number, col is element in each array
    int row = 0, col = 0;


    if (infile.fail())
    {
        cout << "File not found! Enter valid Filename" << endl;
    }
    else
    {
        while (!infile.eof())
        {
            //read in the line from the file
            //infile >> ary[i];
            getline(infile,temp);
            //check the string against the trigger
            if (temp == trigger)
            {
                //row is incremented
                //col is reset back to 0

            }
            else
            {
                //string is converted to integer (stoi)
                //integer is added into array,
                //col is incremented
            }

            
            i++;
        }
    }
    infile.close();
}

