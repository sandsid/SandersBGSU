// Lab 7.h
// Description:Lab 7 header file
// Programmer:  Sidney Sanders
// Class:  CS 2020 - spring 2019

#ifndef CIRCLE_H
#define CIRCLE_H

using namespace std;

class Circle
{
private:
	int radius;
	int xPos;
	int yPos;
public:
	//constructor
	Circle(int, int, int) { radius = 0; xPos = 0; yPos = 0;};
	//deconstructor
	~Circle() {};

	//set functions - in-line
	void setRadius(int r) {radius = r;};
	void setxPos(int x) { xPos = x; };
	void setyPos(int y) { yPos = y; };

	//get functions - in-line
	int getRadius() const { return radius; };
	int getxPos() const { return xPos; };
	int getyPos() const { return yPos; };

	//function out-of-line
	void displayCircle(int, int, int);
	void moveCircle(int &, int );
	void displayQuad(int, int);


	
};

#endif // !CIRCLE_H
