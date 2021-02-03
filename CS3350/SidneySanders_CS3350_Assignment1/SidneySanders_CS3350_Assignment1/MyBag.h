//implement MyBag.h here
#ifndef MYBAG_H
#define MYBAG_H

#include "ArrayBag.h"

template<class ItemType>
class MyBag :public ArrayBag<ItemType>
{
public:
	MyBag();
	bool removeAll(const ItemType& item);
};



#include "MyBag.cpp"

#endif

