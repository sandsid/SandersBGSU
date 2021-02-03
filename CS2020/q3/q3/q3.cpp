#include <iostream>
#include <iomanip>
#include <string>
#include <time.h>
#include <stdlib.h>
using namespace std;


//Enums 
enum CardSuit {
	HEARTS, CLUBS, SPADES, DIAMONDS
};

enum FaceCards {
	ACE = 1, JACK = 11, QUEEN, KING
};

//Structure to hold hand of max cards
struct Card {
	CardSuit suit;
	int value;
};

//function delcaration 
string ShowSuit(CardSuit);
string ShowValue(int);
bool IsUsed(int, Card[], CardSuit, int);



//************
//
//   Main
//
//************
int main() {
	srand(time(NULL));
	int randomValue;
	const int HAND_MAX = 5;
	bool isFound;
	Card hand[HAND_MAX];

	for (int i = 0; i < HAND_MAX; i++) {

		hand[i].suit = static_cast<CardSuit>(rand() % 4);
		do {
			randomValue = rand() % 13 + 1;
			isFound = IsUsed(randomValue, hand, hand[i].suit, i);
			if (!isFound) {
				hand[i].value = randomValue;
			}
		} while (isFound);
	}

	string cardSuit, cardValue;


	for (int i = 0; i < HAND_MAX; i++) {
		cout << "Card[" << i << "]:  " << (cardValue = ShowValue(hand[i].value)) << " of "
			<< (cardSuit = ShowSuit(hand[i].suit)) << endl;
	}
	return 0;

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