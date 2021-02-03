// lab 9
// Description: Manager header file
// Programmer: Sidney Sanders
// Class: CS 2020, spring 2019


#ifndef LAB9MANAGER_H
#define LAB9MANAGER_H

#include "lab9employee.h"
#include <string>
#include <iostream>
#include <iomanip>

using namespace std;

class Manager : public Employee
{
private:
	bool salaried;
public:
	Manager(string name, double payRate, bool salary) : Employee(name, payRate) { salaried = salary; }


	bool getSalaried() { return salaried; }

	// should return amount of pay (double) given hours worked as a parameter
	double pay(double hoursWorked) const;
	

};

#endif // !LAB9MANAGER_H