// lab 9
// Description: Client file 
// Programmer: Sidney Sanders
// Class: CS 2020, spring 2019

//header files included
#include "lab9employee.h"
#include "lab9manager.h"

#include <iomanip>
#include <iostream>
#include <fstream>
#include <string>

using namespace std;

int const MAXEMPLOYEE = 25;

//function 
void PrintPay(Employee*, const double, int);


int main() 
{

	char type;
	string name;
	double pay;
	int count = 0;
	bool salaried;
	int j = 0;
	double hoursWorked = 40;
	Employee *accociates = new Employee[MAXEMPLOYEE];

	//opening file
	ifstream infile;
	infile.open("lab9.txt");

	//checking for file being open
	if (!infile.is_open()) 
	{
		cout << "File Error." << endl;
	}
	else 
	{

		while (count < 2)
		{
			//cout << "stop" << endl;
			type = ' ';
			infile.get(type);
			//cout << type << endl;

			if (type == '1')
			{
				getline(infile, name);
				infile >> pay;
				infile.ignore();
				//cout << name << endl; 
				//cout << pay << endl;

				accociates = new Employee(name, pay);
				PrintPay(accociates, hoursWorked, count);

			}
			else 
			{
				getline(infile, name);
				infile >> pay;
				infile >> salaried;
				infile.ignore();
				//cout << pay << endl;
				//cout << salaried << endl;
				accociates = new Manager(name, pay, salaried);
				PrintPay(accociates, hoursWorked, count);
			}
			count++;
		}
	}
	infile.close(); //lab9.txt
	
	//clearing memory
	delete[] accociates;
	accociates = nullptr;

	//system("pause");
	return 0;
}


//Function: Print Pay
//to print out the data recieved from file 
//programmer: Sidney Sanders
//Cs 2020 spring 2019
void PrintPay(Employee* accociates, const double hoursWorked, int count)
{
	cout << accociates[count].getName() << "     " << "earned" << "     " << "$" << accociates[count].pay(hoursWorked) << endl;
}


