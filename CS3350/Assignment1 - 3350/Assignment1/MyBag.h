//Created and written by Sidney Sanders
//CS3350 9/13/2019

//implement MyBag.h here
//includes MyBag class declaration 
//		defining MyBag class and remove function

#ifndef MYBAG_H
#define MYBAG_H

#include "ArrayBag.h"


//template and class for MyBag.cpp
template<class ItemType>
class MyBag :public ArrayBag<ItemType>
{
public:
	MyBag();
	bool removeAll(const ItemType& item);
};

#include "MyBag.cpp"
#endif // !MYBAG_H


