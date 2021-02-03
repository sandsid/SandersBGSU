#include"lab6.h"
#include<iostream>

using namespace std;

Circle::Circle(double r, int x, int y)
{
	radius = r;
	xPos = x;
	yPos = y;

}
void Circle::setRadius(double r)
{
	cin >> r;
	radius = r;
}
void Circle::setxPos(int x)
{
	cin >> x;
	xPos = x;
}
void Circle::setyPos(int y)
{
	cin >> y;
	yPos = y;
}
void Circle::displayCircle() const
{
	cout << "The Circle object with radius " << getRadius() << " has coordinates (" << getxPos() << "," << getyPos() << ")" << endl;
}

void Circle::moveCircle(int dX, int dY)
{
	xPos = xPos + dX;
	yPos = yPos + dY;
}