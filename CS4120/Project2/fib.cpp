//CS 4120 - Fall 2021
//Sidney Sanders


#include <iostream>
#include<string>
#include<fstream>
#include<chrono>

using namespace std;
using namespace chrono;

int main() {

    high_resolution_clock::time_point startTime;
    high_resolution_clock::time_point endTime;
    //auto duration = 0;

    int n;
    cin >> n;
    cout << recursive(n) << endl;
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

