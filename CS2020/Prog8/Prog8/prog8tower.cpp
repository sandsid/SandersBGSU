// Program 8  tower cpp file
// Description: Products program       
// Programmer:   Sidney Sanders  
// Class:    CS 2020 Spring 2019 

#include "prog8tower.h"
#include "prog8disk.h"
#include <iostream>
#include <iomanip>

using namespace std;


string TowersOfHanoi::convert(int count)
{
	string tower;

	if (count == 1)
	{
		tower = "A";
	}
	else if (count == 2) 
	{
		tower = "B";
	}
	else
	{
		tower = "C";
	}
	return tower;
}

TowersOfHanoi::TowersOfHanoi(int count)
{
	
	pAhead = nullptr;
	pBhead = nullptr;
	pChead = nullptr;
	Disc *pTemp = nullptr;
	Disc *pNew = nullptr;

	while(count != 0)
	{
		pNew = new Disc(count);

		if (pAhead->getPtr() == nullptr)
		{
			pAhead->setPointer(pNew);
		}
		else
		{
			pTemp = pAhead;
			while (pTemp->getPtr() != nullptr)
			{
				pTemp = pTemp->getPtr();
			}
			pTemp->setPointer(pNew);
		}
		delete pTemp;
		count--;
	}
	
	
}


void TowersOfHanoi::displayTower()
{
	// displaying tower A
	Disc *pATemp = pAhead;
	cout << "A: ";
	while (pATemp != nullptr)
	{
		cout << pATemp->getWeight();

		pATemp = pATemp->getPtr();
	}
	cout << endl;
	
	//Displaying tower B
	Disc *pBTemp = pBhead;
	cout << "B:  ";
	while (pBTemp != nullptr)
	{
		cout << pBTemp->getWeight();

		pBTemp = pBTemp->getPtr();
	}
	cout << endl;

	//Display tower C
	Disc *pCTemp = pChead;
	cout << "C:  ";
	while (pCTemp != nullptr)
	{
		cout << pCTemp->getWeight();

		pCTemp = pCTemp->getPtr();
	}
	cout << endl;

	delete pATemp;
	delete pBhead;
	delete pCTemp;

	pATemp = nullptr;
	pBTemp = nullptr;
	pCTemp = nullptr;
}

void TowersOfHanoi::moveDisc(int source, int destination)
{
	Disc *pSource = nullptr;
	Disc *pDestination = nullptr;
	Disc *pTemp = nullptr;

	moves++;

	if (source == 1)
	{
		pSource = pAhead;
		if (pAhead != nullptr) {
			while (pSource->getPtr() != nullptr){
				pSource = pSource->getPtr();
			}
			pDestination = pSource;
			delete pSource;
			pSource = nullptr;
		}
		
	}
	else if (source == 2){
		pSource = pBhead;
		if (pBhead != nullptr) {
			while (pSource->getPtr() != nullptr){
				pSource = pSource->getPtr();
			}
			pDestination = pSource;
			delete pSource;
			pSource = nullptr;
		}
	}
	else if (source == 3){
		pSource = pChead;
		if (pChead != nullptr) {
			while (pSource->getPtr() != nullptr){
				pSource = pSource->getPtr();
			}
			pDestination = pSource;
			delete pSource;
			pSource = nullptr;
		}
	}
	else {
		cout << "ERROR in move disc Function, source number not within approprite range." << endl;
	}

	if (destination == 1){
		if (pAhead == nullptr){
			pAhead = pDestination;
		}
		else {
			pTemp = pAhead;
			while (pTemp->getPtr() != nullptr) {
				pTemp = pTemp->getPtr();
			}
			pTemp->setPointer(pDestination);
		}

	}
	else if (destination == 2){
		if (pBhead == nullptr) {
			pBhead = pDestination;
		}
		else {
			pTemp = pBhead;
			while (pTemp->getPtr() != nullptr) {
				pTemp = pTemp->getPtr();
			}
			pTemp->setPointer(pDestination);
		}
	}
	else if (destination == 3){
		if (pChead == nullptr) {
			pChead = pDestination;
		}
		else {
			pTemp = pChead;
			while (pTemp->getPtr() != nullptr) {
				pTemp = pTemp->getPtr();
			}
			pTemp->setPointer(pDestination);
		}
	}
	else {
		cout << "ERROR in move disc Function, destination number not within approprite range." << endl;
	}


}

void TowersOfHanoi::moveTower(int num, int fromPeg, int toPeg, int tempPeg)
{
	if (num > 0) 
	{
		TowersOfHanoi::moveTower(num - 1, fromPeg, tempPeg, toPeg);
		TowersOfHanoi::moveDisc(fromPeg, toPeg);
		TowersOfHanoi::displayTower();
		TowersOfHanoi::moveTower(num - 1, tempPeg, toPeg, fromPeg);
	}
}

