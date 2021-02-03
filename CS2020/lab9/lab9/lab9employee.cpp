// lab 9
// Description: employee cpp file
// Programmer: Sidney Sanders
// Class: CS 2020, spring 2019


#include "lab9employee.h"
#include <iostream>
#include <iomanip>


//find pay for hourly wage workers
double Employee::pay(double hoursWorked) const
{
	double payTotal;

	payTotal = hoursWorked * payRate;

	return payTotal;
}
