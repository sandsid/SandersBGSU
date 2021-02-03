// Program 6
// Description: This program will utilize two classes, NumDays and TimeOff. 
// Programmer: Sidney Sanders
// Class: CS 2020, spring 2019

#include <iomanip>
#include <iostream>
#include <string>
#include "timeoff.h"
#include "numdays.h"


using namespace std;

int main()
{


	TimeOff frodo("12345", "Frodo Baggins");
	//TimeOff someEmployee();
	int months = 4;
	
	// Set up available time off
	
	//frodo.setMaxVacDays(months * 12);
	//frodo.setMaxSickDays(months * 8);
	
	// Record time taken
	//frodo.setVacDays(16); // taken 2 days of vacation
	//frodo.setSickDays(12); // taken 12 hours of sick time
	//					   // Show frodo’s initial status
	cout << frodo << endl;
	// simulate 3 more months of work
	//for (int i = 0; i < 3; i++)
	//{
	//	frodo.setMaxVacDays(12); // 12 hours earned each month
	//	frodo.setMaxSickDays(8);
	//}
	//frodo.setVacDays(24); // 3 days of vacation taken
	//					  // Show frodo’s status
	//cout << frodo << endl;



	//-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
	// TODO: Ask user to provide another employee data
	// id, name, months of employment (between 1 and 6)
	// use someEmployee object to store/display this data
	//-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
	string name;
	string id;


	cout << "Enter Name, ID, Months worked for company:   ";
	cin >> name;
	cin >> id;
	cin >> months;
	TimeOff employee2(id, name);
	cout << employee2;
	

	system("pause");
	return 0;
}