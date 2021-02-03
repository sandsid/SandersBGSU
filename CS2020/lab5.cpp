// Lian Sandoval
// Lab 5
// CS 2020 Fall 2018

#include<iostream>
#include<fstream>
#include<iomanip>
#include<string>

using namespace std;

struct Node
{
	string title;
	string genre;
	string rate;
	int copyNum;
	Node* pNext;
};

void createDVDLinkedList(Node* &);
void addNode(Node* &, Node*);
void showDVDInformation(Node*);
void displayDVDLibrary(Node*);
Node* findDVDbyTitle(Node*, string);
void checkOut(Node*, Node*);
void checkIn(Node*, Node*, Node*);
void deleteList(Node*);

int main()
{
	Node* pHead = nullptr;
	int choice = 0;
	string movieTitle = "";
	Node* pTemp = nullptr;
	Node* pNew = nullptr;


	createDVDLinkedList(pHead);
	delete pNew;
	pNew = nullptr;

	do
	{
		cout << "1. Rent" << endl;
		cout << "2. Return" << endl;
		cout << "3. Find" << endl;
		cout << "4. Listing" << endl;
		cout << "5. Quit" << endl;
		cout << "Choice? [1, 2, 3, 4, or 5]: ";
		cin >> choice;
		cout << endl;

		if (choice == 1)
		{
			pTemp = findDVDbyTitle(pHead, movieTitle);
			checkOut(pTemp, pHead);
		}
		else if (choice == 2)
		{
			pTemp = findDVDbyTitle(pHead, movieTitle);
			checkIn(pTemp, pHead, pNew);
		}
		else if (choice == 3)
		{
			pTemp = findDVDbyTitle(pHead, movieTitle);
			showDVDInformation(pTemp);
		}
		else if (choice == 4)
		{
			displayDVDLibrary(pHead);
		}
	} while (choice != 5);

	deleteList(pHead);

	delete pHead;
	delete pTemp;

	
	pHead = nullptr;
	pTemp = nullptr;


	cout << endl;
	//system("pause");
	return 0;
}
void createDVDLinkedList(Node* &pHead)
{
	Node* pNew;
	ifstream infile;

	infile.open("dvds.txt");

	if (infile.is_open())
	{

		while (!infile.eof())
		{
			pNew = new Node;
			pNew->pNext = nullptr;
			getline(infile, pNew->title);
			getline(infile, pNew->genre);
			getline(infile, pNew->rate);
			infile >> pNew->copyNum;
			infile.ignore();

			addNode(pHead, pNew);

		}
		infile.close();
	}
	else
	{
		cout << "ERROR, no file found!" << endl;
	}


}
void addNode(Node* &pHead, Node* pNew)
{
	Node* pTemp= nullptr;

	if (pHead == nullptr)
	{
		pHead = pNew;
	}
	else
	{
		pTemp = pHead;
		while (pTemp->pNext != nullptr)
		{
			pTemp = pTemp->pNext;
		}
		pTemp->pNext = pNew;
	}


}
Node* findDVDbyTitle(Node* pHead, string movieTitle)
{
	Node* pTemp = pHead;
	bool found = false;

	cin.ignore(); 

	cout << "Title? ";
	getline(cin, movieTitle);


	if (found == false)
	{
		pTemp = nullptr;
	}
	else if (pTemp->title == movieTitle)
	{
		found = true;
	}
	else
	{
		while (pTemp != nullptr && found == false)
		{
			if (pTemp->pNext->title == movieTitle)
			{
				found = true;
				pTemp = pTemp;
			}

			pTemp = pTemp->pNext;
		}
	}



	return pTemp;
}
void checkOut(Node* pTemp, Node* pHead)
{

	if (pTemp == nullptr)
	{
		cout << "Movie not found." << endl;
	}
	else if (pTemp == pHead)
	{
		if (pTemp->copyNum > 0)
		{
			pTemp->copyNum = pTemp->copyNum - 1;
		}
		else if (pTemp->copyNum == 0)
		{
			cout << "ERROR: All DVDs are rented out." << endl;
		}
	}
	else if (pTemp != pHead)
	{

		if (pTemp->pNext->copyNum > 0)
		{
			pTemp->copyNum = pTemp->copyNum - 1;
		}
		else if (pTemp->pNext->copyNum == 0)
		{
			cout << "ERROR: All DVDs are rented out." << endl;
		}
		pTemp = pTemp->pNext;

	}

}
void checkIn(Node* pTemp, Node* pHead, Node* pNew)
{
	
	if (pTemp == nullptr)
	{
		cout << "Movie not accepted here." << endl;
	}
	else if (pTemp == pHead)
	{
		pTemp->copyNum = pTemp->copyNum + 1;
	}
	else if (pTemp != pHead)
	{
			pTemp->copyNum = pTemp->copyNum + 1;
			pTemp = pTemp->pNext;
	}


}
void displayDVDLibrary(Node* pHead)
{
	Node* pTemp = pHead;

	cout << left;
	cout <<setw(30) << "Title" << setw(30) << "Genre" << setw(25) << "Rating" << setw(25) << "Count" << endl;
	while (pTemp != nullptr)
	{
		cout << setw(30) << pTemp->title << setw(30) << pTemp->genre << setw(25) << pTemp->rate << setw(25) << pTemp->copyNum << endl;
		pTemp = pTemp->pNext;
	}
	cout << endl;
}
void showDVDInformation(Node* pTemp)
{
	cout << left;
	cout << setw(30) << "Title" << setw(30) << "Genre" << setw(25) << "Rating" << setw(25) << "Count" << endl;

	if (pTemp != nullptr)
	{
		cout << setw(30) << pTemp->title <<setw(30) << pTemp->genre << setw(25) << pTemp->rate << setw(25)<< pTemp->copyNum << endl;
	}
	else if (pTemp == nullptr)
	{
		cout << "Movie not found in library." << endl;
	}
	cout << endl;
}
void deleteList(Node* pHead)
{
	Node* pTemp = pHead;

	while (pTemp != nullptr)
	{
		pHead = pTemp->pNext;
		
		delete pTemp;

		pTemp = pHead;
	}
}