// lab 9
// Description: lab 9 employee header file
// Programmer: Sidney Sanders
// Class: CS 2020, spring 2019

#ifndef LAB9EMPLOYEE_H
#define LAB9EMPLOYEE_H

#include <string>
#include <iomanip>
#include <iostream>

using namespace std;

class Employee
{
protected:
	string name;
	double payRate;

public:
	Employee() { name = ""; payRate = 0.0; };
	Employee(string employeeName, double payAmount) { name = employeeName; payRate = payAmount; };

	void setName(string accociate) { name = accociate; };
	void setPayRate(double pay) { payRate = pay; };

	string getName() { return name; }
	double getPayRate() { return payRate; }

	// should return amount of pay (double) given hours worked as a parameter
	double pay(double hoursWorked) const;

};



#endif // !LAB9EMPLOYEE_H
