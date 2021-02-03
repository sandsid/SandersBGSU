//************************************************************************
// Prog 2-		
//				-----------
// Discription- 
//Programmer-	Sidney Sanders
//Class			CS 2020-1003 Spring 2019
//************************************************************************


#include <iostream>
#include <iomanip>
#include <string>

using namespace std;


int const MAXCUST = 50;

//structure for customer
struct Customer
{
	int id;
	string name;
	string zip;
	double balance;
	string pmtDate;
};

//functions being declaired
int menu();
int addCust(Customer[], int);
void updateCust(Customer[], int);
void displayCust(Customer[], int);
int findCust(Customer[], int, int);
void sortCust(Customer[], int);

//**********
//
//Main
//
//**********
int main()
{
	Customer custData[MAXCUST];
	int numChoice;
	int currentCust = 0;
	int custFoundId;
	int custSearch;


	numChoice = menu();
	cout << numChoice << endl;
	do {
		
		if (numChoice == 5)
		{
			system("pause");
			return 0;
		}
		else if(numChoice == 1)
		{
			currentCust = addCust(custData, currentCust);
			
		}
		else if (numChoice == 2)
		{
			updateCust(custData, currentCust);
			
		}
		else if (numChoice == 3)
		{
			displayCust(custData, currentCust);
			
		}
		else 
		{
			sortCust(custData, currentCust);
			cout << "Enter id to search:  ";
			cin >> custSearch;
			custFoundId = findCust(custData, currentCust, custSearch);
			if (custFoundId != -1)
			{
				cout << endl << "Customer Found" << endl;
				cout << "---------------" << endl;
				cout << custData[custFoundId].id << endl;
				cout << custData[custFoundId].name << endl;
				cout << custData[custFoundId].zip << endl;
				cout << custData[custFoundId].balance << endl;
				cout << custData[custFoundId].pmtDate << endl;
			}
		}

		numChoice= menu();
	} while (numChoice != 5);

	system("pause");
	return 0;

}


//***********************************************************************
//Function:		Menu
//
//Purpose:		give user options for customer
//Programmer:	Sidney Sanders
//Class:		cs 2020 -1003 spring 2019
//Parameter:	None
//Return:		Valid Number 1-5
//***********************************************************************

int menu()
{
	int numChoice;
	bool validChoice = false;

	cout << std::right << setw(10) << "Menu of Choices" << endl;
	cout << "++++++++++++++++++++++++++++++++++++++" << endl;
	cout << "1. Enter new acount information" << endl;
	cout << "2. Change account information" << endl;
	cout << "3. Display all account information" << endl;
	cout << "4. Find customer" << endl;
	cout << "5. Exit the program" << endl;

	/*while (numChoice >= 1 && numChoice <= 5)
	{
		cout << "Enter  Valid Number Choice:   ";
		cin >> numChoice;
		
	}*/
	
	do 
	{
		cout << "Enter  Valid Number Choice:   ";
		cin >> numChoice;
		
	} while (numChoice < 1 || numChoice > 5);

	return numChoice;
}


//***********************************************************************
//Function:		AddCust
//
//Purpose:		add a customer and add to amount of cusstomers
//Programmer:	Sidney Sanders
//Class:		cs 2020 -1003 spring 2019
//Parameter:	custData array and current customer amount
//Return:		the new customer number
//***********************************************************************

int addCust(Customer custData[], int currentCust)
{

	if (currentCust >= MAXCUST)
	{
		cout << "Max Customers reached" << endl;
		return currentCust;
	}
	else
	{
		cout << "Enter customer id: ";
		cin >> custData[currentCust].id;
		cout << custData[currentCust].id << endl;
		
		cout << "Enter customer name:  ";
		cin.ignore();
		getline(cin, custData[currentCust].name);
		cout << custData[currentCust].name << endl;

		cout << "Enter customer zip:  ";
		getline(cin, custData[currentCust].zip);
		cout << custData[currentCust].zip << endl;

		do {
			cout << "Enter customer positive balance:  ";
			cin >> custData[currentCust].balance;
			cout << custData[currentCust].balance << endl;
		} while (custData[currentCust].balance < 0);

		cout << "Enter customer date:  ";
		cin.ignore();
		getline(cin, custData[currentCust].pmtDate);
		cout << custData[currentCust].pmtDate << endl;

		currentCust++;
	}


	return currentCust;
}


//***********************************************************************
//Function:		updateCust
//
//Purpose:		update curent customer in list
//Programmer:	Sidney Sanders
//Class:		cs 2020 -1003 spring 2019
//Parameter:	custData array and current customer amount
//Return:		None
//***********************************************************************

void updateCust(Customer custData[], int currentCust)
{
	int position = -1;
	int searchID = 0;

	cout << "Enter id to edit customer";
	cin >> searchID;
	position = findCust(custData, currentCust, searchID);
	if (position == -1)
	{
		cout << "Customer does not exist" << endl;
	}
	else
	{
		cout << "Enter new customer name:  ";
		cin.ignore();
		getline(cin, custData[position].name);
		cout << custData[position].name << endl;

		cout << "Enter customer zip:  ";
		getline(cin, custData[position].zip);
		cout << custData[position].zip << endl;
		do {
			cout << "Enter customer positive balance:  ";
			cin >> custData[position].balance;
			cout << custData[position].balance << endl;
		} while (custData[position].balance < 0);

		cout << "Enter customer date:  ";
		cin.ignore();
		getline(cin, custData[position].pmtDate);
		cout << custData[position].pmtDate << endl;

	}

}


//***********************************************************************
//Function:		Display cust 
//
//Purpose:		display list of customers in array
//Programmer:	Sidney Sanders
//Class:		cs 2020 -1003 spring 2019
//Parameter:	custData array and current customer amount
//Return:		None
//***********************************************************************

void displayCust(Customer custData[], int currentCust)
{
	cout << endl << "List of all customers:" << endl;
	cout << "***************************" << endl;

	for (int count = 0; count < currentCust; count++)
	{
		cout << "Customer " << count+1 << endl;
		cout << "-----------" << endl;
		cout << custData[count].id << endl;
		cout << custData[count].name << endl;
		cout << custData[count].zip << endl;
		cout << custData[count].balance << endl;
		cout << custData[count].pmtDate << endl;
	}


}


//***********************************************************************
//Function:		findCust
//
//Purpose:		search array of customers and pass pack position
//Programmer:	Sidney Sanders
//Class:		cs 2020 -1003 spring 2019
//Parameter:	custData array, current customer amount and id to find
//Return:		position where customer is in array
//***********************************************************************

int findCust(Customer custData[], int currentCust, int custSearch)
{
	int position = -1;
	bool found = false;
	int custID;
	int count = 0;

	cout << "Enter Id of customer:  ";
	cin >> custID;

	while (found == false)
	{
		found = true;
		if (currentCust == 0 || currentCust >MAXCUST)
		{
			cout << "No customer found" << endl;
			return position;
		}
		else if(custID == custData[count].id)
		{
			position = custData[count].id;
		}
		else 
		{
			found = false;
			count++;
		}
	}


	return position;
}


//***********************************************************************
//Function:		SortCust
//
//Purpose:		sort all customers in array past
//Programmer:	Sidney Sanders
//Class:		cs 2020 -1003 spring 2019
//Parameter:	custData array and current customer amount
//Return:		None
//***********************************************************************

void sortCust(Customer custData[], int currentCust)
{
	int tempNum;
	string tempString;
	double tempDouble;
	for (int count = 0; count < currentCust; count++)
	{
		
		if (custData[count].id > custData[count + 1].id)
		{
			tempNum = custData[count].id;
			custData[count].id = custData[count + 1].id;
			custData[count + 1].id = tempNum;

			tempString = custData[count].name;
			custData[count].name = custData[count + 1].name;
			custData[count + 1].name = tempString;

			tempString = custData[count].zip;
			custData[count].zip = custData[count + 1].zip;
			custData[count + 1].zip = tempString;

			tempDouble = custData[count].balance;
			custData[count].balance = custData[count + 1].balance;
			custData[count + 1].balance = tempDouble;

			tempString = custData[count].pmtDate;
			custData[count].pmtDate = custData[count + 1].pmtDate;
			custData[count + 1].pmtDate = tempString;
		}
	}
}



