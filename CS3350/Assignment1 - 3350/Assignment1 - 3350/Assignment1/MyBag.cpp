#include <iostream>
#include <string>

#include "MyBag.h"
using namespace std;


template<class ItemType>
inline void MyBag<ItemType>::removeAll(const ItemType& item)
{
	string item;
	cout << "Enter item to be removed:  ";
	cin >> item;

	do {
		remove(item);
	} while (true);

	return true;
}











