//*********************************************************************
// Lab 3-		Client List
//				-----------
// Discription- Lab creating structures, getting data from a txt file
//					and using data for functions
//Programmer-	Sidney Sanders
//Class			CS 2020-1003 Spring 2019
//*********************************************************************

#include <iostream>
#include <iomanip>
#include <string>
#include <fstream>

using namespace std;

const int MAX_NUM = 50;

//Structure
struct Shareholder
{
	string name;
	string type;
	int amount;
};



//declaring functions
int readFile(Shareholder[]);
void printShares(Shareholder[], int);

int main()
{
	Shareholder clientList[MAX_NUM];
	int clientAmount;

	clientAmount = readFile(clientList);
	

	printShares(clientList, clientAmount);

	system("pause");
	return 0;
}

//***********************************************************************
//Function:		readFile
//
//Purpose:		Read in data from txt file and place in struct
//Programmer:	Sidney Sanders 
//Class:		CS2020-1003 spring 2019
//Parameter:	
//Return:		None
//***********************************************************************

int readFile(Shareholder clientList[]) 
{
	int clientAmount = 0;
	int count = 0;
	ifstream infile;
	infile.open("lab3.txt");

	while (!infile.eof())
	{
		if (count >= MAX_NUM)
		{
			infile.close();
			return clientAmount;
		}
		getline(infile, clientList[count].name);
		getline(infile, clientList[count].type);
		infile >> clientList[count].amount;
		infile.ignore();
		clientAmount++;

	}

	return clientAmount;
}



//***********************************************************************
//Function:		
//
//Purpose:		
//Programmer:	
//Class:		
//Parameter:	
//Return:		
//***********************************************************************

void printShares(Shareholder clientList[], int clientAmount)
{
	double gold = 0, silver = 0, bronze = 0;
	int goldQ = 0, silverQ = 0, bronzeQ = 0;
	
	cout << "Share Type" << setw(15) << "Quanity" << setw(15) << "Value" << endl;
	cout << "==================================" << endl;


	for (int count = 0; count < clientAmount; count++)
	{
		if (clientList[count].type == "Gold")
		{
			gold = gold + (9.95 * clientList[count].amount);
			goldQ = goldQ + clientList[count].amount;
		}
		else if (clientList[count].type == "Silver")
		{
			silver = silver + (5.75 * clientList[count].amount);
			silverQ = silverQ + clientList[count].amount;
		}
		else if (clientList[count].type == "Bronze")
		{
			bronze = bronze + (2.25 * clientList[count].amount);
			bronzeQ = bronzeQ + clientList[count].amount;
		}
	}

	cout << "Gold" << setw(20) << goldQ << setw(15) << gold << endl;
	cout << "Silver" << setw(20) << silverQ << setw(15) << silver << endl;
	cout << "Bronze" << setw(20) << bronzeQ << setw(15) << bronze << endl;

}















//***********************************************************************
//Function:		
//
//Purpose:		
//Programmer:	
//Class:		
//Parameter:	
//Return:		
//***********************************************************************
//***********************************************************************
//Function:		
//
//Purpose:		
//Programmer:	
//Class:		
//Parameter:	
//Return:		
//***********************************************************************
//***********************************************************************
//Function:		
//
//Purpose:		
//Programmer:	
//Class:		
//Parameter:	
//Return:		
//***********************************************************************
//***********************************************************************
//Function:		
//
//Purpose:		
//Programmer:	
//Class:		
//Parameter:	
//Return:		
//***********************************************************************


