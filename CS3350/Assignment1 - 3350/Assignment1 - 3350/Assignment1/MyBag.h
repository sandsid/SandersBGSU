//implement MyBag.h here
#ifndef MYBAG_H
#define MYBAG_H

#include "ArrayBag.h"

template<class ItemType>
class MyBag : public ArrayBag<ItemType>
{
public:
	MyBag : public ArrayBag<ItemType>();
	~MyBag : public ArrayBag<ItemType>();
	bool removeAll(const ItemType& item);
private:

};

#include "MyBag.cpp"
#endif // !MYBAG_H


