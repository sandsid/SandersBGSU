/*
Sidney Sanders
created 11/12/2020

merge sorting files given by user
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
1. Find the middle point to divide the array into two halves
2. Call mergeSort for first half   
3. Call mergeSort for second half
4. Merge the two halves sorted in step 2 and 3
*/
void mergeSort(int[], int, int);

//Merge the two halves 
void merge(int[], int, int, int);

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
	mergeSort(data, 0, size);

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

//Merge Sort 
void mergeSort(int A[], int p, int r)
{
	if (p < r)
	{
		int q = ((p + r) / 2);
		mergeSort(A, p, q);
		mergeSort(A, q + 1, 2);
		merge(A, p, q, r);
	}
}


void merge(int A[], int p, int q, int r)
{
	int i = 0;
	int j = 0;

	int n1 = q - p + 1;
	int n2 = r - q;
	int* L = new int[n1 + 1];
	int* R = new int[n2 + 1];

	for (i = 0; i < n1; i++)
	{
		L[i] = A[p + i - 1];
	}
	for (j = 0; j < n2; j++)
	{
		R[j] = A[q + j];
	}

	//L[n1 + 1] = INT_MAX;
	//R[n2 + 1] = INT_MAX;

	i = 0;
	j = 0;

	for (int k = p; k < r; k++)
	{
		if (L[i] <= R[j])
		{
			A[k] = L[i];
			i++;
		}
		else
		{
			A[k] = R[j];
			j++;
		}
		comparisons++;
	}
	L = nullptr;
	delete L;
	R = nullptr;
	delete R;
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

