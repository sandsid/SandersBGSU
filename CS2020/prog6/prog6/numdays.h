// Program 6
// Description: NumDays which will represent number of work hours and automatically 
//				convert the hours to number of days
// Programmer: Sidney Sanders
// Class: CS 2020, spring 2019

#ifndef NUMDAYS_H
#define NUMDAYS_H


#include "timeoff.h"
#include<iostream>


class NumDays
{
private:
	int hours;
	double days;
public:
	
	NumDays() { hours = 0; days = 0; };
	NumDays(int time) { hours = time; days = time / 8; };
	//~NumDays();

	// Mutators
	void setHours(int time) { hours = time; };
	void setDays(int time) { days = time; };
	// Accessors
	int getHours() const { return hours; };
	double getDays() const { return days; };

	// Operator overloads 
	//search book starting on page 837
	NumDays operator-(const NumDays &) const;  
	//NumDays operator++();  
	//NumDays operator++(int); 

};

#endif