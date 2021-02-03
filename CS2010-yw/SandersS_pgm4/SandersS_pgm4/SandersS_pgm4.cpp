//File name: SandersS__pgm4.cpp
//Discription: Pgm4 - World Internet Usage Report
//Author: Sidney Sanders 
//Date: 2/28/2018


#include <iostream>
#include <iomanip>
#include <fstream>
#include <string>

using namespace std;
int main()
{
	//declaring variables
	long long int population = 0, internet2000 = 0, internetCurrent = 0;
	long long int mostInternetUsers = 0;
	double percentPenetration = 0.0, percentGrowth = 0.0, avgPenetration = 0.0, avgGrowth = 0.0;
	string country = " ";
	long long int highestPopulation = 0, most2000Users = 0, mostCurrentUsers = 0, totalPopulation = 0, total2000Users = 0, totalCurrentUsers = 0;
	double highestPenetration = 0.0, highestGrowth = 0.0, totalPenetration = 0.0, totalGrowth = 0.0;
	string highestPopulationName = " ", most2000UserName = " ", mostCurrentUsersName = " ", highestPenetrationName = " ", highestGrowthName = " ";
	int count = 0;

	//opening files
	ifstream infile;
	ofstream outfile;

	infile.open("pgm4.txt");
	outfile.open("pgm4rpt.txt");

	//setting up outfile header 
	outfile << "					World Internet Usage Report" << endl;
	outfile << "						 Sidney Sanders " << endl;
	outfile << " Area " << setw(20) << "Population" << setw(20) << "2000" << setw(20) << "Current" << setw(20) << "(% Pop)" << setw(20) << "Growth %" << endl;
	outfile << "------------------------------------------------------------------------------------------------------------------" << endl;


	//setting decimal point number 
	outfile << fixed << showpoint << setprecision(1);

	//while loop to display variables and find highest functions
	while (infile >> country >> population >> internet2000 >> internetCurrent)
	{

		//calculation penitration and growth
		percentPenetration = ((static_cast<double>(internetCurrent) / static_cast<double>(population))) * 100;
		percentGrowth = ((static_cast<double>(internetCurrent) - static_cast<double>(internet2000)) / static_cast<double>(internet2000)) * 100;

		//displaying variables
		outfile << country << setw(20) << population << setw(20) << internet2000 << setw(20) << internetCurrent << setw(20) << percentPenetration << setw(20) << percentGrowth << endl;
		totalPopulation = totalPopulation + population;
		total2000Users = total2000Users + internet2000;
		totalCurrentUsers = totalCurrentUsers + internetCurrent;
		totalPenetration = totalPenetration + percentPenetration;
		totalGrowth = totalGrowth + percentGrowth;


		// finding highests population
		if (population > highestPopulation) {
			highestPopulation = population;
			highestPopulationName = country;
		}
		//finding most current users
		if (internetCurrent > mostCurrentUsers) {
			mostCurrentUsers = internetCurrent;
			mostCurrentUsersName = country;
		}
		//finding highest penetration percent
		if (percentPenetration > highestPenetration) {
			highestPenetration = percentPenetration;
			highestPenetrationName = country;
		}
		// highest growth percent 
		if (percentGrowth > highestGrowth) {
			highestGrowth = percentGrowth;
			highestGrowthName = country;
		}
		//finding count to be able to find average
		count = count + 1;
	}


	outfile << "------------------------------------------------------------------------------------------------------------------" << endl;

	//finding average penetratioon and growth
	avgPenetration = totalPenetration / count;
	avgGrowth = totalGrowth / count;

	// displayig totals and averages
	outfile << "Total/Avg%" << setw(20) << totalPopulation << setw(20) << total2000Users << setw(20) << totalCurrentUsers << setw(20) << avgPenetration << setw(20) << avgGrowth << endl;
	outfile << "" << endl;

	//displayingto highest with name of country
	outfile << "Area with highest population: " << highestPopulationName << endl;
	outfile << "population: " << highestPopulation << endl;
	outfile << "Area with most internet users: " << mostCurrentUsersName << endl;
	outfile << "Number of users:            " << mostCurrentUsers << endl;
	outfile << "Area with highest Internet penetration: " << highestPenetrationName << endl;
	outfile << "Penetration %: " << highestPenetration << "%" << endl;
	outfile << "Area with highest Internet usage growth: " << highestGrowthName << endl;
	outfile << "Growth %:  " << highestGrowth << "%" << endl;

	//closing files
	infile.close();
	outfile.close();
	//end of program
	system("pause");
	return 0;
}