//----------------------------------------------------------------------------
//								Program 2a:		Movie tickets 
//Your name: Sidney Sanders 
//Project name: SandersS_pgm2a						Due: 11:59pm   1/31/18
//
//Purpose:		Program for local movie theater to calculate ticket profit
//Input:		Movie name, amount of adult tickets sold, and the amount of 
//				child tickets sold are going to be asked of the user
//Processing:	Get movie name, adult, child tickets, and assign it to variable
//				Multiply the adult tickets by cost to get total
//				Multiply child tickets by cost to get total  
//				Find the net profit and amount to pay distributer 
//				Display gross ticket cost, net profit, and distributer amount
//Output:		Display gross ticket sales
//				Display theater net profit
//				Display amount paid to distributer 
//-----------------------------------------------------------------------------


#include <iostream>
#include <string>
#include <iomanip>

using namespace std;
int main()
{

	double adultTicket, childTicket, netProfit, distributerAmount, totalTicket;
	string movieName;

	//getting movie, and tickets from user and assigning variables
	cout << "Plase enter name of movie(No Spaces):  ";
	cin >> movieName;
	cout << "Please enter amount of adult tickets sold:  ";
	cin >> adultTicket;
	cout << "Please enter amount of child tickets sold:  ";
	cin >> childTicket;


	//start calculation to find total sales
	cout << endl;
	totalTicket = (adultTicket * 10.00) + (childTicket * 6.00);
	distributerAmount = totalTicket * .8;
	netProfit = totalTicket * .2;



	//Display end totals and costs
	cout << endl;
	cout << setprecision(2) << fixed;
	cout << "Gross Ticket Sales:  $" << totalTicket << endl;
	cout << "Theater Net Profit:  $" << netProfit << endl;
	cout << "Amount Paid to Distributer:  $" << distributerAmount << endl;




	cout << endl;
	system("pause");
	return 0;
}









