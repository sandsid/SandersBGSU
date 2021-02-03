// lab 9
// Description:  manager cpp file
// Programmer: Sidney Sanders
// Class: CS 2020, spring 2019

#include "lab9manager.h"

//find pay based on if manager is by salary or hourly
double Manager::pay(double hoursWorked) const
{

	if (salaried == false)
	{
		Employee::pay(hoursWorked);
	}
	else
	{
		return payRate;
	}
}


