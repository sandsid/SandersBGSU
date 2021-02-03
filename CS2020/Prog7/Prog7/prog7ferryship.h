// Program 7 ferry ship header file
// Description: Prog 7 types of ships
// Programmer: sidney sanders
// Class: CS 2020, Spring 2019



#ifndef PROG7FERRYSHIP_H
#define PROG7FERRYSHIP_H
#include "prog7ship.h"
#include <string>

class FerryShip : public Ship
{
private:
	int MAXpass;
	int MAXcar;
public:
	FerryShip() : Ship() { MAXpass = 0; MAXcar = 0; }
	FerryShip(string boat, int built, int maxOcc, int maxCars);

	void displayShip();
};

#endif // !PROG7FERRYSHIP_H