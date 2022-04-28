//File name: Sanders_Sandoval_lab7.cpp
//Discription: Lab 7 - ohio universities report
//Author: Sidney Sanders and Lian Sandoval
//Date: 2/23/2018


#include <iostream>
#include <iomanip>
#include <fstream>
#include <string>

using namespace std;
int main()
{
	ifstream infile;
	ofstream outfile;

	string school, city, largestName = "";
	int enrollment, tuition, number, highestTuition = 0;
	int x, total;
	x = 0;
	total = 0;


	infile.open("lab7.txt");
	outfile.open("lab7rpt.txt");

	outfile << "					Ohio Universities report" << endl;
	outfile << "					Sidney Sanders & Lian Sandoval" << endl;
	outfile << " School     City    Enrollement   Tuition" << endl;

	while (infile >> school >> city >> enrollment >> tuition)
	{

		outfile << school << "  " << city << "  " << enrollment << "  $" << tuition << endl;
		x = x + 1;
		total = total + tuition;

		if (tuition > highestTuition)
		{
			highestTuition = tuition;
			largestName = school;
		}
	}

	outfile << "" << endl;
	outfile << "Number of schools:  " << x << endl;
	outfile << "Average tuition;  " << total / x << endl;
	outfile << "Largest tuition coast and school :  " << largestName << "  $" << highestTuition << endl;


	infile.close();
	outfile.close();


	cout << endl;
	system("pause");
	return 0;
}