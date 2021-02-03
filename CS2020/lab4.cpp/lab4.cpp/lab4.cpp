//****************************************************************
//Name--			Lab 4
//					-------------
//Discription--		Gather client data from file using pointer
//						and display weight range and ideal weight
//Author--			Sidney Sanders
//Class --			CS 2020-1003 Spring 2019
//****************************************************************


#include <iostream>
#include <iomanip>
#include <string>
#include <fstream>

using namespace std;

//client structure
struct Client{
	string name;
	char gender;
	int height;
};


//function declairation 
void readData(Client*);
void printData(Client*);

//************
//
//   Main
//
//************
int main() {

	Client* cptr = new Client;

	readData(cptr);

	system("pause");
	return 0;
}


//***********************************************************************
//Function:             Read Data
//						
//Purpose:              prompt user and get client info
//Programmer:			Sidney Sanders
//Class:                cs 2020 -1003 spring 2019
//Parameter:			client pointer 
//Return:               none
//***********************************************************************
void readData(Client* cptr) {

	ifstream infile;
	infile.open("lab4.txt");

	while (!infile.eof())
	{
		cout << "__________________________________________" << endl;
		getline(infile, cptr->name);
		cout << "Client Name:    " << cptr->name << endl;
		infile >> cptr->gender;
		cout << "CLient Gender:  " << cptr->gender << endl;
		infile >> cptr->height;
		cout << "Client Height:  " << cptr->height << endl;
		infile.ignore();

		printData(cptr);
	}
	infile.close();

}

//***********************************************************************
//Function:             Print Data
//						
//Purpose:              print out vlient info
//Programmer:			Sidney Sanders
//Class:                cs 2020 -1003 spring 2019
//Parameter:			client pointer 
//Return:               none
//***********************************************************************
void printData(Client* cptr) {

	int weight = 0;

	cout << endl;
	cout << "Name:           " << cptr->name << endl;
	cout << "Height:         " << cptr->height << "\"" << endl;
	
	if (cptr->gender == 'M'){
		weight = 106 + 6 * (cptr->height % 60);
	}
	else{
		weight = 100 + 5 * (cptr->height % 60);
		
	};
	cout << "Ideal weight:   " << weight << "#" << endl;
	cout << "Weight range:   " << weight - 15 << "# to " << weight + 15 << "#" << endl;
	cout << endl;
}