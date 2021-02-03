//this is the tower of hanoi solution

#include <iostream>

using namespace std; 

//function prototype
void moveDiscs(int, int, int, int);

int main() {

	int NUM_DISCS;
	cout << "Enter Disc count:  ";
	cin >> NUM_DISCS;
	const int FROM_PEG = 1;
	const int TO_PEG = 3;
	const int TEMP_PEG = 2;
	

	//play game
	moveDiscs(NUM_DISCS, FROM_PEG, TO_PEG, TEMP_PEG);
	cout << "All pegs are moved!!" << endl;

	system("pause");
	return 0;
}



void moveDiscs(int num, int fromPeg, int toPeg, int tempPeg)
{
	if (num > 0)
	{
		moveDiscs(num - 1, fromPeg, tempPeg, toPeg);
		cout << "Move a disc from peg " << fromPeg
			<< " to peg " << toPeg << endl;
		moveDiscs(num - 1, tempPeg, toPeg, fromPeg);
	}

}

