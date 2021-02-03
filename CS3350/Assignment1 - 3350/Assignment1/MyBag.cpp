//Created and written by Sidney Sanders
//CS3350 9/13/2019

//MyBag.cpp file
//implimenting MyBag.h file
//includes removeAll function 
//		takes all instances of item out of bag
//includes empty MyBag constructor


#include <iostream>
#include <string>
#include<iomanip>

#include "MyBag.h"
using namespace std;



template<class ItemType>
MyBag<ItemType>::MyBag()
{
}//empty constructor

template<class ItemType>
bool MyBag<ItemType>::removeAll(const ItemType & item)
{
	//first instance removed/checked if exists
	bool status = this->remove(item);

	//finding the rest of the instances if they exist
	if (status == true)
	{
		while (status == true)
			status = this->remove(item);
	}

	return false; //returning false to show no more instances exist

}//end of removeAll Bool






