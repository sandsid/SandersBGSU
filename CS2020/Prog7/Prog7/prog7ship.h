// Program 7 ship header file
// Description: Prog 7 types of ships
// Programmer: sidney sanders
// Class: CS 2020, Spring 2019

#ifndef PROG7SHIP_H
#define PROG7SHIP_H
#include <string>

using namespace std;

class Ship
{
private:
	string name;
	int year;
public:
	Ship() { name = ""; year = 0; };
	Ship(string boat, int built) { name = boat; year = built; };

	void setName(string boat) { name = boat; };
	void setYear(int built) { year = built; };

	string getName() { return name; };
	int getYear() { return year; };

	void displayShip() const;


};

#endif