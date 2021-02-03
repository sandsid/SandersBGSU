// Program 5
// Description:Prog5CLient cpp file
// Programmer:  Sidney Sanders
// Class:  CS 2020 - spring 2019


#include <iostream>
#include "prog5.h"
#include <iomanip>

using namespace std;

int main()
{
	int temp;
	
	//getting degree
	cout << "This program will tell you what substances freeze or boil at a particular temperature." << endl;
	cout << "Please enter a temperature: ";
	cin >> temp;
	cout << "========================================================================================" << endl<<endl;

	
	//calling class
	Temperature temper(temp);


	//printing freezing substances
	cout << "Substances that freeze at " << temp << ":      ";
	temper.isEthylFreezing(temp);
	temper.isOxygenFreezing(temp);
	temper.isWaterFreezing(temp);
	temper.isNitrogenFreezing(temp);

	cout << endl;
	
	//printing boiling substances 
	cout << "Substances that boil at " << temp << ":        ";
	temper.isWaterBoiling(temp);
	temper.isOxygenBoiling(temp);
	temper.isEthylBoiling(temp);
	temper.isNitrogenBoiling(temp);

	cout << endl;

	system("pause");
	return 0;
}