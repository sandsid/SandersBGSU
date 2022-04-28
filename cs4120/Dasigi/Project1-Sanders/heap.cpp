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


void heapSort(int[], int);
void heapify(int[], int, int);

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

        comparisons = 0;

        startTime = high_resolution_clock::now();
        heapSort(data, size);
        endTime = high_resolution_clock::now();


        duration = duration_cast<microseconds>(endTime - startTime).count();

        cout << size << " " << comparisons << " " << duration << endl;
        data = nullptr;
        delete data;
    }
    
    cout << endl;
    return 0;
}

void heapSort(int ary[], int n)
{
  for (int i = n / 2 - 1; i >= 0; i--)
    heapify(ary, n, i);

  for (int i = n - 1; i > 0; i--) {
    swap(ary[0], ary[i]);

    heapify(ary, i, 0);
  }
}
void heapify(int ary[], int n, int i)
{
    int largest = i; 
    int l = 2 * i + 1; 
    int r = 2 * i + 2; 

    if (l < n && ary[l] > ary[largest]){
        largest = l;
        comparisons++;
    }

    if (r < n && ary[r] > ary[largest]){
        largest = r;
        comparisons++;
    }

    if (largest != i) {
        swap(ary[i], ary[largest]);
        heapify(ary, n, largest);
    }
}

void swap(int* a, int* b) 
{ 
    int t = *a; 
    *a = *b; 
    *b = t; 
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
