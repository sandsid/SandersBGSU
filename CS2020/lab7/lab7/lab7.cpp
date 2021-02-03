// Lab 7
// Description:Lab 7 cpp file
// Programmer:  Sidney Sanders
// Class:  CS 2020 - spring 2019


#include "lab7.h"
#include <iostream>
#include <iomanip>

using namespace std;

// Function:		displayCCircle
// Description:		prints all information
// Returns:			N/A
void Circle::displayCircle(int r, int x, int y)
{
	cout << "The circle object with radius " << r << " has coordinates (" << x << ", " << y << ")" << endl;

}

// Function:		moveCircle
// Description:		adjust points as called
// Returns:			newpoint
void Circle::moveCircle(int &point, int delta)
{
	point = point + delta;
}

// Function:		displayQuad
// Description:		bonus** display what quadrant point is in
// Returns:			N/A
void Circle::displayQuad(int x, int y)
{
	if (x == 0 && y == 0) {
		cout << "Point is at origin" << endl;
	}
	else if (x > 0 && y > 0) {
		cout << "Q1" << endl;
	}
	else if (x < 0 && y > 0) {
		cout << "Q2" << endl;
	}
	else if (x < 0 && y < 0) {
		cout << "Q3" << endl;
	}
	else {
		cout << "Q4" << endl;
	}
}
