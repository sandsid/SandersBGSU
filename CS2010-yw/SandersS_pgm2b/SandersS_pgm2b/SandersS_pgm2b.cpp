//----------------------------------------------------------------------------
//								Program 2b:		Car Rental 
//Your name: Sidney Sanders 
//Project name: SandersS_pgm2b						Due: 11:59pm   1/31/18
//
//Purpose:		Program for a local car rental agency that calculates rental charges
//Input:		Getting the days rented and the begining and nding OD reading
//Processing:	Get the variables from the user
//				Start calculations to find the daily amount total
//				Find the milage charge
//				Figure in taxes and fees, add and find the total cost
//				Display results to user
//Output:		Display the charges for the days, milage, and taxes
//				Display the total charge for the car rental
//-----------------------------------------------------------------------------


#include <iostream>
#include <iomanip>

using namespace std;
int main()
{

	//defining variables
	int daysRented, beginingODReading, endingODReading;
	double dailyCharge, milageCharge, taxesNfees, totalcost;

	//prompting the user and assigning variables
	cout << "Please enter number of days rented:  ";
	cin >> daysRented;
	cout << "Enter the beginning odometer reading:  ";
	cin >> beginingODReading;
	cout << "Enter the ending odometer reading:  ";
	cin >> endingODReading;
	cout << endl;

	//doing calculations to find the price total
	dailyCharge = daysRented * 15.00;
	milageCharge = (endingODReading - beginingODReading) * .12;
	taxesNfees = (dailyCharge + milageCharge) * .25;
	totalcost = dailyCharge + milageCharge + taxesNfees;

	//Display end charge amount
	cout << fixed << showpoint << setprecision(2);
	cout << "Daily rental charge:   $" << dailyCharge << endl;
	cout << "Milage charge:         $" << milageCharge << endl;
	cout << "Taxes and fees:        $" << taxesNfees << endl;
	cout << endl;
	cout << "Total bill:            $" << totalcost << endl;


	cout << endl;
	system("pause");
	return 0;
}
