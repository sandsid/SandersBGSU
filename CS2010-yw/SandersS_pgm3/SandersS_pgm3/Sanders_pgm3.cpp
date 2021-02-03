//								Program 3:		Campus Rewards  
//Your name: Sidney Sanders 
//Project name: SandersS_pgm3				Due: 11:59pm   2/14/18
//
//Purpose:		Find the rewards they get after spending money 
//Input:		Program will promped the user to enter the money they spent on entertainment, food, and other.
//				Will aslo ask user the prefered reward after being told point value
//Processing:	After getting inout from the user it will calculate how many points they have earned
//				It will then ask what reward the user wants and then calculate how much of the reward they 
//					can have and find any other rewards and the points left afterward
//Output:		Output will show points earned, and amount of different rewards. giing the user the point leftover also


#include <iostream>
#include <string>
#include <iomanip>

using namespace std;
int main()
{
	//declaring variables 
	int entertainment, food, other, points;
	char reward = ' ';
	int pizza = 0, movie = 0, itunes = 0, pointsAfter;

	//getting input from user to fill variables 
	cout << "Enter dollar amount of your Entertainment purchases: ";
	cin >> entertainment;
	cout << "Enter dollar amount of your Food purchases:          ";
	cin >> food;
	cout << "Enter dollar amount of any other purchase:           ";
	cin >> other;
	cout << endl;

	//finding the amount of points the user has earned
	points = (5 * entertainment + 2 * food + 1 * other);
	pointsAfter = points;

	//displaying points
	cout << "Total number of ponts earned:                       " << points << endl;
	cout << endl;

	//asking user to enter first choice reward
	cout << "Enter your first choice for rewards-(M)ovies, (P)izzas or (I)tunes:  ";
	cin >> reward;


	//finding what user is able to recieve
	if (reward == 'P' || reward == 'p')//to account for upper and lowercase
	{
		//will check with pizza first because it is the prefered reward 
		pizza = points / 300;
		pointsAfter = points - (300 * pizza);
		movie = pointsAfter / 150;
		pointsAfter = pointsAfter - (150 * movie);
		itunes = pointsAfter / 60;
		pointsAfter = pointsAfter - (60 * itunes);

	}
	else if (reward == 'M' || reward == 'm')//to account for upper and lowercase
	{
		//will start with movie skipping over pizza 
		movie = points / 150;
		pointsAfter = points - (150 * movie);
		itunes = pointsAfter / 60;
		pointsAfter = pointsAfter - (60 * itunes);

	}
	else if (reward == 'I' || reward == 'i')//to account for upper and lowercase
	{
		//will only check itunes due to prefrence
		itunes = points / 60;
		pointsAfter = points - (60 * itunes);

	}
	else
	{
		//code incase the user enters wrong reward name
		cout << endl;
		cout << "Reward entered is invalid" << endl;
		cout << endl;
	}

	//end of calculations now displaying results
	cout << endl;
	cout << "Your have earned the following rewards for you credit card purchase!" << endl;
	cout << "  " << pizza << "  Pizzas (300 points each)" << endl;
	cout << "  " << movie << "  Movie rentals (150 points each)" << endl;
	cout << "  " << itunes << "  iTunes downloads (60 points each)" << endl;
	cout << "  " << pointsAfter << "  points left over" << endl;

	//end of program

	cout << endl;
	system("pause");
	return 0;
}