//-------------------------------------------------------------------------------
//								Program 1a:		Hello
//Your name: Sidney Sanders 
//Project name: SandersS_pgm1b						Due: 11:59pm   1/17/18
//
//Purpose:		This program finds the average number of cups of hot
//				chocolate sold over a two month period.
//Input:		The user is asked to enter the nummber of cups of hot
//				chocolate sold for each of the two months.
//Processing:	Add the number of hot chocolate cups sold for the two months
//				Divide the results by the number of months to find the 
//					average cups sold per month
//				Display the average number of cups sold.
//Output:		Displays the number of cups of hot chocolate sold per month
//				on the screen.
//-------------------------------------------------------------------------------


#include <iostream>
using namespace std;
int main()
{
	int jancups, febcups, avgcups;
	int months = 0;

	// introduction 
	cout << "Welcome hot chocolate fans! this program calculates";
	cout << " the average number of cups of hot chocolate sold";
	cout << " last year in January and Febuary." << endl << endl;

	// get number of cups of hot chocolate sold for each month
	cout << "Enter the number of cups of hot chocolate sold in January:  ";
	cin >> jancups;
	months = months + 1;

	cout << "Enter the number of cups of hot chocolate sold in Febuary:  ";
	cin >> febcups;
	months = months + 1;

	// calculate average number of cups sold
	avgcups = (jancups + febcups) / months;


	// display average number of cups sold
	cout << endl << "The average number of cups sold was:  " << avgcups << endl << endl;

	cout << endl;
	system("pause");
	return 0;

}

