#include <iostream>
#include <fstream>
#include <string>

using namespace std;



void ReadData();

int main() {

	string instr = "";
	fstream myFile;
	myFile.open("prog4.txt", ios::in);

	if (myFile.is_open()) {
		while (!myFile.eof()) {
			getline(myFile, instr, ' ');
			cout << instr << endl;
		}
		myFile.close();
	}

	ReadData();

	system("pause");

	return 0;
}



void ReadData() {
	streampos size;
	char* memblock;
	fstream file("prog4.txt", ios::in | ios::binary | ios::ate);

	if (file.is_open()) {
		size = file.tellg();
		memblock = new char[size];
		file.seekg(0, ios::beg);
		file.read(memblock, size);
		file.close();
	
		cout << "The entire file content is in memory." << endl;

		delete[] memblock;
		memblock = nullptr;

	}
}