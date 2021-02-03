// Program 7 ferry ship cpp file
// Description: Prog 7 types of ships
// Programmer: sidney sanders
// Class: CS 2020, Spring 2019


#include "prog7ferryship.h"
#include <string>
#include <iostream>

using namespace std;


FerryShip::FerryShip(string boat, int built, int maxOcc, int maxCars) : Ship(boat, built)
{
	MAXpass = maxOcc;
	MAXcar = maxCars;
}

// Function: Display Ship
// Description: display info on ship
// Parameters: empty
// Returns: n/a
void FerryShip::displayShip()
{
	Ship::displayShip();
	cout << "FERRY SHIP" << endl;
	cout << "Max # of passengers:       " << MAXpass << endl;
	cout << "Max # of cars:             " << MAXcar << endl;
}
