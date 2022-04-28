// Description: Lab 10 - GCD
// Author: Lian Sandoval Sidney Sanders
// Date: 03/30/2018

#include <iostream>
#include <iomanip>
#include <cmath>
#include <cstdlib>

using namespace std;

//calling the functions
int RNG(int);
int GCD(int, int);

//main
int main()
{
	srand(time(NULL)); // make random numbers everytime program is run

	//constant to start for loop
	const int START_VALUE = 1;
	int END_VALUE;
	int c1, c2, c3, c4, c5, num, rowNum;
	int r1, r2, r3, r4, r5;
	
	//**bonus to ask user for row number
	cout << "Please enter number of rows wanted:";
	cin >> END_VALUE;

	//finding the 5 random numbers for top row in program
	c1 = RNG(num);
	c2 = RNG(num);
	c3 = RNG(num);
	c4 = RNG(num);
	c5 = RNG(num);
	
	cout << endl;

	//initial cout to put out random numbers
	cout << setw(5) << "  GCD |" << setw(10) << c1 << setw(10) << c2 << setw(10) << c3 << setw(10) << c4 << setw(10) << c5 << endl;
	cout << "----------------------------------------------------------" << endl;
	
	//for loop to find the gcd of the random numbers
	for (int i = START_VALUE; i <= END_VALUE; ++i)
	{
		rowNum = RNG(rowNum);
		r1 = GCD(rowNum, c1);
		r2 = GCD(rowNum, c2);
		r3 = GCD(rowNum, c3);
		r4 = GCD(rowNum, c4);
		r5 = GCD(rowNum, c5);
		cout << setw(5) << rowNum  << " |" << setw(9) << r1 << setw(10) << r2 << setw(10) << r3 << setw(10) << r4 << setw(10) << r5 << endl;

	}

	//end of program
	cout << endl;
	system("pause");
	return 0;
}

//rng function to find the random numbers in the program
int RNG(int num)
{
	num = (rand() % (500 - 101 + 1)) + 101;
	return num;
}

//gcd function to do calculations
int GCD(int rowNum, int cNum)
{
	if (rowNum % cNum == 0)
	{
		return cNum;
	}
	else
	{
		return GCD(cNum, rowNum % cNum);
	}
}
