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

void mergeSort(int[], int, int);
void merge(int[], int, int, int);


int determine_size(string);
void fill_array(int[], string);


int main()
{
	
	high_resolution_clock::time_point start;
	high_resolution_clock::time_point end;
	
	
	int size;
	auto duration = 0;
	string fileArray[12] = {"rand-1000.txt", "rand-2000.txt", "rand-4000.txt", "rand-8000.txt",
                            "reverse-1000.txt", "reverse-2000.txt", "reverse-4000.txt", "reverse-8000.txt",
                            "sorted-1000.txt", "sorted-2000.txt", "sorted-4000.txt", "sorted-8000.txt",};
    string filename = "";

	for (int i = 0; i < 12; i++)
	{
		filename = fileArray[i];
		size = determine_size(filename);
		int* data = new int[size];
		fill_array(data, filename);
		comparisons = 0;

		start = high_resolution_clock::now();
		mergeSort(data, 0, size);
		end = high_resolution_clock::now();

		duration = duration_cast<microseconds>(end - start).count();

        cout << size << " " << comparisons << " " << duration << endl;
		
		data = nullptr;
		delete data;
	}

	return 0;
}

//Merge Sort 
void mergeSort(int ary[], int p, int r)
{
	if (p < r)
	{
		int q = ((p + r) / 2);
		mergeSort(ary, p, q);
		mergeSort(ary, q + 1, r);
		merge(ary, p, q, r);
	}
}


void merge(int ary[], int p, int q, int r)
{
	int i = 1;
	int j = 1;
	int n1 = q - p + 1;
	int n2 = r - q;
	int* L = new int[n1 + 1];
	int* R = new int[n2 + 1];

	for (i = 1; i < n1; i++)
	{
		L[i] = ary[p + i - 1];
	}
	for (j = 1; j < n2; j++)
	{
		R[j] = ary[q + j];
	}

	i = 1;
	j = 1;

	for (int k = p; k < r; k++)
	{
		if (L[i] <= R[j])
		{
			ary[k] = L[i];
			i++;
		}
		else
		{
			ary[k] = R[j];
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
		cout << "File not found!" << endl;
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

