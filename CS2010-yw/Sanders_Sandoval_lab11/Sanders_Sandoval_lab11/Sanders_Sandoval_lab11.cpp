// Description: Lab 11 - Fishers
// Author: Lian Sandoval Sidney Sanders
// Date: 04/6/2018


#include <iostream>
#include <iomanip>
#include <string>
#include <fstream>

using namespace std;

//declaring functions
const int MAX_FISHERS = 23;
void get_fish(int [], int &);
void show_fish(int[], int, int);
int find_best_fisher(int[], int, int, int &, int);

//main function
int main()
{
	//declaring veriables
	int fish[MAX_FISHERS];
	int numFishers = 0;
	int fisherNumber = 1;
	int bestFisher = fish[0];
	int bestFisherNum = 0;

	//calling the get fish function to read in the fishers from the file
	get_fish(fish, numFishers);
	//show fish to display the fhisherman and number of fish
	show_fish(fish, numFishers, fisherNumber);
	//function to find the best fisherman 
	bestFisherNum = find_best_fisher(fish, numFishers, fisherNumber, bestFisher, bestFisherNum);
	cout << "The winner is Fisher " << bestFisherNum << " by catching " << bestFisher << " fish." << endl;

	system("pause");
	return 0;

}

void get_fish(int fish[], int &numFishers)
{
	ifstream infile;
	infile.open("lab11.txt");

	while (!infile.eof())
	{
		infile >> fish[numFishers];
		numFishers = numFishers + 1;	
	}

	infile.close();
}

void show_fish(int fish[], int numFishers, int fisherNumber)
{
	for (numFishers = 0; numFishers < MAX_FISHERS; numFishers++)
	{
		cout << "Fisher:" << std::right << setw(5) << fisherNumber << std::right << setw(10) << "Caught:" << std::right << setw(5)  << fish[numFishers] << std::right << setw(10) << "Fish" << endl;
		fisherNumber = fisherNumber + 1;
	}
}

int find_best_fisher(int fish[], int numFishers, int fisherNumber, int &bestFisher, int bestFisherNum)
{
	bestFisher = 0;
	fisherNumber = 1;
	for (numFishers = 1; numFishers < MAX_FISHERS; numFishers++)
	{
		fisherNumber = fisherNumber + 1;

		if (fish[numFishers] > bestFisher)
		{
			bestFisher = fish[numFishers];
			bestFisherNum = fisherNumber;
			
		}
		 	
	}

	return bestFisherNum;
	
}