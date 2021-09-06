/*
Sidney Sanders
created 10/31/2020

insertion sorting files given by user
recording time it takes to sort
outputting size of array, number of comparisons, and time recorded

*/


#include<iostream>
#include<fstream>
#include<chrono>
#include<string>


using namespace std;
using namespace chrono;

//count for comparisons made by algorythm 
long long comparisons;

/*
To sort an array of size n
1: Iterate from ary[1] to arr[length]
2: Compare element (key) to its predecessor.
3: If  key element is smaller than its predecessor, 
   compare it to the elements before. 
4:Move the greater elements one position up to make 
    space for the swapped element.
*/
void insertionSort(int[], int);

/*
To determine size of file
1:Open file given by user
2:read file and increment i until EOF
3:Return i 
*/
int determine_size(string);

/*
To fill the new array
1:Open file passed to function
2:
*/
void fill_array(int[], string);



int main()
{
    
    high_resolution_clock::time_point startTime;
    high_resolution_clock::time_point endTime;
    
    
    int size;
    auto duration = 0;
    string filename = "";

    //getting file name from user
    cout << "Enter Filename: ";
    cin >> filename;


    size = determine_size(filename);
    int* data = new int[size];
    fill_array(data, filename);

    //initializing comparisons
    comparisons = 0;

    //begin time 
    startTime = high_resolution_clock::now();

    //call the sorting algorythm 
    insertionSort(data, size);

    //stop the time clock
    endTime = high_resolution_clock::now();


    duration = duration_cast<microseconds>(endTime - startTime).count();

    //output the size, the number of comparisons, and the time it took to sort
    cout << size << ",   " << comparisons << ",   " << duration << endl;
    
    
    data = nullptr;
    delete data;


    cout << endl;
    //system("pause");
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

