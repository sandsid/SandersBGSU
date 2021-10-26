/*
CS 4120 - Fall 2021
Sidney Sanders
*/


#include<string>
#include<fstream>
#include<iostream>
#include<chrono>

using namespace std;
using namespace chrono;


long long comparisons;

void insertionSort(int[], int);

int determine_size(string);
void fill_array(int[], string);

int main()
{
    
    high_resolution_clock::time_point startTime;
    high_resolution_clock::time_point endTime;
    
    int size;
    auto duration = 0;
    string fileArray[12] = {"rand-1000.txt", "rand-2000.txt", "rand-4000.txt", "rand-8000.txt",
                            "reverse-1000.txt", "reverse-2000.txt", "reverse-4000.txt", "reverse-8000.txt",
                            "sorted-1000.txt", "sorted-2000.txt", "sorted-4000.txt", "sorted-8000.txt",};
    string filename = "";


    for(int i = 0; i < 12; i++)
    {
        filename = fileArray[i];
        size = determine_size(filename);
        int* data = new int[size];
        fill_array(data, filename);

        //initializing comparisons
        comparisons = 0;

        startTime = high_resolution_clock::now();
        insertionSort(data, size);
        endTime = high_resolution_clock::now();


        duration = duration_cast<microseconds>(endTime - startTime).count();

        cout << size << "\t" << comparisons << "      \t" << duration << endl;
        data = nullptr;
        delete data;
    }


    cout << endl;
    return 0;
}

//Insertion Sort
void insertionSort(int ary[], int length)
{
    int key, j;

    for (int i = 1; i < length; i++)
    {
        key = ary[i];
        j = i - 1;

        while (j >= 0 && ary[j] > key)
        {
            ary[j + 1] = ary[j];
            j = j - 1;
            comparisons++;
        }
        comparisons++;
    }
}

//Determine size of file
int determine_size(string filename)
{
    int i = 0;
    int temp[80000];
    ifstream infile;
    infile.open(filename);
    if (infile.fail())
    {
        cout << "File not found! Enter valid Filename" << endl;
    }
    else
    {
        while(!infile.eof())
        {    
            infile >> temp[i];
            i++;
        }
    }
    infile.close();
    return i;
}

//Fill new array 
void fill_array(int ary[], string filename)
{
    int i = 0;

    ifstream infile;
    infile.open(filename);
    if (infile.fail())
    {
        cout << "File not found! Enter valid Filename" << endl;
    }
    else
    {
        while (!infile.eof())
        {
            infile >> ary[i];
            i++;
        }
    }
    infile.close();
}

