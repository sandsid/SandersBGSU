//File name: Sanders_Sandoval_lab5.cpp
//Discription: Lab 5 - To determine text message bill
//Author: Sidney Sanders and Lian Sandoval
//Date: 2/9/2018

#include <iostream>
#include <iomanip>

using namespace std;
int main()
{
	
	char checkPackages = 'Y';
	//loop to check pacages as long as user needs
	while (checkPackages == 'Y')
	{
		//assigning variables
		char package = ' ', multiMessages = 1;
		int messages;
		double totalBill, additionalMessages;
		
		//prompting user to input the package
		cout << "What package did you purchase (A, B, C)?";
		cin >> package;	

		//Chacking if the user input the correct package type **bonus
		while (package != 'A' && package != 'B' && package != 'C')
		{
			cout << "Package invalid. " << endl;
			cout << "What package did you purchase (A, B, C)?";
			cin >> package;
		}

		//asking user to input messages
		cout << "How many messages did you send this month?";
		cin >> messages;

		//Checking if user input is valid messages ** bonus
		while (messages < 0)
		{
			cout << "Invalid number of messages!!! " << endl;
			cout << "How many messages did you send this month?";
			cin >> messages;
		}

		//calculations to find total bill
		cout << setprecision(2) << fixed;
		if (package == 'A')
		{
			totalBill = 9.95;
			if (messages > 100)
			{
				additionalMessages = messages - 100;
				additionalMessages = additionalMessages*.15;
				totalBill = 9.95 + additionalMessages;
				totalBill = totalBill + (totalBill)* 0.07 + 1.99;
			}
			cout << "Your Bill:  $ " << totalBill << endl;
			cout << "Would you like to check out another package (Y/N)?";
			cin >> checkPackages;
		}
		else if (package == 'B')
		{
			totalBill = 14.95;
			if (messages > 200)
			{
				additionalMessages = messages - 200;
				additionalMessages = additionalMessages * .10;
				totalBill = 14.95 + additionalMessages;
				totalBill = totalBill + (totalBill)* 0.07 + 1.99;
			}
			cout << "Your Bill:  $ " << totalBill << endl;
			cout << "Would you like to check out another package (Y/N)?";
			cin >> checkPackages;
		}
		else if (package == 'C')
		{
			totalBill = 19.95 + (19.95 *.07) + 1.99;

			cout << "Your Bill:  $ " << totalBill << endl;
			cout << "Would you like to check out another package (Y/N)?";
			cin >> checkPackages;
		}
		else
		{
			//incase program breaks, user gets a message
			cout << "Invalid package input.";
			checkPackages = 'Y';
		}

	}
	
		
	//edn of program
	cout << endl;
	system("pause");
	return 0;
}

