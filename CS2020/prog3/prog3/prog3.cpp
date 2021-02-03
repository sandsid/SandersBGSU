//****************************************************************
//Name--			Program 3
//				
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

// struct declairation
struct Division {
	string dName;
	double q1;	
	double q2;	
	double q3;	
	double q4;	
};

struct Corporation {
	double totalq1;
	double totalq2;
	double totalq3;
	double totalq4;
	int numDiv;
};


//function declaration
void getDivision(Division*, ifstream&);
void printDivision(Division*, Corporation*);
void addDivision(Division*, Corporation*);
void printCorpSummary(Corporation*);


//************
//
//   Main
//
//************
int main() {

	Division* dptr = new Division;
	Corporation* cptr = new Corporation;
	cptr->numDiv = 0;
	cptr->totalq1 = 0;
	cptr->totalq2 = 0;
	cptr->totalq3 = 0;
	cptr->totalq4 = 0;
	
	//begining txt
	cout << "----------------------------------------------------------------------------" << endl;
	cout << "                     Stratus Corporation Sales Report" << endl;
	cout << "                               Sidney Sanders" << endl;
	cout << "----------------------------------------------------------------------------" << endl;
	cout << "Division" << std::right << setw(20) << "Q1" << std::right << setw(15) << "Q2" 
		<< std::right << setw(15) << "Q3" << std::right << setw(15) << "Q4" << endl;
	cout << endl;

	ifstream infile;
	infile.open("prog3.txt");

	if (infile.is_open())
	{
		do {
			getDivision(dptr, infile);
			printDivision(dptr, cptr);
			addDivision(dptr, cptr);

		} while (!infile.eof());
		cout << "-----------------------------------------------------------------------------" << endl;


		printCorpSummary(cptr);
	}


	infile.close();
	
	delete dptr;
	dptr = nullptr;

	delete cptr;
	cptr = nullptr;
	
	system("pause");
	return 0;
}

//***********************************************************************
//Function:				getDivision         
					
//Purpose:              read in a division
//Programmer:			Sidney Sanders
//Class:                cs 2020 -1003 spring 2019
//Parameter:			infile object and division pointer
//Return:               None
//***********************************************************************
void getDivision(Division* dptr, ifstream& infile) {
	
	getline(infile, dptr->dName);
	infile >> dptr->q1;
	infile >> dptr->q2;
	infile >> dptr->q3;
	infile >> dptr->q4;
	infile.ignore();
}

//***********************************************************************
//Function:				printDivision         

//Purpose:              print a division
//Programmer:			Sidney Sanders
//Class:                cs 2020 -1003 spring 2019
//Parameter:			division and corp pointers
//Return:               None
//***********************************************************************
void printDivision(Division* dptr, Corporation* cptr) {

	
	cout << setprecision(2) << fixed << std::left << setw(15) << dptr->dName << std::right << setw(15) << dptr->q1 << setw(15) << dptr->q2 << setw(15) << dptr->q3 << setw(15) << dptr->q4 << endl;


}

//***********************************************************************
//Function:				addDivision         

//Purpose:              add a division to corporate sales amount
//Programmer:			Sidney Sanders
//Class:                cs 2020 -1003 spring 2019
//Parameter:			division and corp pointer
//Return:               None
//***********************************************************************
void addDivision(Division* dptr, Corporation* cptr) {

	cptr->numDiv++;
	cptr->totalq1 = cptr->totalq1 + dptr->q1;
	cptr->totalq2 = cptr->totalq2 + dptr->q2;
	cptr->totalq3 = cptr->totalq3 + dptr->q3;
	cptr->totalq4 = cptr->totalq4 + dptr->q4;
}

//***********************************************************************
//Function:				printCorpSummary         

//Purpose:              print summary, and high and low quarter
//Programmer:			Sidney Sanders
//Class:                cs 2020 -1003 spring 2019
//Parameter:			corp pointer
//Return:               None
//***********************************************************************
void printCorpSummary(Corporation* cptr) {

	double highCorp = cptr->totalq1;
	double lowCorp = cptr->totalq1;

	
	//corp total
	cout << setprecision(2) << fixed << std::left << setw(15) << "Corp Totals:" << std::right << setw(15) << cptr->totalq1 << setw(15) << cptr->totalq2 << setw(15) << cptr->totalq3 << setw(15) << cptr->totalq4 << endl;

	//average per quarter
	cout << setprecision(2) << fixed << std::left << setw(15) << "Avg Qtr Sales:" << std::right << setw(15) << cptr->totalq1/cptr->numDiv << setw(15) << cptr->totalq2/cptr->numDiv << setw(15) << cptr->totalq3/cptr->numDiv << setw(15) << cptr->totalq4/cptr->numDiv << endl;
	cout << endl;

	//total sales
	cout << setprecision(2) << fixed << std::left << setw(15) << "Total Sales:" << std::right << setw(15) << cptr->totalq1 + cptr->totalq2 + cptr->totalq3 + cptr->totalq4 << endl;


	for (int count = 0; count < 4; count++) {
		//finding highest quarter
		if (cptr->totalq2 > highCorp) {
			highCorp = cptr->totalq2;
		}
		else if (cptr->totalq3 > highCorp) {
			highCorp = cptr->totalq3;
		}
		else if (cptr->totalq4 > highCorp) {
			highCorp = cptr->totalq4;
		}

		//finding lowest quarter
		if (cptr->totalq2 < lowCorp) {
			lowCorp = cptr->totalq2;
		}
		else if (cptr->totalq3 < lowCorp) {
			lowCorp = cptr->totalq3;
		}
		else if (cptr->totalq4 < lowCorp) {
			lowCorp = cptr->totalq4;
		}
	}


	//corp high
	cout << setprecision(2) << fixed << std::left << setw(15) << "Corp High Qtr:" << std::right << setw(15) << highCorp << endl;

	//corp low
	cout << setprecision(2) << fixed << std::left << setw(15) << "Corp Low Qtr:" << std::right << setw(15) << lowCorp << endl;

}