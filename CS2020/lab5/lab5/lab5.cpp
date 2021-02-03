//***********************************************************************
//Name:				Lab 5    

//Purpose:          fill a node array with 10 hands of 5 cards
//Programmer:		Sidney Sanders
//Class:            cs 2020 -1003 spring 2019              
//***********************************************************************
#include <iostream>
#include <iomanip>
#include <string>
#include <time.h>
#include <stdlib.h>


using namespace std;

const int HAND_MAX = 5;
const int NUM_HAND = 10;
//Enums 
enum CardSuit {
	HEARTS, CLUBS, SPADES, DIAMONDS
};

enum FaceCards {
	ACE = 1, JACK = 11, QUEEN, KING
};

struct Card {
	CardSuit suit;
	int value;
};


struct Node {
	Card nodeHand[HAND_MAX];
	Node* pNext;
};


//function declaration
string ShowSuit(CardSuit);
string ShowValue(int);
bool IsUsed(int, Card[], CardSuit, int);

//nodes
void appendNode(Node* &, Node*);
void printNode(Node*);
void deleteNodes(Node* &);



//***********************************************************************
//				  Main
//***********************************************************************
int main() {
	srand(time(NULL));
	int possible;
	bool isFound;
	Card hand[HAND_MAX];
	
	//Node pointers 
	Node* pHead = new Node;
	pHead = nullptr;

	//getting hands 
	for (int i = 0; i < NUM_HAND; i++)
	{
		
		cout << endl << "Hand " << i + 1 << endl;
		for (int i = 0; i < HAND_MAX; i++) {
			
			Node* pNew = new Node;
			pNew->pNext = nullptr;
			
			//adds a random suit to hand
			hand[i].suit = static_cast<CardSuit>(rand() % 4);

			do {
				possible = rand() % 13 + 1;
				isFound = IsUsed(possible, hand, hand[i].suit, i);
				if (!isFound) {
					//sets random value to  hand i 
					hand[i].value = possible;
				}
			} while (isFound);

			string cardSuit, cardValue;
			pNew->nodeHand[i].suit = hand[i].suit;
			pNew->nodeHand[i].value = hand[i].value;
			cout << "Card[" << i + 1 << "]:  " << (cardValue = ShowValue(pNew->nodeHand[i].value)) << " of " << (cardSuit = ShowSuit(pNew->nodeHand[i].suit)) << endl;
			appendNode(pHead, pNew);
			//printNode(pNew);
		}
		
		deleteNodes(pHead);
	}


	system("pause");
	return 0;
}


//***********************************************************************
//Function:				appendNodes    

//Purpose:              point to next node
//Programmer:			Sidney Sanders
//Class:                cs 2020 -1003 spring 2019
//Parameter:			pHead and pNew
//Return:               n/a
//***********************************************************************
void appendNode(Node* & pHead, Node* pNew) {

	Node* pTemp = nullptr;
	
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
//Function:				printNode    

//Purpose:              print the nodes orderly
//Programmer:			Sidney Sanders
//Class:                cs 2020 -1003 spring 2019
//Parameter:			need the pHead 
//Return:               n/a
//***********************************************************************
void printNode(Node* pHead) {

	string cardSuit, cardValue;
	int i = 0;
	Node* pTemp = nullptr;

	//for (int i = 0; i < HAND_MAX; i++) {
	pTemp = pHead;
	//while (pTemp->pNext != nullptr){
	cout << "Card[" << i + 1 << "]:  " << (cardValue = ShowValue(pHead->nodeHand[i].value)) << " of " << (cardSuit = ShowSuit(pHead->nodeHand[i].suit)) << endl;
	//}
	i++;
	//}
}

//***********************************************************************
//Function:				DeleteNodes    

//Purpose:              de-allocate the memory of the nodes
//Programmer:			Sidney Sanders
//Class:                cs 2020 -1003 spring 2019
//Parameter:			pHead Node
//Return:               n/a
//***********************************************************************
void deleteNodes(Node* &pHead) {
	
	Node* pTemp = pHead;
	if (pHead)
	{
		while(pTemp != nullptr)
		{
			pHead = pTemp->pNext;
			delete pTemp;
			pTemp = pHead;
		}
	}
}


//***********************************************************************
//Function:				ShowSuit    

//Purpose:              print summary, and high and low quarter
//Programmer:			Sidney Sanders
//Class:                cs 2020 -1003 spring 2019
//Parameter:			CardSuit
//Return:               string
//***********************************************************************
string ShowSuit(CardSuit suit) {
	//string to_string (CardSuit suit);


	if (suit == HEARTS) {
		return "Hearts";
	}
	else if (suit == DIAMONDS) {
		return "Diamonds";
	}
	else if (suit == CLUBS) {
		return "Clubs";
	}
	else {
		return "Spades";
	}



	//if =1 return string queen

}

//***********************************************************************
//Function:				ShowValue         

//Purpose:              to find the face card or change value to string
//Programmer:			Sidney Sanders
//Class:                cs 2020 -1003 spring 2019
//Parameter:			value of random card number
//Return:               string of suit to be printed
//***********************************************************************
string ShowValue(int value) {
	string num;

	if (static_cast<FaceCards>(value) == true) {
		num = static_cast<FaceCards>(value);
	}

	//return a number or jack, queen, king

	if (value == JACK) {
		return "Jack";
	}
	else if (value == QUEEN) {
		return "Queen";
	}
	else if (value == KING) {
		return "King";
	}
	else if (value == ACE) {
		return "Ace";
	}
	else {
		num = to_string(value);
		return num;
	}

}

//***********************************************************************
//Function:				bool         

//Purpose:              return if card has already been used
//Programmer:			Sidney Sanders
//Class:                cs 2020 -1003 spring 2019
//Parameter:			value of random card number
//Return:               bool 
//***********************************************************************
bool IsUsed(int value2Find, Card hand[], CardSuit suit, int howmany) {
	bool isFound = false;
	int i = 0;

	while (i < howmany - 1 && isFound == false) {
		if (hand[i].value == value2Find && hand[i].suit == suit) {
			isFound = true;
		}
		i++;
	}

	return isFound;
}



