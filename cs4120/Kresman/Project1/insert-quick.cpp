/*
CS 4120 - Spring 2022
Sidney Sanders, Noah Jackson, Lucas Hufford

 Who did what
Noah:  worked on the code associated with managing the heap allocated 2d arrays
       and on fill_array() which reads our random number from file and stores in array
Sidney: Worked on the functions for the algorithms and dataset generation into the three
		separate files, 10 arrays in each.
Lucas:	Worked on the code managing the cpu time collection, the data reporting. Worked 
		on quick sort funtion implinentation.

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
void insertionSort(int, int**, int);
//quicksort takes the row number, the 2d array, the low and high.
void quickSort(int, int**, int, int);
//takes the row and the 2d array, low and high number
int partition_random(int, int**, int, int);
//takes the row and the 2d array, low and high number
int partition(int, int**, int ,int);

//takes the array, and filename and fills a 2d array and returns
void fill_array(int**, string);


int main(int argc, char* argv[])
{
	//algo computation time variables
	high_resolution_clock::time_point startTime;
	high_resolution_clock::time_point endTime;
	auto int time = 0;

	int size = 0;

	//file array to store random numbers
	string fileArray[4] = { "5000rand.txt", "25000rand.txt", "50000rand.txt", "outFile.txt" };
	string filename = " ";

	//random number generator variables
	int seed = 2;
	srand(seed);
	string userDecision = argv[1];
    
	//D  generates the datasets (10 sets for each size) and dumps them to a file(s)
	if (userDecision == "D")
	{
		ofstream outfile;

		//creation of  10 - 5000 int datasets.
		size = 5000;
		outfile.open(fileArray[0]);
		int count = 0;
		for (int i = 0; i < 10; i++)
		{
			do
			{
				int temp = rand() % 1000000 + 1;
				outfile << temp << "\n";
				count++;
			} while (count < size);
			outfile << "next\n";
			count = 0;
		}
		outfile.close();
		cout << "Dataset for size: " << size << " generated.";
		cout << endl;

		//creation of  10 - 25000 int datasets.
		size = 25000;
		outfile.open(fileArray[1]);
		for (int i = 0; i < 10; i++)
		{
			do
			{
				int temp = rand() % 1000000 + 1;
				outfile << temp << "\n";
				count++;
			} while (count < 25000);
			outfile << "next\n";
			count = 0;
		}
		outfile.close();
		cout << "Dataset for size: " << size << " generated.";
		cout << endl;

		//creation of  10 - 50000 dataset.
		size = 50000;
		outfile.open(fileArray[2]);
		for (int i = 0; i < 10; i++)
		{
			do
			{
				int temp = rand() % 1000000 + 1;
				outfile << temp << "\n";
				count++;
			} while (count < 50000);
			outfile << "next\n";
			count = 0;
		}
		outfile.close();
		cout << "Dataset for size: " << size << " generated.";
		cout << endl;


	}
	//S sorts the dataset using the algorithms and produces comma separated output
	else if (userDecision == "S")
	{
		//Outfile to hold data results.
		ofstream resultFile;
		resultFile.open(fileArray[3]);


		//==================================
		//  5000 LENGTH ARRAY Insertion Sort
		//==================================
		
		//allocating memory for the array that will hold the pointers to data arrays
		int** a2d_5000 = new int* [10];

		//declaring the array
		//must be deleted later with a for loop
		for (int i = 0; i < 10; i++)
		{
			a2d_5000[i] = new int[5000];
		}

		//calling fill on [10][5000] array
		fill_array(a2d_5000, fileArray[0]);

		//5000 length array results header
		cout << "Insertion sort 5000 length array results" << endl;
		resultFile << "Insertion sort 5000 length array results" << endl;
		
		//call insertion for each row of 2d array
		for (int i = 0; i < 10; i++)
		{
			startTime = high_resolution_clock::now();
			insertionSort(i, a2d_5000, 5000);
			endTime = high_resolution_clock::now();
			
			//cpu time for computation of each dataset
			time = duration_cast<microseconds>(endTime - startTime).count();

			//output: I for Insertion, Q for Quick sort
			cout << "I, " << (i + 1) << ", " << "5000, " << comparisons << ", " << time << ", 12497500" << endl;
			resultFile << "I, " << (i + 1) << ", " << "5000, " << comparisons << ", " << time << ", 12497500" << endl;
		}

		cout << endl;
		
		//delete data arrays and array of pointers
		for (int i = 0; i < 10; i++)
		{
			delete[] a2d_5000[i];
		}
		delete[] a2d_5000;


		//===================================
		//  25000 LENGTH ARRAY Insertion Sort
		//===================================
		
		//allocating memory for the array that will hold the pointers to data arrays
		int** a2d_25000 = new int* [10];

		//declaring the array
		//must be deleted later with a for loop
		for (int i = 0; i < 10; i++)
		{
			a2d_25000[i] = new int[25000];
		}


		//calling fill on [10][25000] array
		fill_array(a2d_25000, fileArray[1]);

		//5000 length array results header
		cout << "Insertion sort 25000 length array results" << endl;
		resultFile << "Insertion sort 25000 length array results" << endl;

		//call insertion for each row of 2d array
		for (int i = 0; i < 10; i++)
		{
			startTime = high_resolution_clock::now();
			insertionSort(i, a2d_25000, 25000);
			endTime = high_resolution_clock::now();
	
			//cpu time for computation of each dataset
			time = duration_cast<microseconds>(endTime - startTime).count();

			//output: I for Insertion, Q for Quick sort
			cout << "I, " << (i + 1) << ", " << "25000, " << comparisons << ", " << time << ", 312497500"<< endl;
			resultFile << "I, " << (i + 1) << ", " << "25000, " << comparisons << ", " << time << ", 312497500"<< endl;
		
		}
		cout << endl;

		
		//delete data arrays and array of pointers
		for (int i = 0; i < 10; i++)
		{
			delete[] a2d_25000[i];
		}
		delete[] a2d_25000;


		//===================================
		//  50000 LENGTH ARRAY Insertion Sort
		//===================================
		
		//allocating memory for the array that will hold the pointers to data arrays
		int** a2d_50000 = new int* [10];

		//declaring the array
		//must be deleted later with a for loop
		for (int i = 0; i < 10; i++)
		{
			a2d_50000[i] = new int[50000];
		}

		//calling fill on [10][50000] array
		fill_array(a2d_50000, "50000rand.txt");

		//5000 length array results header
		cout << "Insertion sort 50000 length array results" << endl;
		resultFile << "Insertion sort 50000 length array results" << endl;
		
		//call insertion for each row of 2d array
		for (int i = 0; i < 10; i++)
		{
			//Should we add startTime and endtime for quicksort
			startTime = high_resolution_clock::now();
			insertionSort(i, a2d_50000, 50000);
			endTime = high_resolution_clock::now();
			
			//cpu time for computation of each dataset
			time = duration_cast<microseconds>(endTime - startTime).count();

			//output: I for Insertion, Q for Quick sort
			cout << "I, " << (i + 1) << ", " << "50000, " << comparisons << ", " << time << ", 1249975000" << endl;
			resultFile << "I, " << (i + 1) << ", " << "50000, " << comparisons << ", " << time << ", 1249975000" << endl;
		
		}

		cout << endl;

		//delete data arrays and array of pointers
		for (int i = 0; i < 10; i++)
		{
			delete[] a2d_50000[i];
		}
		delete[] a2d_50000;


		//==============================
		//  5000 LENGTH ARRAY Quick Sort
		//==============================

		//allocating memory for the array that will hold the pointers to data arrays
		int** a2d_5000Q = new int* [10];

		//declaring the array
		//must be deleted later with a for loop
		for (int i = 0; i < 10; i++)
		{
			a2d_5000Q[i] = new int[5000];
		}
		
		cout << "Quicksort sort for 5000 length array results" << endl;
		resultFile << "Quicksort sort for 5000 length array results" << endl;


		fill_array(a2d_5000Q, fileArray[0]);

		for (int i = 0; i < 10; i++)
		{
			comparisons= 0;
			startTime = high_resolution_clock::now();
			quickSort(i, a2d_5000Q, 0, 5000);
			endTime = high_resolution_clock::now();

			//cpu time for computation of each dataset
			time = duration_cast<microseconds>(endTime - startTime).count();

			cout << "Q, " << (i + 1) << ", " << "5000, " << comparisons << ", " << time << ", 12497500" << endl;
		    resultFile << "Q, " << (i + 1) << ", " << "5000, " << comparisons << ", " << time << ", 12497500" << endl;
		     
		}

		cout << endl;
		
		//delete data arrays and array of pointers
		for (int i = 0; i < 10; i++)
		{
			delete[] a2d_5000Q[i];
		}
		delete[] a2d_5000Q;


		//===============================
		//  25000 LENGTH ARRAY Quick Sort
		//===============================

		int** a2d_25000Q = new int* [10];

		//declaring the array
		//must be deleted later with a for loop
		for (int i = 0; i < 10; i++)
		{
			a2d_25000Q[i] = new int[25000];
		}

		//calling fill on [10][25000] array
		fill_array(a2d_25000Q, fileArray[1]);

		//5000 length array results header
		cout << "Quicksort 25000 length array results" << endl;
		resultFile << "Quicksort 25000 length array results" << endl;

		//call insertion for each row of 2d array
		for (int i = 0; i < 10; i++)
		{
			comparisons = 0;
			startTime = high_resolution_clock::now();
			quickSort(i,a2d_25000Q,0, 25000);
			endTime = high_resolution_clock::now();
	
			//cpu time for computation of each dataset
			time = duration_cast<microseconds>(endTime - startTime).count();

			cout << "Q, " << (i+1) << ", " << "25000, " << comparisons << ", " << time << ", 312487500 " << endl;
			resultFile << "Q, " << (i+1) << ", " << "25000, " << comparisons << ", " << time << ", 312487500 " << endl;
		
		}

		//delete data arrays and array of pointers
		for (int i = 0; i < 10; i++)
		{
			delete[] a2d_25000Q[i];
		}
		delete[] a2d_25000Q;

		cout << endl;

		//==============================
		//  50000 LENGTH ARRAY Quick Sort
		//==============================

		//allocating memory for the array that will hold the pointers to data arrays
		int** a2d_50000Q = new int* [10];

		//declaring the array
		//must be deleted later with a for loop
		for (int i = 0; i < 10; i++)
		{
			a2d_50000Q[i] = new int[50000];
		}

		fill_array(a2d_50000Q, fileArray[2]);
		
		cout << "Quicksort 50000 length array results" << endl;
		resultFile << "Quicksort 50000 length array results" << endl;

		//call Quick sort for each row of 2d array
		for (int i = 0; i < 10; i++)
		{
			comparisons = 0;
			startTime = high_resolution_clock::now();
			quickSort(i, a2d_50000Q, 0, 50000);
			endTime = high_resolution_clock::now();

			//cpu time for computation of each dataset
			time = duration_cast<microseconds>(endTime - startTime).count();

			//output: I for Insertion, Q for Quick sort
			cout << "Q, " << (i + 1) << ", " << "50000, " << comparisons << ", " << time << ", 1249975000" << endl;
			resultFile << "Q, " << (i + 1) << ", " << "50000, " << comparisons << ", " << time << ", 1249975000" << endl;
		
		}

		cout << endl;

		//delete data arrays and array of pointers
		for (int i = 0; i < 10; i++)
		{
			delete[] a2d_50000Q[i];
		}
		delete[] a2d_50000Q;

	}
	else
	{
		//fail safe if the input doesnt match D or S
		cout << "There has been an error in input." << endl;
		return 0;
	}
	
	return 0;
}

//Quick Sort
//needs to accept 2d array : low and high pivot
void quickSort(int row, int **ary, int low, int high)
{
    if (low < high) {
 
        int q = partition(row, ary, low, high);
        quickSort(row, ary, low, q - 1);
        quickSort(row, ary, q + 1, high);
    }
}

int partition(int row, int **ary, int low, int high)
{
    int pivot = ary[row][high]; 

    int i = (low - 1); 
 
    for (int j = low; j <= high - 1; j++) 
    {
        if (ary[row][j] <= pivot) 
        {
            i++; 
            swap(ary[row][i], ary[row][j]);
			comparisons++;
        }
		comparisons++;
    }

    swap(ary[row][i + 1], ary[row][high]);
    return (i + 1);
}

void swap(int* a, int* b) 
{ 
    int t = *a; 
    *a = *b; 
    *b = t; 
} 

//Insertion Sort
//needs to accept 2d array :
//accepts the row number so that the algorithm can run normal while only 
//checking one array at a time
void insertionSort(int row, int **ary, int length)
{
	//resets the comparisons between each iteration.
	comparisons = 0;

	int key, j;
	//int row;

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
//reads each line as a string from the file
//comapres the string with the trigger, if != to the trigger
//convert to a integer and add to the array
//if it does equal the array, increment the row, and continure to read from the file
//do not add trigger to the array. 
void fill_array(int **ary, string filename)
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
			//This ensures file reading stops before error is caused
			//without this the while loop does not terminate at the right time
            //and an error is caused at "ary[row][col] = stoi(temp);"
			//we could probably figure out why but this also seems to work
			if (row == 10) {
				break;
			}

			//read in the line from the file
			getline(infile, temp);
			//check the string against the trigger
			if (temp == trigger)
			{
				//increment row
				row++;
				//reset col to 0
				col = 0;
			}
			else
			{
				//convert string to integer and assign to array
				ary[row][col] = stoi(temp);
				//col is incremented
				col++;
			}
		}
	}
	infile.close();

}
