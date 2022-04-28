//CS 4120 - Fall 2021
//Sidney Sanders

#include <iostream>
#include<string>
#include<fstream>
#include<chrono>

using namespace std;
using namespace chrono;

int recursive(int);
int memoized_function(int);
int memoized_top_down_version(int, int*);
int bottomUpVersion(int);

int main() {

    high_resolution_clock::time_point startTime;
    high_resolution_clock::time_point endTime;
    auto duration = 0;
    int ary[] = {0, 0, 0, 0, 0, 0};
    int i = 0;
    ifstream infile;
    infile.open("fibonacciInput.txt");
    int num = 0;
    if(infile.is_open())
    {
        while(infile >> num)
        {
            ary[i] = num;
            //cout << ary[i] << endl;
            i++;
            
        }
        infile.close();
    }

    cout << endl;
    cout << "Recursive Solution" << endl;
    cout << "Integer\t" << "Result\t\t" << "Time Duration" << endl;
    for (int n = 0; n < i; n++)
    {
        
        startTime = high_resolution_clock::now();
        int result = recursive(ary[n]);
        endTime = high_resolution_clock::now();

        duration = duration_cast<nanoseconds>(endTime - startTime).count();

        cout << ary[n] << "\t" << result << "\t\t" << duration << endl;        

    }



    cout << endl;
    cout << "Memorized top-down Solution" << endl;
    cout << "Integer\t" << "Result\t\t" << "Time Duration" << endl;
    for (int n = 0; n < i; n++)
    {
        
        startTime = high_resolution_clock::now();
        long long int result = memoized_function(ary[n]);
        endTime = high_resolution_clock::now();

        duration = duration_cast<microseconds>(endTime - startTime).count();

        cout << ary[n] << "\t" << result << "\t\t" << duration << endl;        

    }


    cout << endl;
    cout << "Bottom-up version " << endl;
    cout << "Integer\t" << "Result\t\t" << "Time Duration" << endl;
    for (int n = 0; n < i; n++)
    {
        
        startTime = high_resolution_clock::now();
        long long int result = bottomUpVersion(ary[n]);
        endTime = high_resolution_clock::now();

        duration = duration_cast<microseconds>(endTime - startTime).count();

        cout << ary[n] << "\t" << result << "\t\t" << duration << endl;        

    }


    return 0;
}


int recursive(int n) {
    if(n <= 1) {
        return n;
    }
    int a = recursive(n - 1);
    int b = recursive(n - 2);
    return a + b;
}

// Finished in 2 ms

int memoized_top_down_version(int n, int *ans) {
    if(n <= 1) {
        return n;
    }

    // Check if output already exists
    if(ans[n] != -1) {
        return ans[n];
    }

    // Calculate output
    int a = memoized_top_down_version(n-1, ans);
    int b = memoized_top_down_version(n-2, ans);

    // Save the output for future use
    ans[n] = a + b;
    
    // Return the final output
    return ans[n];
}

int memoized_function(int n) {
    int *ans = new int[n+1];

    for(int i = 0; i <= n; i++) {
        ans[i] = -1;
    }
    
    return memoized_top_down_version(n, ans);
}

//Finished in 0 ms

int bottomUpVersion(int n) {
    int *ans = new int[n+1];

    ans[0] = 0;
    ans[1] = 1;

    for(int i = 2; i <= n; i++) {
        ans[i] = ans[i-1] + ans[i-2];
    }

    return ans[n];
}

