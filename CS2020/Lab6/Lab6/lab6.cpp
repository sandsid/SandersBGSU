//***********************************************************************
//Name:				Lab 6 
//Purpose:          fill a node with dvds
//Programmer:		Sidney Sanders
//Class:            cs 2020 -1003 spring 2019              
//***********************************************************************


#include <iostream>
#include <iomanip>
#include <string>
#include <fstream>


using namespace std;

struct Node {
	string title;
	string genre;
	string rating;
	int numCopies;
	Node* pNext;
};



//declaration of functions
void CreateDVDLinkedList(Node* &);
void addNode(Node* &, Node*);
void ShowDVDInformation(Node*);
void DisplayDVDLibrary(Node*);
Node* FindDVDbyTitle(Node*, string);
void CheckOut(Node*, Node*);
void CheckIn(Node*, Node*, Node*);
void DeleteList(Node*);



//***********************************************************************
//				  Main
//***********************************************************************
int main() {
	int choice = 0;
	Node* pHead = nullptr;
	Node* pTemp = nullptr;
	Node* pNew = nullptr;
	Node* dvdTitleptr = nullptr;
	string searchTitle = "";
	
		
	CreateDVDLinkedList(pHead);
	
	do {
		cout << "1.  Rent" << endl;
		cout << "2.  Return" << endl;
		cout << "3.  Find" << endl;
		cout << "4.  Listing" << endl;
		cout << "5.  Quit" << endl;
		cout << "Choice? [1, 2, 3, 4, or 5]:  ";
		cin >> choice;
		if (choice > 5 || choice < 1) {
			cout << endl;
			cout << "Try Picking again" << endl;
			choice = 0;
		}
		else if (choice == 1) {
			pTemp = FindDVDbyTitle(pHead, searchTitle);
			CheckOut(pTemp, pHead);
		}
		else if (choice == 2) {
			CheckIn(pTemp, pHead, pNew);
		}
		else if (choice == 3) {
			
			cout << "Enter movie to search";
			cin >> searchTitle;
			//FindDVDbyTitle(dvdTitleptr, searchTitle);
			
		}
		else if (choice == 4) {
			DisplayDVDLibrary(pHead);
		}
		
	} while (choice != 5);

	DeleteList(pHead);

	system("pause");
	return 0;
}



//***********************************************************************
//Functions:				CreateDVDLinkedList & addNode

//Purpose:              read the data file and create the linked list 
//						of DVD nodes. 
//Programmer:			Sidney Sanders
//Class:                cs 2020 -1003 spring 2019
//Parameter:			node by reference
//Return:               n/a
//***********************************************************************

void CreateDVDLinkedList(Node* &pHead) {
	ifstream infile;
	infile.open("dvds.txt");
	Node* pNew = new Node;

	if (infile.is_open()) {

		while (!infile.eof()) {
			pNew = new Node;
			pNew->pNext = nullptr;

			getline(infile, pNew->title);
			getline(infile, pNew->genre);
			getline(infile, pNew->rating);
			infile >> pNew->numCopies;
			infile.ignore();

			addNode(pHead, pNew);
			
		}//end of while

		infile.close();
	}//end of if
	else {
		cout << "Error! File does not open." << endl;

	}

}//end of function

void addNode(Node* &pHead, Node* pNew) {
	Node* pTemp = new Node;
	
	if (pHead == nullptr) {
		pHead = pNew;
	}
	else {
		pTemp = pHead;
		while (pTemp->pNext != nullptr) {
			pTemp = pTemp->pNext;
		}
		pTemp->pNext = pNew;	
	}

}


//***********************************************************************
//Function:				ShowDVDInformation

//Purpose:				display the DVD information
//Programmer:			Sidney Sanders
//Class:                cs 2020 -1003 spring 2019
//Parameter:			node
//Return:               n/a
//***********************************************************************
void ShowDVDInformation(Node* pTemp) {
	cout << left;
	cout << setw(30) << "Title" << setw(30) << "Genre" << setw(25) << "Rating" << setw(25) << "Count" << endl;

	if (pTemp != nullptr)
	{
		cout << setw(30) << pTemp->title << setw(30) << pTemp->genre << setw(25) << pTemp->rating << setw(25) << pTemp->numCopies << endl;
	}
	else if (pTemp == nullptr)
	{
		cout << "Movie not found in Stock." << endl;
	}
	cout << endl;

}

//***********************************************************************
//Function:				DisplayDVDLibrary

//Purpose:              display all DVDs owned by the store
//Programmer:			Sidney Sanders
//Class:                cs 2020 -1003 spring 2019
//Parameter:			node
//Return:               n/a
//***********************************************************************
void DisplayDVDLibrary(Node* pHead) {
	Node* pTemp = pHead;
	cout << std::left;
	cout << setw(30) << "Title" << setw(20) << "Genre" << setw(10) << "Rating" << setw(10) 
		<< "Count" << endl;
	cout << "__________________________________________________________________" << endl;
	while (pTemp != nullptr) {
		
		cout << setw(30) << pTemp->title << setw(20) << pTemp->genre 
			<< setw(12) << pTemp->rating << setw(10) << pTemp->numCopies << endl;

		cout << endl;
		pTemp = pTemp->pNext;
	} 
}

//***********************************************************************
//Function:				FindDVDbyTitle

//Purpose:              find and return pointer to the appropriate node in
//						the list or nullptr otherwise
//Programmer:			Sidney Sanders
//Class:                cs 2020 -1003 spring 2019
//Parameter:			first node and title to find
//Return:               return pointer to node or nullptr
//***********************************************************************

Node* FindDVDbyTitle(Node* phead, string findTitle) {
	Node* pTemp = phead;
	bool isFound = false;

	cin.ignore();

	cout << "Enter Title:  ";
	getline(cin, findTitle);

	if (pTemp->title != findTitle) {
		isFound = false;
	}
	else if (pTemp->title == findTitle){
		isFound = true;
	}
	else {
		while (pTemp != nullptr && isFound == false) {
			if (pTemp->title == findTitle) {
				isFound = true;
				pTemp = pTemp;
			}
			pTemp = pTemp->pNext;
		}
	}

	return pTemp;
}

//***********************************************************************
//Function:				CheckOut

//Purpose:              decrement number of DVDs currently in the store, 
//						if DVD owned by the store and if not 0 already
//Programmer:			Sidney Sanders
//Class:                cs 2020 -1003 spring 2019
//Parameter:			pointer to DVD node
//Return:               n/a
//***********************************************************************
void CheckOut(Node* pTemp, Node* pHead) {
	
	if(pTemp == pHead) {
		if(pTemp > 0) {
			pTemp->numCopies--;
		}
		else if (pTemp->numCopies == 0) {
			cout << "All Copies being used." << endl;
		}
	}
	else if (pTemp != pHead) {
		if (pTemp->pNext->numCopies > 0)
		{
			pTemp->numCopies = pTemp->numCopies - 1;
		}
		else if (pTemp->pNext->numCopies == 0)
		{
			cout << "ERROR: All DVDs are rented out." << endl;
		}
		pTemp = pTemp->pNext;
	}
	else if (pTemp == nullptr) {
		cout << "No movie found." << endl;

	}

}

//***********************************************************************
//Function:				CheckIn

//Purpose:              increment number of DVDs currently in the store
//						if DVD owned by the store
//Programmer:			Sidney Sanders
//Class:                cs 2020 -1003 spring 2019
//Parameter:			pointer to DVD node
//Return:               n/a
//***********************************************************************
void CheckIn(Node* pTemp, Node* pHead, Node* pNew) {

	if (pTemp == nullptr){
		cout << "Movie not accepted." << endl;
	}
	else if (pTemp == pHead)
	{
		pTemp->numCopies++;
	}
	else if (pTemp != pHead)
	{
		pTemp->numCopies++;
		pTemp = pTemp->pNext;
	}

}

//***********************************************************************
//Function:				DeleteList

//Purpose:              deallocate all memory holding the list
//Programmer:			Sidney Sanders
//Class:                cs 2020 -1003 spring 2019
//Parameter:			pointer to first node
//Return:               n/a
//***********************************************************************
void DeleteList(Node* pHead) {

	Node* pTemp = pHead;

	while (pTemp != nullptr) {
		
		pHead = pTemp->pNext;
		delete pTemp;
		pTemp = pHead;
	}

}