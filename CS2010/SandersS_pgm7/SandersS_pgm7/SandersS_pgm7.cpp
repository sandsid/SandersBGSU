//								Program 7:		Miles Per Gallon  
//Your name: Sidney Sanders 
//Project name: SandersS_pgm7				Due: 11:59pm   4/25/18
//
//Purpose:		Progrma to find the MPG of cars after driven for 100 miles
//Input:		Progrma uses a txt file to read in data. aslo asked for user imput on what car to look up
//Processing:	Program uses main function to call 5 other functions that help with the process. readcars functions opens and reads in data, storing
//					it into arrays, then closes file.  findMPG finds the miles per gallon of the cars using the two other arrays.  Displaycars
//					function displays data. FindModel with taje the user input and search the carNames array finding the average gallon usage of the 
//					car searched. SortCars function will use bubble sort method to sort the cars into desendng order using the MPG array. Then program 
//					displays the data again.
//Output:		Program will display data after receiving it from file and finding MPG. then dislay answer to user imput of average car gallon usage,
//					then will display data again ater it is sorted by MPG.

#include <iostream>
#include <iomanip>
#include <string>
#include <fstream>

using namespace std;

const int MAX_NUM = 12;

void readCars(string[], double[], int &);
void findMPG(double[], double[], int);
void displayCars(string[], double[], double[], int);
void findModel(string[], double[], int, string, double &);
void sortCars(string[], double[], double[]);
//call display again to display the new order of array

int main()
{
	int numCars = 0;
	double averageMPG = 0;
	string userModel;
	string carName[MAX_NUM];
	double gallons[MAX_NUM];
	double milesPG[MAX_NUM];

	readCars(carName, gallons, numCars);
	findMPG(gallons, milesPG, numCars);
	cout << setw(32) << "Vehicle Miles Per Gallon" << endl;
	cout << setw(27) << "Sindey Sanders" << endl;
	cout << "Model" << setw(27) << "Gallons used/100 miles" << setw(8) << "MPG" << endl;
	cout << "----------------------------------------" << endl;
	displayCars(carName, gallons, milesPG, numCars);
	cout << endl;
	cout << "Enter model name:  ";
	cin >> userModel;
	findModel(carName, gallons, numCars, userModel, averageMPG);
	sortCars(carName, gallons, milesPG);
	cout << setw(32) << "Vehicle Sorted by MPG" << endl;
	cout << setw(27) << "Sindey Sanders" << endl;
	cout << "Model" << setw(27) << "Gallons used/100 miles" << setw(8) << "MPG" << endl;
	cout << "----------------------------------------" << endl;
	displayCars(carName, gallons, milesPG, numCars);

	system("pause");
	return 0;
}

//function to read in the file and store data into arrays
void readCars(string carName[], double gallons[], int &numCars)
{
	ifstream infile;
	infile.open("pgm7.txt");

	numCars = 0;
	int count = 0;

	while (!infile.eof())
	{
		infile >> carName[count];
		infile >> gallons[count];
		numCars++;
		count++;
	}
	infile.close();
}

//function to find mpg from the gallons used in the first double array and storing 
//answer into the second double array
void findMPG(double gallons[], double milesPG[], int numcars)
{
	int count = 0;

	for (count = 0; count < numcars; count++)
	{
		milesPG[count] = 100.0 / gallons[count];
	}
}

//function display cars will display a title and then in rows the model name, number of gallons, and mpg
void displayCars(string carName[], double gallons[], double milesPG[], int numCars)
{
	int count = 0;
	for (count = 0; count < numCars; count++)
	{
		cout << setprecision(2);
		cout << std::left << setw(10) << carName[count] << std::right << setw(12) << gallons[count] << setw(18) << milesPG[count] << endl;
	}
}

//function find model will check every spot in array for the user model and find average displaying a message
// if the model is found and give the user an average, if not found then tells user model was not tested
void findModel(string carName[], double gallons[], int numCars, string userModel, double &averageMPG)
{
	int count = 0;
	int carsCounted = 0;
	averageMPG = 0;
	for (count = 0; count < numCars; count++)
	{
		if (carName[count] == userModel)
		{
			averageMPG = averageMPG + gallons[count];
			carsCounted++;
		}
	}
	if (averageMPG != 0)
	{
		cout << endl;
		averageMPG = (averageMPG / carsCounted);
		cout << "The average number of gallons used to travel 100 miles by " << userModel << " vehicles was " << averageMPG << " gallons." << endl;
		cout << endl;
	}
	else
	{
		cout << endl;
		cout << "No " << userModel << " vehicles tested." << endl;
		cout << endl;
	}
}

// function sortcars is a function using the bubble sort way to sort from least to greatest gas usage
void sortCars(string carName[], double gallons[], double milesPG[])
{
	double tempGal = 0;
	double tempMPG = 0;
	string tempName = "";
	bool swap = false;
	int size = MAX_NUM;
	do
	{
		swap = false;
		for (int count = 0; count < (size - 1); count++)
		{
			if (milesPG[count] < milesPG[count + 1])
			{
				tempGal = gallons[count];
				gallons[count] = gallons[count + 1];
				gallons[count + 1] = tempGal;
				tempMPG = milesPG[count];
				milesPG[count] = milesPG[count + 1];
				milesPG[count + 1] = tempMPG;
				tempName = carName[count];
				carName[count] = carName[count + 1];
				carName[count + 1] = tempName;
				swap = true;
			}
		}
	} while (swap);
}
