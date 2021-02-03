// Program 5
// Description:Prog5 header file
// Programmer:  Sidney Sanders
// Class:  CS 2020 - spring 2019

#ifndef PROG5_H
#define PROG5_H


//class declaration
class Temperature
{
private:
	//private integer
	int temp;
public:
	//overload constructor
	Temperature(int degrees){temp = degrees;};
	//constructor
	Temperature(){temp = 0;};

	//setTemp to degrees, get temp from user
	void setTemp(int degrees){temp = degrees;};
	int getTemp() const{return temp;};

	//functions out-of-line 
	void isEthylFreezing(int temp);
	void isEthylBoiling(int temp);
	void isOxygenFreezing(int temp);
	void isOxygenBoiling(int temp);
	void isWaterFreezing(int temp);
	void isWaterBoiling(int temp);
	void isNitrogenFreezing(int temp);
	void isNitrogenBoiling(int temp);
};

#endif