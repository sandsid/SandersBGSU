//CS 4120 - Fall 2021
//Sidney Sanders


#include <iostream>
#include<string>
#include<fstream>
#include<chrono>
#include <iostream>
#include<climits>


using namespace std;
using namespace chrono;

int recursive(int*, int);
int recursive_matrix(int *,int, int);
int memoized_function(int*, int);
int matrixMemoised(int*, int, int,int);
void matrixChainOrder(int [], int);
void printParenthesis(int, int, int, int*, char&);

//Main operation
int main()
{
    high_resolution_clock::time_point startTime;
    high_resolution_clock::time_point endTime;
    auto duration = 0;

    ifstream infile;
    infile.open("matrixInput.txt");
    int num = 0;
    int ary[] = { 0, 0, 0, 0, 0, 0, 0 };
    int i = 0;
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
    startTime = high_resolution_clock::now();
    recursive(ary, i);
    
    endTime = high_resolution_clock::now();

    duration = duration_cast<nanoseconds>(endTime - startTime).count();
    cout << "Time: \t" << duration << endl;
    
    cout << endl;
    cout << "Top-down Solution" << endl;
    startTime = high_resolution_clock::now();
    memoized_function(ary, i);
    endTime = high_resolution_clock::now();

    duration = duration_cast<nanoseconds>(endTime - startTime).count();
    cout << "Time: \t" << duration << endl;

    cout << endl;
    cout << "Bottom Up Solution " << endl;
    startTime = high_resolution_clock::now();
    matrixChainOrder(ary, i);
    endTime = high_resolution_clock::now();

    duration = duration_cast<nanoseconds>(endTime - startTime).count();
    cout << "Time: \t" << duration << endl;


    return 0;
}


int recursive(int* p, int n){
   return recursive_matrix(p,1,n);
}

int recursive_matrix(int *p,int start,int end){
    if(start>=end)
        return 0;
    
    int finish = INT_MAX;
    for(int k=start; k < end; k++){
        int begining = recursive_matrix(p,start,k)
        +recursive_matrix(p,k+1,end) 
        +p[start-1]*p[k]*p[end];
      
        finish = min(begining,finish);  
    }
    
    return finish;
}


int matrixMemoised(int* p, int i, int j,int dp[][100])
{
    if (i == j)
    {
        return 0;
    }
    if (dp[i][j] != -1)
    {
        return dp[i][j];
    }
    dp[i][j] = INT_MAX;
    for (int k = i; k < j; k++)
    {
        dp[i][j] = min(
            dp[i][j], matrixMemoised(p, i, k,dp)
                     + matrixMemoised(p, k + 1, j,dp)
                       + p[i - 1] * p[k] * p[j]);
    }
    
    return dp[i][j];
}

int memoized_function(int* p, int n)
{
    int i = 1, j = n - 1;
    int dp[100][100];
    return matrixMemoised(p, i, j,dp);
}

void matrixChainOrder(int p[], int n)
{
    int m[n][n];
    int bracket[n][n];
 
    for (int i = 1; i < n; i++)
        m[i][i] = 0;

    for (int L = 2; L < n; L++)
    {
        for (int i = 1; i < n - L + 1; i++)
        {
            int j = i + L - 1;
            m[i][j] = INT_MAX;
            for (int k = i; k <= j - 1; k++)
            {
                int q = m[i][k] + m[k + 1][j]
                        + p[i - 1] * p[k] * p[j];
                if (q < m[i][j])
                {
                    m[i][j] = q;
                    bracket[i][j] = k;
                }
            }
        }
    }

    char name = 'a';
 
    printParenthesis(1, n - 1, n, (int*)bracket, name);
    cout << endl;
}
 // parenthesization 
void printParenthesis(int i, int j, int n, int* bracket,
                      char& name)
{
    // If only one matrix left in current segment
    if (i == j) {
        cout << name++;
        return;
    }
 
    cout << "(";
    printParenthesis(i, *((bracket + i * n) + j), n,
                     bracket, name);
    printParenthesis(*((bracket + i * n) + j) + 1, j, n,
                     bracket, name);
    cout << ")";
}
