//-------------------------------------------------------------------------------
//								Lab 2:	Pizza
//Your name: Sidney Sanders, Lian Sandoval 
//Project name: SandersS_Lab2						Due: 11:59pm   1/19/18
//
//Purpose:		To find the amount of slices from the radius 	
//Input:		Get the radius from the user
//Processing:	Calculate the area
//				Find the amount of slices from the area
//				Display results
//Output:		Display the area 
//				Display the slices
//				Dislay the bonus amount of pizzas
//-------------------------------------------------------------------------------


#include <iostream>

using namespace std;
int main()
{
	//variables 
	int radius, people;
	double area, slices, pizzas;

	//getting radius from user and assigning it to a variable 
	cout << endl;
	cout << "Please enter radius of pizza:   ";
	cin >> radius;
	cout << "Please enter number of people attending:   ";
	cin >> people;
	cout << endl;


	//finding the are and slices able to be cut
	area = (3.14159) * (radius * radius);
	slices = area / 14.125;

	//bonus fiding how many total pizzas needed 
	pizzas = (people * 3) / slices;


	//Display the amount of slices and the amount of pizzas to order
	cout << "The area is: " << area << endl;
	cout << "The number of slices that can be cut: " << slices << endl;
	cout << "The number of pizzas needed:  " << pizzas << endl;


	cout << endl;
	system("pause");
	return 0;
}