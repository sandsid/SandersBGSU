//File name: Sanders_Sandoval_Lab8.cpp
//Discription: Lab 8 - assess a person's health risk based on his/her blood pressure
//Author: Sidney Sanders and Lian Sandoval
//Date: 3/17/2018



#include <iostream>
#include <iomanip>
#include <fstream>
#include <string>

using namespace std;

int calcMAP(int, int);
string checkMAP(double);
string checkRISK(double);


int main()
{
	
	int systolic = 0, diastolic = 0;
	double map = 0.0;
	string message = "", messageRisk = "";


	cout << "Please enter patient's Systolic blood pressure: ";
	cin >> systolic;
	cout << "Please enter patient's Distolic blood pressure: ";
	cin >> diastolic;
	cout << endl;

	map = calcMAP(systolic, diastolic);
	cout << map << endl;
	message = checkMAP(map);
	cout << message << endl;
	messageRisk = checkRISK(map);
	cout << messageRisk << endl;

	cout << endl;
	system("pause");
	return 0;
}

int calcMAP(int systolic, int diastolic)
{
	int map;
	int difference;

	difference = systolic - diastolic;

	map = (diastolic + (difference /3));

	return map;

}


string checkMAP(double map)
{
	string message = "";

	if (map < 70)
	{
		message = "Hypotension";
	}
	else if (map < 100)
	{
		message = "Normal";
	}
	else if (map < 120)
	{
		message = "Stage 1 hypertension";
	}
	else if (map < 135)
	{
		message = "Stage 2 hypertension";
	}
	else if (map >= 135)
	{
		message = "Stage 3 hypertension";
	}
	else
	{
		message = "Blood presure out of range.";
	}
	return message;
}

string checkRISK(double map)
{
	string messageRisk = "";
	if (map < 70)
	{
		messageRisk = "Moderate";
	}
	else if (map < 110)
	{
		messageRisk = "Low";
	}
	else if (map >= 110)
	{
		messageRisk = "High";
	}
	else
	{
		messageRisk = "Pressure out of range.";
	}

	return messageRisk;
}