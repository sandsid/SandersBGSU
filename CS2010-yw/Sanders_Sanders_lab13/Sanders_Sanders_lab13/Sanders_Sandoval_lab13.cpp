// Lian Sandoval Sidney Sanders  April 20, 2018  SandersSandoval_Lab13


#include <iostream>
#include <string>
#include <fstream>
#include <cmath>
#include <iomanip>

using namespace std;

const int MAX_NUM = 8;

void readSalsa(string[], int[], int);
void displaySales(string[], int[], int, int);
int searchSales(string[], int[], int, string, int);
void bubbleSort(string[], int[], int);

int main()
{
	string salsaType[MAX_NUM];
	int salsaJars[MAX_NUM];
	int count = 0;
	int total = 0;
	string salsa = "";
	int position = -1;


	readSalsa(salsaType, salsaJars, count);
	displaySales(salsaType, salsaJars, count, total);
	cout << "What kind of salsa are you looking for? ";
	cin >> salsa;
	position = searchSales(salsaType, salsaJars, count, salsa, position);
	if (position > -1)
	{
		cout << "There were " << salsaJars[position] << " jars of " << salsa << "sold last month." << endl;
	}
	else
	{
		cout << "Salsa type " << salsa << " was not found." << endl;
	}
	bubbleSort(salsaType, salsaJars, count);
	displaySales(salsaType, salsaJars, count, total);

	cout << endl;
	system("pause");
	return 0;
}
void readSalsa(string salsaType[], int salsaJars[], int count)
{
	ifstream infile;

	infile.open("lab13_salsa.txt");
	for (count = 0; count < MAX_NUM; count++)
	{
		infile >> salsaType[count];
		infile >> salsaJars[count];
	}
	infile.close();
}
void displaySales(string salsaType[], int salsaJars[], int count, int total)
{
	cout << "Ele #" << setw(15) << "Salsa Type" << setw(14) << "Jars Sold" << endl;
	for (count = 0; count < MAX_NUM; count++)
	{
		cout << count << setw(15) << salsaType[count] << setw(14) << salsaJars[count] << endl;
		total = total + salsaJars[count];
	}
	cout << "Total Jars Sold:   " << total << endl;
}
int searchSales(string salsaType[], int salsaJars[], int count, string salsa, int position)
{
	bool found = false;
	while (count < MAX_NUM && !found)
	{
		if (salsaType[count] == salsa)
		{
			found = true;
			position = count;
		}
		count++;
	}
	return position;
}
void bubbleSort(string salsaType[], int salsaJars[], int count)
{
	int maxNum;
	bool swap = false;
	int size = 8;
	int temp;
	string tempName;

	do
	{
		swap = false;
		for (int count = 0; count < (size - 1); count++)
		{
			if (salsaJars[count] < salsaJars[count + 1])
			{
				temp = salsaJars[count];
				salsaJars[count] = salsaJars[count + 1];
				salsaJars[count + 1] = temp;
				tempName = salsaType[count];
				salsaType[count] = salsaType[count + 1];
				salsaType[count + 1] = tempName;
				swap = true;
			}
		}
	} while (swap);

}
