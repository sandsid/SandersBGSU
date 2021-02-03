// Program 7 client cpp
// Description: Prog 7 types of ships
// Programmer: sidney sanders
// Class: CS 2020, Spring 2019

#include <iostream>
#include <iomanip>
#include <string>
#include <fstream>

#include "prog7ship.h"
#include "prog7cruiseship.h"
#include "prog7ferryship.h"

using namespace std;

int main() {

	string boat = "", date = "";
	int built = 0, maxOccupancy = 0, maxCarHold = 0, signedUp = 0;
	char type;
	double percent;

	fstream infile;
	infile.open("prog7.txt");
	if (!infile.is_open()) {
		cout << "File error. " << endl;
	}//end if
	else {
		
		Ship *ship = new Ship("Flying Dutchman", 1795);
		ship->displayShip();

		CruiseShip * cruise = new CruiseShip("Titanic", 1912, "4/10/12", 2200, 1324);
		percent = cruise->findPercentage();
		cruise->displayShip(percent);

		FerryShip *ferry = new FerryShip("Barberi", 1981, 6000, 0);
		ferry->displayShip();


		while (!infile.eof()) {
			
			infile.get(type);
			infile.ignore();			
			if (type == 'S') {

				getline(infile, boat);
				infile >> built;
				infile.ignore();
				Ship *ship = new Ship(boat, built);
				ship->displayShip();

				delete ship;
				ship = nullptr;

			}//end if
			else if (type == 'C') {
				getline(infile, boat);
				infile >> built;
				infile.ignore();
				getline(infile, date);
				infile >> maxOccupancy;
				infile >> signedUp;
				infile.ignore();
				CruiseShip *cruise = new CruiseShip(boat, built, date, maxOccupancy, signedUp);
				percent = cruise->findPercentage();
				cruise->displayShip(percent);

				delete cruise;
				cruise = nullptr;
			}
			else {
				getline(infile, boat);
				infile >> built;
				infile.ignore();
				infile >> maxOccupancy;
				infile >> maxCarHold;
				infile.ignore();

				FerryShip *ferry = new FerryShip(boat, built, maxOccupancy, maxCarHold);
				ferry->displayShip();
				
				delete ferry;
				ferry = nullptr;
			}
		

		}//end while
	}//end else



	system("pause");
	return 0;
}