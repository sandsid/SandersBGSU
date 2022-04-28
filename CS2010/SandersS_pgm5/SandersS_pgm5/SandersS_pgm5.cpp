//								Program 5:		Virtual Candy Land 
//Your name: Sidney Sanders 
//Project name: SandersS_pgm5				Due: 11:59pm   3/21/18
//
//Purpose:		Take a player through a game of candy land ending exactly on 85.
//Input:		No user imput, computer generats random card numbers for player.
//Processing:	Main function will call separate functions to complete different parts of program
//				random number will be assigned and program will check for candy bonus and change position.
//				game will check to make sure player ends exacly on 85 for end of game by redrawing a card 
//				when redrawn, player will be told untill position is on exaclty 85.
//Output:		Move number, current position, card number, newposition, and a possible candy bonus will be
//				displayed every move the player takes untill game has reached the end.



#include <iostream>
#include <iomanip>
#include <string>
#include <cstdlib> 

using namespace std;
//calling initial functions
void displayHeading();
int drawCard(int);
int movePlayer(int, int, int &, string &);
void displayMove(int, int, int, int, string);

//main processing function
int main()
{
	
	srand(time(NULL));	//makes numbers random everytime program is run

	//calling initian variables and assigning value
	int cardNum = 0, currentPosition = 1, newPosition = 0;
	int moveNum = 0, x = 0;
	string candyBonus = "";
	const int END_GAME = 85;
	
	//displaying heading before game is played
	displayHeading();

	//while loop containing the game process
	while (newPosition < END_GAME)
	{
		
		moveNum = moveNum + 1; // counting each move the player takes
		cardNum = drawCard(cardNum); //cardnum calling the draw card function to get random number 1-5
		movePlayer(currentPosition, cardNum, newPosition, candyBonus); // moving player to find new position and candy bonus
		
		// if statment to make sure player lands exactly on 85
		if (newPosition > END_GAME)
		{
			newPosition = newPosition - cardNum;
			currentPosition = newPosition;
			candyBonus = "   (Must end on 85)";
		}

		//displaying all variables in game
		displayMove(moveNum, currentPosition, cardNum, newPosition, candyBonus);
		
		//switching position and clearing out the candy bonus for next move
		currentPosition = newPosition;
		candyBonus = "";

		//if statement to end the game if the player has reached the 85th tile
		if (newPosition == END_GAME)
		{
			cout << "" << endl;
			cout << "You have made it to the end of Candy Land!!!!" << endl;
			cout << "" << endl;
			system("pause");
			return 0;
		}


	}

}

//first function to display heading for game with categories
void displayHeading()
{
	cout << setw(40) << "Candy Land Game" << endl;
	cout << setw(40) << "Sidney Sanders" << endl;
	cout << setw(47) << "CS 2010, Class Time: 12:30" << endl;
	cout << setw(0) << "Move #" << setw(20) << "Current position" << setw(10) << "Card" << setw(18) << "New Position" << setw(15) << "Candy Bonus" << endl;
}

// draw card function to generate a random number 1-5
int drawCard(int cardNum)
{
	return rand() % 5 + 1;
}

// function to display all the variables 
void displayMove(int moveNum, int currentPosition, int cardNum, int newPosition, string candyBonus)
{
	cout << "--------------------------------------------------------------------------" << endl;
	cout << setw(1) << moveNum << setw(16) << currentPosition << setw(16) << cardNum << setw(14) << newPosition << setw(20) << candyBonus << endl;
}

// function that finds new position and checks to see if player gets candy bonus
int movePlayer(int currentPosition,int cardNum, int &newPosition, string &candyBonus)
{
	newPosition = currentPosition + cardNum;

	if (newPosition == 6)
	{
		newPosition = 40;
		candyBonus = "Rainbow Trail";
	}
	else if (newPosition == 9)
	{
		newPosition = 24;
		candyBonus = "Lord Licorice";
	}
	else if (newPosition == 32)
	{
		newPosition = 43;
		candyBonus = "Gumdrop Pass";
	}
	else if (newPosition == 46)
	{
		newPosition = 58;
		candyBonus = "Mr. Mint";
	}
	else if (newPosition == 62)
	{
		newPosition = 73;
		candyBonus = "Queen Frostine";
	}
	return newPosition;
}