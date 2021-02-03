// Program 4
// Description: 
// Sidney Sanders
// Class: CS 2020 Spring 2019

#include<iostream>
#include<iomanip>
#include<string>
#include <fstream>

using namespace std;

struct Item
{
	string type;
	Item* pNextItem;
};
struct Category
{
	string food;
	Category* pNextCat;
	Item* pItemHead;
};
enum Choice {PRINTCAT = 1, PRINTITEM, QUIT};


void createList(Category* &, string &, Item*, Category*);
void processLine(Category* &, string &, Category*, Item*);
//void alphabetizeCat(Category* &);
int menu(int);
void printItems(Category*, string);
void printCategoryList(Category*);
//void destroyItemList(Category* &);
void destroyCategoryList(Category* &);

int main()
{
	Category* pCategoryHead = nullptr;

	Category* pCategoryNew = nullptr;
	Item* pItemNew = nullptr;


	int choice = 0;
	string line = "";

	createList(pCategoryHead, line, pItemNew, pCategoryNew);
	delete pItemNew;
	pItemNew = nullptr;
	delete pCategoryNew;
	pCategoryNew = nullptr;

//	alphabetizeCat(pCategoryHead);

	do
	{
		choice = menu(choice);

		if (choice == 1)
		{
			printCategoryList(pCategoryHead);
		}
		else if (choice == 2)
		{
			printItems(pCategoryHead, line);
		}
	} while (choice != QUIT);



	//destroyItemList(pCategoryHead);
	destroyCategoryList(pCategoryHead);
	
	delete pCategoryHead;
	pCategoryHead = nullptr;

	cout << endl;
	system("pause");
	return 0;
}
void createList(Category* &pCategoryHead, string &line, Item* pItemNew, Category* pCategoryNew)
{
	ifstream infile;
	Category* pTemp = nullptr;

	infile.open("prog4.txt");

	if (infile.is_open())
	{
		while (!infile.eof())
		{
			pCategoryNew = new Category;
			pCategoryNew->pNextCat = nullptr;
			pItemNew = new Item;
			pItemNew->pNextItem = nullptr;
			getline(infile, pCategoryNew->food);

			processLine(pCategoryHead, line, pCategoryNew, pItemNew);

		}
	}
	else
	{
		cout << "ERROR: File not found." << endl;
	}

	delete pTemp;
	pTemp = nullptr;

}
void processLine(Category* &pCategoryHead, string &line, Category* pCategoryNew, Item* pItemNew)
{
	int start = 0;
	int end = 0;
	string word = "";
	Category* pTemp = nullptr;
	Item* pTempI = nullptr;

		line = pCategoryNew->food;

		end = line.find(" ", start);
		word = line.substr(start, end - start);
	
		pCategoryNew->food = word;

		line = line.erase(start, end + 1);

		if (line == " ")
		{
			pItemNew->type = "item not in stock.";
		}
		else
		{
			pItemNew->type = line;
		}

		if (pCategoryHead == nullptr)
		{
			pCategoryHead = pCategoryNew;
			pCategoryHead->pItemHead = pItemNew;

		}
		else
		{
			pTemp = pCategoryHead;
			pTempI = pCategoryHead->pItemHead;
			while (pTemp->pNextCat != nullptr)
			{
				pTemp = pTemp->pNextCat;
				pTempI = pTempI->pNextItem;
				//pTemp = pTemp->pItemHead->pNextItem;
				

			}
			pTemp->pNextCat = pCategoryNew;
			pTempI->pNextItem = pItemNew;
		}

		//delete pTemp;
		//delete pTempI;
		//pTemp = nullptr;
		//pTempI = nullptr;
}
void alphabetizeCat(Category* &pCategoryHead)
{
	Category* pBefore = pCategoryHead;
	Category* pAfter = pCategoryHead->pNextCat;
	Category* pTemp = nullptr;

	Item* pBeforeI = pCategoryHead->pItemHead;
	Item* pAfterI = pCategoryHead->pItemHead->pNextItem;
	Item* pTempI = nullptr;

	bool swap = false;

	do
	{
		swap = false;
		
		while (pAfter->pNextCat != nullptr)
		{
			if (pBefore->food > pAfter->food)
			{
				pTemp = pBefore;
				pBefore = pAfter;
				pAfter = pTemp;

				pTempI = pBeforeI;
				pBeforeI = pAfterI;
				pAfterI = pTempI;

				swap = true;
			}
			pBefore = pBefore->pNextCat;
			pAfter = pAfter->pNextCat;
			pBeforeI = pBeforeI->pNextItem;
			pAfterI = pAfterI->pNextItem;
		}

	} while (swap);

}
void printCategoryList(Category* pCategoryHead)
{
	Category* pTemp = pCategoryHead;
	int count = 0;

	while (pTemp != nullptr)
	{
		count++;
		cout << right;
		cout << setw(2) << count << ": "  << pTemp->food << endl;
		pTemp = pTemp->pNextCat;
	}
	
	cout << endl;
}
void printItems(Category* pCategoryHead, string line)
{
	string catChoice = "";
	bool found = false;
	Category* pTemp = nullptr;
	Item* pTempI = nullptr;

	

	pTemp = pCategoryHead;
	pTempI = pCategoryHead->pItemHead;

	cout << "Item Category? ";
	cin >> catChoice;

	if (pTemp->food == catChoice)
	{
		found = true;
		pTemp = pCategoryHead;
		pTempI = pCategoryHead->pItemHead;

		if (pTempI->type == "item not in stock.")
		{
			cout << pTemp->food << " " << pTempI->type << endl;
			cout << endl;
		}
		else
		{
			cout << pTempI->type << endl;
		}
		
	}
	else if (pTemp->food != catChoice)
	{
		while (pTemp != nullptr && found == false)
		{
			if (pTemp->food == catChoice)
			{
				found = true;

				if (pTempI->type == "item not in stock.")
				{
					cout << pTemp->food << " " << pTempI->type << endl;
					cout << endl;
				}
				else
				{
					cout << pTempI->type << endl;
				}
				//cout << pTempI->type << endl;
				//cout << endl;
			}
			else
			{
				pTemp = pTemp->pNextCat;
				pTempI = pTempI->pNextItem;
			}
		}
	}
	else
	{
		pTemp = nullptr;
		pTempI = nullptr;
	}
}
int menu(int choice)
{
	cout << "1. Print Category" << endl;
	cout << "2. Print Items" << endl;
	cout << "3. Quit" << endl;
	cout << "Choice: ";

	cin >> choice;
	cout << endl;

	if (choice > 3 || choice < 1)
	{
		cout << "ERROR: Invalid choice. Please re-enter choice 1-3." << endl;
		choice = menu(choice);
	}

	return choice;
}
void destoryItemList(Category* &pCategoryHead)
{
	Item* pTempI;

	if (pCategoryHead->pItemHead == nullptr)
	{
		return;
	}
	pTempI = pCategoryHead->pItemHead;
	pCategoryHead->pItemHead = pCategoryHead->pItemHead->pNextItem;
	delete pTempI;
	
	//destroyItemList(pCategoryHead);
}
void destroyCategoryList(Category* &pCategoryHead)
{
	Category* pTemp;
	//Item* pTempI = pCategoryHead->pItemHead;

	if (pCategoryHead == nullptr)
	{
		return;
	}
	pTemp = pCategoryHead;
	//pTempI = pCategoryHead->pItemHead;
	pCategoryHead = pCategoryHead->pNextCat;
	//pCategoryHead->pItemHead = pCategoryHead->pItemHead->pNextItem;
	delete pTemp;
	//delete pTempI;

	destroyCategoryList(pCategoryHead);
}

