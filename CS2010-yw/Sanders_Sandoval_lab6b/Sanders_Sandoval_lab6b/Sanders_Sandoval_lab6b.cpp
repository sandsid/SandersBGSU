//File name: Sanders_Sandoval_lab6b.cpp
//Discription: Lab 6 - results indicated for BGSU’s basketball team
//Author: Sidney Sanders and Lian Sandoval
//Date: 2/16/2018

#include <iostream>
#include <iomanip>

using namespace std;
int main()
{
	//calling variables and defining a constent 
	int gameScore, totalScore, numGames, averagePoints;
	int const END_NUM = -1;

	//making initial input first grab of data
	cout << "Enter points for first game(-1 to end):  ";
	cin >> gameScore;
	totalScore = gameScore;
	

	//start of loop to start asking more scores
	while (gameScore != END_NUM)
	{
		cout << "Enter points for next game (-1 to end):  ";
		cin >> gameScore;
		totalScore = totalScore + gameScore;
		numGames = numGames + 1;

	}

	totalScore = totalScore + 1;
	averagePoints = totalScore / numGames;

	cout << endl;
	//Display the end result of total games 
	cout << "Total points scored:      " << totalScore << endl;
	cout << "Number of games:          " << numGames << endl;
	cout << "Average points per game:  " << averagePoints << endl;





	
	cout << endl;
	system("pause");
	return 0;
}
