// Assignment:		CS2010 - Lab1
// File Name:		SandersS_Lab1.cpp
// Author:			Sidney Sanders 
// Date:			1/12/2018
// Purpose:			This program demonstrates basic input and output in c++

#include <iostream>
#include <string>
using namespace std;

int main()
{
	string first, last;
	int age;
	
	//get users name and age
	cout << "Please enter your first name:   ";
	cin >> first;
	cout << "Please enter your last name:   ";
	cin >> last;
	cout << "please enter your age:   ";
	cin >> age;

	//display welcoming message, users name and age
	cout << endl;
	cout << "Hello " << first << " " << last << "!" << endl;
	cout << "Welcome to CS2010 where programming is fun!" << endl;
	cout << "You are " << age << " years old." << endl;

	cout << endl;
	system("pause");
	return 0;

}
