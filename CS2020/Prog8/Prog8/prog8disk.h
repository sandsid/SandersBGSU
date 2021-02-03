// Program 8  disk header file
// Description: Products program       
// Programmer:   Sidney Sanders  
// Class:    CS 2020 Spring 2019 


#ifndef PROG8DISK_H
#define PROG8DISK_H


class Disc
{
private:
	int weight;
	Disc *pNext;
public:
	// Function: constructor   
	// Description: initialize disc to 0 and null     
	// Parameters: none  
	// Returns:  n/a
	Disc() { weight = 0; pNext = nullptr; };

	// Function: disc   
	// Description: constructor function     
	// Parameters: count of discs  
	// Returns:  n/a
	Disc(int howMany) { weight = howMany; pNext = nullptr; };
	//~Disc();

	// Function: getweight   
	// Description: return the value of weight     
	// Parameters: none  
	// Returns:  weight
	int getWeight() { return weight;}

	// Function: getptr   
	// Description: return the value of pNext     
	// Parameters: none  
	// Returns:  pnext
	Disc *getPtr() { return pNext; }

	// Function: set weight   
	// Description: sets the weight variable to num
	// Parameters: integer num  
	// Returns:  n/a
	void setWeight(int num) { weight = num; };

	// Function: set pointer   
	// Description: sets the pointer variable to a pointer location
	// Parameters: pointer   
	// Returns:  n/a
	void setPointer(Disc *pointer) { pNext = pointer; };

};





#endif // !PROG8DISK_H
