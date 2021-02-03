// Program 7 cruise ship cpp file
// Description: Prog 7 types of ships
// Programmer: sidney sanders
// Class: CS 2020, Spring 2019

#include "prog7cruiseship.h"
#include "prog7ship.h"
#include <string>
#include <iostream>
#include <iomanip>

CruiseShip::CruiseShip(string boat, int built, string shipDate, int maxPeople, int signedUp) : Ship(boat, built)
{
	date = shipDate;
	MAXpass = maxPeople;
	CURpass = signedUp;
}

// Function: Find percentage
// Description: statica cast two integers and return a double percentage
// Parameters: empty
// Returns: percentage
double CruiseShip::findPercentage()
{
	double percent = 0.0;

	//check if percent works correctly 
	percent = (static_cast<double>(CURpass) / static_cast<double>(MAXpass)) * 100;

	return percent;
}

// Function: Display Ship
// Description: display info on ship
// Parameters: empty
// Returns: n/a
void CruiseShip::displayShip(double percent)
{
	
	Ship::displayShip();
	cout << "CRUISE SHIP" << endl;
	cout << "Departing:                 " << date << endl;
	cout << "Max # of Passengers:       " << MAXpass << endl;
	cout << "# of passengers sailing:   " << CURpass << endl;
	cout << "Percent Full:              " << setprecision(4) << percent << "%" << endl;
	
}
