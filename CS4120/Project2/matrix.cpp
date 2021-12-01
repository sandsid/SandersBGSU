#include <iostream>
using namespace std;

#include<climits>

// Finished in 5 ms

int recursive_helper(int *p,int start,int end){
    if(start>=end)
        return 0;
    
    int temp_final = INT_MAX;
    for(int k=start; k < end; k++){
        int temp_first_half = recursive_helper(p,start,k)+recursive_helper(p,k+1,end) + p[start-1]*p[k]*p[end];
      
        
         temp_final = min(temp_first_half,temp_final);  
    }
    
    return temp_final;
}

int recursive(int* p, int n){
   return recursive_helper(p,1,n);
}

//Finished in 4 ms

int matrixChainMemoised(int* p, int i, int j,int dp[][100])
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
            dp[i][j], matrixChainMemoised(p, i, k,dp)
                     + matrixChainMemoised(p, k + 1, j,dp)
                       + p[i - 1] * p[k] * p[j]);
    }
    return dp[i][j];
}

int memoized_function(int* p, int n)
{
    int i = 1, j = n - 1;
    int dp[100][100];
    return matrixChainMemoised(p, i, j,dp);
}


// Finished in 0 ms

//#include <bits/stdc++.h>
//using namespace std;
 
// Function for printing the optimal
// parenthesization of a matrix chain product
void printParenthesis(int i, int j, int n, int* bracket,
                      char& name)
{
    // If only one matrix left in current segment
    if (i == j) {
        cout << name++;
        return;
    }
 
    cout << "(";
 
    // Recursively put brackets around subexpression
    // from i to bracket[i][j].
    // Note that "*((bracket+i*n)+j)" is similar to
    // bracket[i][j]
    printParenthesis(i, *((bracket + i * n) + j), n,
                     bracket, name);
 
    // Recursively put brackets around subexpression
    // from bracket[i][j] + 1 to j.
    printParenthesis(*((bracket + i * n) + j) + 1, j, n,
                     bracket, name);
    cout << ")";
}
 
void matrixChainOrder(int p[], int n)
{
    /* For simplicity of the program, one extra
       row and one extra column are allocated in
        m[][]. 0th row and 0th column of m[][]
        are not used */
    int m[n][n];
 
    // bracket[i][j] stores optimal break point in
    // subexpression from i to j.
    int bracket[n][n];
 
    /* m[i,j] = Minimum number of scalar multiplications
    needed to compute the matrix A[i]A[i+1]...A[j] =
    A[i..j] where dimension of A[i] is p[i-1] x p[i] */
 
    // cost is zero when multiplying one matrix.
    for (int i = 1; i < n; i++)
        m[i][i] = 0;
 
    // L is chain length.
    for (int L = 2; L < n; L++)
    {
        for (int i = 1; i < n - L + 1; i++)
        {
            int j = i + L - 1;
            m[i][j] = INT_MAX;
            for (int k = i; k <= j - 1; k++)
            {
                // q = cost/scalar multiplications
                int q = m[i][k] + m[k + 1][j]
                        + p[i - 1] * p[k] * p[j];
                if (q < m[i][j])
                {
                    m[i][j] = q;
 
                    // Each entry bracket[i,j]=k shows
                    // where to split the product arr
                    // i,i+1....j for the minimum cost.
                    bracket[i][j] = k;
                }
            }
        }
    }
 
    // The first matrix is printed as 'A', next as 'B',
    // and so on
    char name = 'A';
 
    cout << "Optimal Parenthesization is : ";
    printParenthesis(1, n - 1, n, (int*)bracket, name);
    cout << "nOptimal Cost is : " << m[1][n - 1];
}
 
// Driver code
int main()
{
    int arr[] = { 40, 20, 30, 10, 30 };
    int n = sizeof(arr) / sizeof(arr[0]);
    matrixChainOrder(arr, n);
}
