/*
Sidney Sanders
created 11/12/2020

quick sorting files given by user
recording time it takes to sort
outputting size of array, number of comparisons, and time recorded

*/


#include<iostream>
#include<fstream>
#include<string>
#include<chrono>
using namespace std;
using namespace chrono;


long long comparisons;

/* 
To sort an array of size n
1. select a 'pivot' element from the array
2. partition the other elements into two sub-arrays
3. The sub-arrays are then sorted recursively
*/
void quickSort(int[], int, int);

/*
This function takes last element as pivot, places
the pivot element at its correct position in sorted array, 
and places all smaller (smaller than pivot) to left of pivot 
and all greater elements to right of pivot
*/
int partition(int[], int ,int);

//Swaps the the integers passed
void swap(int*, int*);

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
	
	high_resolution_clock::time_point start;
	high_resolution_clock::time_point end;
	
	
	int size;
	auto duration = 0;
	string filename = "";

	//get file name from user
	cout << "Enter filename: ";
	cin >> filename;

	size = determine_size(filename);
	int* data = new int[size];
	fill_array(data, filename);

	//initializing comparisons
	comparisons = 0;

	//begin time
	start = high_resolution_clock::now();

	//call the merge sort
	quickSort(data, 0, size);

	//stop the clock
	end = high_resolution_clock::now();

	duration = duration_cast<microseconds>(end - start).count();

	//output the size, the number of comparisons, and the time it took to sort
	cout << size << ",   " << comparisons << ",   " << duration << endl;
	
	
	data = nullptr;
	delete data;


	cout << endl;
	//system("pause");
	return 0;
}

//Quick Sort Using Middle Pivot
void quickSort(int arr[], int low, int high) 
{ 
    if (low < high) 
    { 
        int pivot = partition(arr, low, high); 

        quickSort(arr, low, pivot - 1); 
        quickSort(arr, pivot + 1, high); 
    } 
} 
   


// partition the array using last element as pivot
int partition (int arr[], int low, int high) 
{ 
    int pivot = arr[high];    
    int i = (low - 1);   
   
    for (int j = low; j <= high- 1; j++) 
    { 
        if (arr[j] <= pivot) 
        { 
            i++;    
            swap(&arr[i], &arr[j]); 
			comparisons++;
        } 
		comparisons++;
    } 
    swap(&arr[i + 1], &arr[high]); 
    return (i + 1); 
} 

// Swap two elements 
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
		cout << "Error opening file" << endl;
	}
	else
	{
		while (!infile.eof())
		{
			infile >> temp[i];
			i++;
		}
	}
	infile.close();
	return i;
}

//Fill new array 
void fill_array(int A[], string filename)
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
			infile >> A[i];
			i++;
		}
	}
	infile.close();
}
