// Program 7 ship cpp
// Description: Prog 7 types of ships
// Programmer: sidney sanders
// Class: CS 2020, Spring 2019

#include <iomanip>
#include <string>
#include <iostream>
#include "prog7ship.h"

// Function: Display Ship
// Description: display info on ship
// Parameters: empty
// Returns: n/a
void Ship::displayShip() const
{
	cout << "----------------------------------------------" << endl;
	cout << "Ship:                      " << name << endl;
	cout << "Year:                      " << year << endl;
	cout << endl;
	
}
