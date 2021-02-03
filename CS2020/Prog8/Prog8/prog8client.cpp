// Program 8   
// Description: Products program       
// Programmer:   Sidney Sanders  
// Class:    CS 2020 Spring 2019 

#include "prog8tower.h"

#include <iostream>
#include <iomanip>



using namespace std;

int main() {
	int diskCount;
	bool pass = false;
	TowersOfHanoi* pGame;
	//getting the disk amount
	cout << "Enter height of tower:     ";
	cin >> diskCount;
	while (pass != true) 
	{
		if (diskCount < 1 || diskCount > 9) 
		{
			cout << "ERROR: disk count must be between 1-9" << endl;
			cout << "Enter height of tower:     ";
			cin >> diskCount;
		}
		else
		{
			pass = true;
		}
	}
	
	//start playing the game

	pGame = new TowersOfHanoi(diskCount);
	pGame->displayTower();
	pGame->moveTower(diskCount, 1, 3, 2);

	delete pGame;


	//system("pause");
	return 0;

}