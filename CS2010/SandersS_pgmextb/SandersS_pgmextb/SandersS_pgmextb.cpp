// Description: Extra Credit Program part B
// Author: Sidney Sanders
// Date: 04/25/2018


#include <iostream>
#include <iomanip>

using namespace std;

const int END_VALUE = -1;

int main()
{
	int boxes = 0, total = 0, scouts = 0;

	cout << setw(25) << "Cookie Sales" << endl;

	while (boxes != END_VALUE)
	{
		scouts = scouts + 1;
		cout << "Enter Boxes Sold by scout " << scouts << " (-1 to end):  ";
		cin >> boxes;
		total = total + boxes;

	}
	scouts = scouts - 1;

	cout << "Total boxes of cookies sold:  " << total << endl;
	cout << "Number of scouts selling cookies:  " << scouts << endl;
	cout << "Average number of boxes sold by a scout:  " << total / scouts << endl;



	cout << endl;
	system("pause");
	return 0;
}