//-------------------------------------------------------------------------------
//								Program 1a:		Hello
//Your name: Sidney Sanders 
//Project name: SandersS_pgm1a						Due: 11:59pm   1/17/18
//
//Purpose:		This program displays a hello greeting including the user's name
//Input:		Ask the user to enter his/her name and last name.
//Processing:	Get the user's name.
//				Display a greeting and the user's name.
//Output:		Displays a hello greeting and the user's firs and last name.
//				in a box of asterisks on the screen
//-------------------------------------------------------------------------------

#include <iostream>
#include <string>
using namespace std;

int main()
{
	string firstname, lastname, major;

	//get user's name 

	cout << "please enter your first name:  ";
	cin >> firstname;
	cout << "Please enter your last name:   ";
	cin >> lastname;
	cout << "Please enter your major:   ";
	cin >> major;


	//Display the hello greeting

	cout << endl;
	cout << "*****************************************************" << endl;
	cout << "**                     Hello                       **" << endl;
	cout << "**                 " << firstname << " " << lastname << "                  **" << endl;
	cout << "**                 " << major << "                 **" << endl;
	cout << "*****************************************************" << endl;

	cout << endl;
	system("pause");
	return 0;

}

