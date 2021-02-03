// Program 6
// Description: 
// Programmer: Sidney Sanders
// Class: CS 2020, spring 2019
#include "timeoff.h"







ostream & operator<<(ostream & out, const TimeOff &temp)
{
	out << "Employee Name: " << temp.name << endl;
	out << "-----------------------------------------------" << endl;
	//out << "Vacation days earned: " << temp.getMaxVacDays << "/" << endl;

	return out;
}
