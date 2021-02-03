// Program 8  tower header file
// Description: Products program       
// Programmer:   Sidney Sanders  
// Class:    CS 2020 Spring 2019 

#ifndef PROG8TOWER_H
#define PROG8TOWER_H



#include <iostream>
#include <string>
#include "prog8disk.h"


class TowersOfHanoi
{
private:
	int count;
	int moves;
	Disc *pAhead;
	Disc *pBhead;
	Disc *pChead;
	std::string convert(int);
public:
	// Function: TowersOfHanoi   
	// Description: constructor function     
	// Parameters: count of discs  
	// Returns:  n/a
	TowersOfHanoi(int count);
	~TowersOfHanoi();

	// Function: displayTower   
	// Description: displays pegs annd contents     
	// Parameters: empty  
	// Returns:  n/a
	void displayTower();

	// Function: moveDiscs   
	// Description: move disc from the source to the destination
	// Parameters: source and destination peg  
	// Returns:  n/a
	void moveDisc(int, int);

	// Function: move tower   
	// Description: entire game, recursive function      
	// Parameters: discs,from,to, temp   
	// Returns:  n/a
	void moveTower(int, int, int, int);
};




#endif