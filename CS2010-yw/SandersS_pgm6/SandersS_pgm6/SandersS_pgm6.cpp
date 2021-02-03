//								Program 6:		Tempurture  
//Your name: Sidney Sanders 
//Project name: SandersS_pgm6				Due: 11:59pm   4/9/18
//
//Purpose:		the pupose of this program is to read in tempurtures for 3 consecutiv months and find certain aspects of the data
//Input:		Input comes from the txt file.
//Processing:	the progrma will call a function to read in the datat from a txt file and store it in an array. then it will convert
//					the data from celcius to fahrenhiet. it then finds the average of all the days. it them finds how many days the 
//					tempurature was above average. then it finds the highest temp that occurd in each month.
//Output:		output is the dislays of the months, the average temp, days above average, and the highest temp in each month.

#include <iostream>
#include <iomanip>
#include <string>
#include <fstream>


using namespace std;

// constant temps used thorugh out the program
const int MAX_TEMP = 92;
const int MARCH = 31;
const int APRIL = 61;
const int MAY = 92;

//fuction definitions
void readTemps(double [], int &);
void displayTemps(double [], int, int);
void convertToFahr(double[],int);
int findAvgTemp(double[], int);
int findDaysAboveAvg(double[], int, int);
void findHiTemps(double[], int, int &, int &, int &);

//main function to call other function
int main()
{

	//calling and naming variable used throughout the program
	int tempNum, monthNum, avgTemp, aboveAvgDays;
	int marchHiTemp, aprilHiTemp, mayHiTemp;
	
	//array to hold the temps
	double temps[MAX_TEMP];
	
	//read temps to fill array
	readTemps(temps, tempNum);

	//first month display of March
	monthNum = 1;
	displayTemps(temps, tempNum, monthNum);

	//converting the tempuratures
	convertToFahr(temps, tempNum);

	//displaying the econd month of April
	monthNum = 2;
	displayTemps(temps, tempNum, monthNum);

	//Displaying third month of May
	monthNum = 3;
	displayTemps(temps, tempNum, monthNum);

	//finding and displaying average tempurature
	avgTemp = findAvgTemp(temps, tempNum);
	cout << endl;
	cout << "The average tempurature is: " << avgTemp << "." << endl;

	//finding days that are above average and display
	aboveAvgDays = findDaysAboveAvg(temps, tempNum, avgTemp);
	cout << endl;
	cout << "Number of days the temp was above average: " << aboveAvgDays << "." << endl;

	//finding the highest tempurature within each month and displaying result
	findHiTemps(temps, tempNum, marchHiTemp, aprilHiTemp, mayHiTemp);
	cout << endl;
	cout << "Highest tempurature in March:" << marchHiTemp << endl;
	cout << "Highest tempurature in April:" << aprilHiTemp << endl;
	cout << "Highest tempurature in May  :" << mayHiTemp << endl;


	//end
	system("pause");
	return 0;
}

//readTemps is a function that opens a file then reads the file while putting
//it into an array named temps. then the function will close the file and end.
void readTemps(double temps[], int &tempNum)
{
	ifstream infile;
	infile.open("pgm6.txt");
	tempNum = 0;

	while (!infile.eof())
	{
		infile >> temps[tempNum];
		tempNum = tempNum + 1;
	}
	infile.close();
}

//Displaytemps id a function that will check the month number then diplay that
//months temp by using a for loop design for each month to display the temps 
//only from that month.
void displayTemps(double temps[], int tempNum, int monthNum)
{
	int dayCount = 1;
	if (monthNum == 1)
	{
		cout << "  Temperature for March" << endl;
		cout << "     Sidney Sanders    " << endl;
		cout << endl;
		cout << "    Day      Temperture" << endl;
		cout << "  of month    (celcius)" << endl;
		cout << "  ---------------------" << endl;

		for (tempNum = 0; tempNum < MARCH; tempNum++)
		{
			cout << setprecision(2);
			cout << std::right << setw(6) << dayCount << std::right << setw(14) << temps[tempNum] << endl;
			dayCount++;
		}
		cout << endl;
	}
	else if (monthNum == 2)
	{
		cout << "  Temperature for April" << endl;
		cout << "     Sidney Sanders    " << endl;
		cout << endl;
		cout << "    Day      Temperture" << endl;
		cout << "  of month  (Fahrenhiet)" << endl;
		cout << "  ----------------------" << endl;

		dayCount = 1;
		for (tempNum = 31; tempNum < APRIL; tempNum++)
		{
			cout << setprecision(2);
			cout << std::right << setw(6) << dayCount << std::right << setw(14) << temps[tempNum] << endl;
			dayCount++;
		}
		cout << endl;
	}
	else if (monthNum == 3)
	{
		cout << "  Temperature for May" << endl;
		cout << "     Sidney Sanders    " << endl;
		cout << endl;
		cout << "    Day      Temperture" << endl;
		cout << "  of month  (Fahrenhiet)" << endl;
		cout << "  ----------------------" << endl;

		dayCount = 1;
		for (tempNum = 61; tempNum < MAY; tempNum++)
		{
			cout << setprecision(2);
			cout << std::right << setw(6) << dayCount << std::right << setw(14) << temps[tempNum] << endl;
			dayCount++;
		}
		cout << endl;
	}
}

//convert to fahr is a function that will take the array and reasign the array
//with a converted temp from celcius to fahr.
void convertToFahr(double temps[], int tempNum)
{
	double tempHold, newTemp;
	for (tempNum = 0; tempNum < MAX_TEMP; tempNum++)
	{
		temps[tempNum] = 9.0/5.0*temps[tempNum] +32;
	}

}

//findAvgTemps if a function to go trough the whole array, add them up, then 
//divide by the MAX_Temps to find the average of all the tempuratures.
int findAvgTemp(double temps[], int tempNum)
{
	int avgTemp = 0;

	for (tempNum = 0; tempNum < MAX_TEMP; tempNum++)
	{
		avgTemp = avgTemp + temps[tempNum];
	}
	avgTemp = avgTemp / MAX_TEMP;

	return avgTemp;
}

//finding days above average is a function the takes the array and checks and counts how many days 
//are above the average tempurture then sending it back to the main function
int findDaysAboveAvg(double temps[], int tempNum, int avgTemp)
{
	int aboveAvgDays;

	for (tempNum = 0; tempNum < MAX_TEMP; tempNum++)
	{
		if (temps[tempNum] > avgTemp)
		{
			aboveAvgDays++;
		}
	}
	return aboveAvgDays;
}

//find hi temps if a function that goes through each month and records the highest temp that occurs in 
// each month then sends three different temps back to the main function.
void findHiTemps(double temps[], int tempNum, int &marchHiTemp, int &aprilHiTemp, int &mayHiTemp)
{
	marchHiTemp = 0;
	aprilHiTemp = 0;
	mayHiTemp = 0;

	for (tempNum = 0; tempNum < MARCH; tempNum++)
	{
		if (temps[tempNum] > marchHiTemp)
		{
			marchHiTemp = temps[tempNum];
		}
	}
	for (tempNum = 31; tempNum < APRIL; tempNum++)
	{
		if (temps[tempNum] > aprilHiTemp)
		{
			aprilHiTemp = temps[tempNum];
		}
	}

	for (tempNum = 61; tempNum < MAY; tempNum++)
	{
		if (temps[tempNum] > mayHiTemp)
		{
			mayHiTemp = temps[tempNum];
		}
	}
}