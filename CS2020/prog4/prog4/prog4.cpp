//***********************************************************************
//Name:				Program 4
//Purpose:          Santa Clause's List
//Programmer:		Sidney Sanders
//Class:            cs 2020 -1003 spring 2019              
//***********************************************************************

#include <iostream>
#include <iomanip>
#include <string>
#include <fstream>

using namespace std;


struct Gift
{
	string desc;
	Gift* pNext;
};
struct Nice
{
	string name;
	Nice* pNext;
	Gift* pGiftHead;
};
enum Choice { PRINTNICE = 1, PRINTGIFT, QUIT };

int menu(int);
void createList(Nice* &, string &, Gift* , Nice*);		// Create the nice list
void appendGift(Nice* &, string &, Nice*, Gift*);		// Append to a gift list
//void insertNice(Nice* &, Nice*);		// Insert into the nice list in alpha order by name -- optional
void printGifts(Nice*, string);		// Display a gift list
void printNiceList(Nice*);		// Display the nice list
void destroyGiftList(Nice* &);		// Destroy a list of gifts
void destroyNiceList(Nice* &);		// Destroy the nice list


int main()
{
	Nice* pNiceHead = nullptr;
	Nice* pNiceNew = nullptr;
	Gift* pGiftNew = nullptr;

	int choice = 0;
	string line = "";

	createList(pNiceHead, line, pGiftNew, pNiceNew);

	delete pGiftNew;
	pGiftNew = nullptr;
	delete pNiceNew;
	pNiceNew = nullptr;

	do
	{
		choice = menu(choice);

		if (choice == PRINTNICE)
		{
			printNiceList(pNiceHead);
		}
		else if (choice == PRINTGIFT)
		{
			printGifts(pNiceHead, line);
		}
	} while (choice != QUIT);



	destroyGiftList(pNiceHead);
	destroyNiceList(pNiceHead);

	delete pNiceHead;
	pNiceHead = nullptr;

	cout << endl;
	system("pause");
	return 0;
}

//***********************************************************************
//Functions:			menu

//Purpose:              give the user a choice and validate the input 
//Programmer:			Sidney Sanders
//Class:                cs 2020 -1003 spring 2019
//Parameter:			int choice
//Return:               choice
//***********************************************************************
int menu(int choice)
{
	bool valid = false;
	

	do {
		valid = true;

		cout << endl;
		cout << "1. Print Nice" << endl;
		cout << "2. Print Gifts" << endl;
		cout << "3. Quit" << endl;
		cout << "Your Choice: ";

		cin >> choice;
		cout << endl;
		if (choice < 1 || choice > 3)
		{
			valid = false;
			cout << "ERROR: Please enter choice 1 - 3." << endl;
		}
	} while (valid == false);




	return choice;
}

//***********************************************************************
//Functions:			createList

//Purpose:              read in data from file 
//Programmer:			Sidney Sanders
//Class:                cs 2020 -1003 spring 2019
//Parameter:			node, string, node, node,
//Return:               n/a
//***********************************************************************
void createList(Nice* &pNiceHead, string &line, Gift* pGiftNew, Nice* pNiceNew)
{
	ifstream infile;
	infile.open("prog4.txt");
	
	Nice* pTemp = nullptr;
	if (infile.is_open())
	{
		while (!infile.eof())
		{
			pNiceNew = new Nice;
			pGiftNew = new Gift;
			pNiceNew->pNext = nullptr;
			pGiftNew->pNext = nullptr;
			getline(infile, pNiceNew->name);
			appendGift(pNiceHead, line, pNiceNew, pGiftNew);

		}
		infile.close();
	}
	else
	{
		cout << "ERROR: File not found." << endl;
	}

	delete pTemp;
	pTemp = nullptr;

}


//***********************************************************************
//Functions:			appendGift

//Purpose:              append nice list 
//Programmer:			Sidney Sanders
//Class:                cs 2020 -1003 spring 2019
//Parameter:			node, string, node, node
//Return:               n/a
//***********************************************************************
void appendGift(Nice* &pNiceHead, string &line, Nice* pNiceNew, Gift* pGiftNew)
{
	int start = 0;
	int end = 0;
	string gifts = "";
	Nice* pTemp = nullptr;
	Gift* pTempGift = nullptr;

	line = pNiceNew->name;

	end = line.find(" ", start);
	gifts = line.substr(start, end - start);

	pNiceNew->name = gifts;

	line = line.erase(start, end + 1);

	if (line == " ")
	{
		pGiftNew->desc = "Gift list is empty.";
	}
	else
	{
		pGiftNew->desc = line;
	}

	if (pNiceHead == nullptr)
	{
		pNiceHead = pNiceNew;
		pNiceHead->pGiftHead = pGiftNew;

	}
	else
	{
		pTemp = pNiceHead;
		pTempGift = pNiceHead->pGiftHead;
		while (pTemp->pNext != nullptr)
		{
			pTemp = pTemp->pNext;
			pTempGift = pTempGift->pNext;

		}
		pTemp->pNext = pNiceNew;
		pTempGift->pNext = pGiftNew;
	}
}//end void

 //***********************************************************************
 //Functions:			PrintNiceList

 //Purpose:             print list  
 //Programmer:			Sidney Sanders
 //Class:               cs 2020 -1003 spring 2019
 //Parameter:			phead
 //Return:              n/a
 //***********************************************************************
void printNiceList(Nice* pNiceHead)
{
	Nice* pTemp = pNiceHead;
	int count = 0;

	while (pTemp != nullptr)
	{
		count++;
		cout << right;
		cout << setw(2) << count << ": " << pTemp->name << endl;
		pTemp = pTemp->pNext;
	}

	cout << endl;
}

//***********************************************************************
//Functions:			printGifts

//Purpose:             print gifts  
//Programmer:			Sidney Sanders
//Class:               cs 2020 -1003 spring 2019
//Parameter:			pNiceHead
//Return:              n/a
//***********************************************************************
void printGifts(Nice* pNiceHead, string line)
{
	string kid = "";
	bool found = false;
	Nice* pTemp = nullptr;
	Gift* pTempGifts = nullptr;



	pTemp = pNiceHead;
	pTempGifts = pNiceHead->pGiftHead;

	cout << "Item Category? ";
	cin >> kid;

	if (pTemp->name == kid){
		found = true;
		pTemp = pNiceHead;
		pTempGifts = pNiceHead->pGiftHead;

		if (pTempGifts->desc == "Gift list is empty."){
			cout << kid << "'s gift list is empty." << endl;
			cout << endl;
		}
		else{
			cout << pTempGifts->desc << endl;
		}

	}
	else if (pTemp->name != kid){
		while (pTemp != nullptr && found == false){
			if (pTemp->name == kid){
				
				found = true;

				if (pTempGifts->desc == "Gift list is empty."){
					cout << pTemp->name << " " << pTempGifts->desc << endl;
					cout << endl;
				}
				else{
					cout << pTempGifts->desc << endl;
				}

			}
			else{
				pTemp = pTemp->pNext;
				pTempGifts = pTempGifts->pNext;
			}
		}
	}
	else{
		pTemp = nullptr;
		pTempGifts = nullptr;
	}
}

//***********************************************************************
//Functions:			destroyGifts

//Purpose:             clear data from memory
//Programmer:			Sidney Sanders
//Class:               cs 2020 -1003 spring 2019
//Parameter:			phead
//Return:              n/a
//***********************************************************************
void destroyGiftList(Nice* & pNiceHead)
{
	Gift* pTempGift;

	if (pNiceHead->pGiftHead == nullptr)
	{
		return;
	}
	pTempGift = pNiceHead->pGiftHead;
	pNiceHead->pGiftHead = pNiceHead->pGiftHead->pNext;
	delete pTempGift;

}

//***********************************************************************
//Functions:			destroy nice list

//Purpose:             clear data from memory
//Programmer:			Sidney Sanders
//Class:               cs 2020 -1003 spring 2019
//Parameter:			pNiceHead
//Return:              n/a
//***********************************************************************
void destroyNiceList(Nice* &pNiceHead)
{
	Nice* pTemp;

	if (pNiceHead == nullptr)
	{
		return;
	}

	pTemp = pNiceHead;
	pNiceHead = pNiceHead->pNext;
	delete pTemp;
	pTemp = nullptr;
	destroyNiceList(pNiceHead);
}
