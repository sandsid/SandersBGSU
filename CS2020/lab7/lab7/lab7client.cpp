// Lab 7 client
// Description:Lab 7 client file
// Programmer:  Sidney Sanders
// Class:  CS 2020 - spring 2019

#include <iostream>
#include "lab7.h"
#include <iomanip>

using namespace std;

int main() {
	int r, x, y;
	int dx, dy;

	cout << "Please enter r, x, y:  ";
	cin >> r;
	cin >> x;
	cin >> y;
	

	//calling class and displaying firt radius and point
	Circle ring(r, x, y);

	ring.displayCircle(r, x, y);
	ring.displayQuad(x, y);

	//begining of moveing the circle
	cout << "Please enter delta x, delta y: ";
	cin >> dx;
	cin >> dy;

	ring.moveCircle(x, dx);
	ring.moveCircle(y, dy);

	ring.displayCircle(r, x, y);
	ring.displayQuad(x, y);


	//end
	//system("pause");
	return 0;
}