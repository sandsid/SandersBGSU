// Program 7 cruise ship header file
// Description: Prog 7 types of ships
// Programmer: sidney sanders
// Class: CS 2020, Spring 2019


#ifndef PROG7CRUISESHIP_H
#define PROG7CRUISESHIP_H

#include "prog7ship.h"
#include <string>

using namespace std;


class CruiseShip :public Ship
{
private:
	string date;
	int MAXpass;
	int CURpass;
public:
	CruiseShip() : Ship() { date = ""; MAXpass = 0; CURpass = 0; };
	CruiseShip(string boat, int built, string shipDate, int maxPeople, int signedUp);

	double findPercentage();
	void displayShip(double percent);
};

#endif // !PROG7CRUISESHIP_H