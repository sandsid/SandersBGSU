// Program 5
// Description:Prog5 cpp file
// Programmer:  Sidney Sanders
// Class:  CS 2020 - spring 2019

#include "prog5.h"
#include <iostream>

using namespace std;

// Function:		isEthylFreezing
// Description:		check to see if the temp freezes ethyl
// Returns:			N/A
void Temperature::isEthylFreezing(int temp)
{
	if (temp <= (-173))
	{
		cout << "Ethyl Alcohol ";
	}
}

// Function:		isEthylBoiling
// Description:		check to see if the temp boils ethyl
// Returns:			N/A
void Temperature::isEthylBoiling(int temp)
{
	if (temp >= (172))
	{
		cout << "Ethyl Alcohol ";
	}
}

// Function:		isOxygenFreezing
// Description:		check to see if the temp freezes oxygen
// Returns:			n/a
void Temperature::isOxygenFreezing(int temp)
{
	if (temp <= (-362))
	{
		cout << "Oxygen ";
	}
}

// Function:		isOxygenBoiling
// Description:		check to see if the temp boils oxygen
// Returns:			n/a
void Temperature::isOxygenBoiling(int temp)
{
	if (temp >= (-306))
	{
		cout << "Oygen ";
	}
}

// Function:		isWaterFreezing
// Description:		check to see if the temp freezes water
// Returns:			n/a
void Temperature::isWaterFreezing(int temp)
{
	if (temp <= (32))
	{
		cout << "Water ";
	}
}

// Function:		isWaterBoiling
// Description:		check to see if the temp boils water
// Returns:			n/a
void Temperature::isWaterBoiling(int temp)
{
	if (temp >= (212))
	{
		cout << "Water ";
	}
}

// Function:		isNitrogenFreezing
// Description:		check to see if the temp freezes nitrogen
// Returns:			n/a
void Temperature::isNitrogenFreezing(int temp)
{
	if (temp <= (-346))
	{
		cout << "Nitrogen ";
	}
}

// Function:		isNitrogenBoiling
// Description:		check to see if the temp boils nitrogen
// Returns:			n/a
void Temperature::isNitrogenBoiling(int temp)
{
	if (temp >= (-320))
	{
		cout << "Nitrogen ";
	}
}


