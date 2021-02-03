// Program 6
// Description: Program description
// Programmer: Sidney Sanders
// Class: CS 2020, spring 2019

#ifndef TIMEOFF_H
#define TIMEOFF_H

#include <string>
#include <iostream>
#include <iomanip>
#include "numdays.h"
 
using namespace std;

class TimeOff
{
private:
	string name;
	string id;
	int months;
	double maxSickDays;
	double sickTaken;
	double maxVacation;
	double vacTaken;
public:
	TimeOff() { id = ""; name = ""; };
	TimeOff(string num, string employee) { name = employee; id = num; };

	//~TimeOff();

	// Accessors  
	double getSickDays()const { return sickTaken; };
	double getMaxSickDays()const { return maxSickDays; };
	double getVacDays()const { return vacTaken; };
	double getMaxVacDays()const {return maxVacation;};

	//NumDays getVacBalance()const; // These function must utilize operator- overload to  
	//NumDays getSickBalace()const; // subtract vacTaken from maxVacation and sickTaken from        
								  // maxSickDays and return resulting NumDays object    
	// Mutators  
	void setSickDays(int);  // Number of hours is passed to all these methods  
	void setMaxSickDays(int);  // Any additional hours must be added to already accumulated  
	void setMaxVacDays(int);  // hours  
	void setVacDays(int);



	friend ostream& operator<<(ostream &out, const TimeOff &);  //An overloaded >> operator that displays employee time off status

};

#endif