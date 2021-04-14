//*****************************************************************************
// Lab 5 -	    Virtual Memory Experiment: Page Replacement Algorithms
//			
// Objective:
//              • Understand Virtual Memory
//              • Experiments with Page Replacement Algorithms
//              • Understand Page Fault and Performance issues
//              • Writing adata-analyticreport comparing the results with 
//                  explanations and suggestion.
//
// Programmer:	Sidney Sanders
// Class:		CS 3080-1001 Spring 2021
//
// File:        PageFault.cpp
//
//****************************************************************************

#include <stdio.h>
#include <stdlib.h>
#include <iostream>
#include <string.h>
#include <bits/stdc++.h>

using namespace std;

int FifoFaults = 0;
int LruFaults = 0;
int MinFIFO = 1000;
int MinFIFOFrameNum = 0;
int MinLRU = 1000;
int MinLRUFrameNum = 0;

int faultsFIFO(int[], int, int);
int faultsLRU(int[], int, int);
int main()
{
    int pageRef[] = {1, 2, 7, 4, 5, 2, 7, 
                     2, 3, 2, 1, 7, 6, 3, 
                     7, 6, 3, 4, 3, 4, 3, 
                     4, 7, 2, 1, 7, 6, 7, 
                     8, 7, 8, 9, 7, 8, 2, 
                     7, 8, 3, 5, 3, 5, 7};
    int cases = 5;
    int n = 42;
    cout << endl;
    cout << "Page Replacement Algorithm Evaluation Results" << endl << endl;
    
    cout << "FIFO Results:" << endl;
    cout << "Frame Number 3:\t" << faultsFIFO(pageRef, n, 3) << "  Page Faults" << endl;
    cout << "Frame Number 4:\t" << faultsFIFO(pageRef, n, 4) << "  Page Faults" << endl;
    cout << "Frame Number 5:\t" << faultsFIFO(pageRef, n, 5) << "  Page Faults" << endl;
    cout << "Frame Number 6:\t" << faultsFIFO(pageRef, n, 6) << "  Page Faults" << endl;
    cout << "Frame Number 7:\t" << faultsFIFO(pageRef, n, 7) << "  Page Faults" << endl;
    cout << endl;
    
    cout << "LRU Results:" << endl;
    cout << "Frame Number 3:\t" << faultsLRU(pageRef, n, 3) << "  Page Faults" << endl;
    cout << "Frame Number 4:\t" << faultsLRU(pageRef, n, 4) << "  Page Faults" << endl;
    cout << "Frame Number 5:\t" << faultsLRU(pageRef, n, 5) << "  Page Faults" << endl;
    cout << "Frame Number 6:\t" << faultsLRU(pageRef, n, 6) << "  Page Faults" << endl;
    cout << "Frame Number 7:\t" << faultsLRU(pageRef, n, 7) << "  Page Faults" << endl;
    cout << endl;

    if (FifoFaults == LruFaults)
        cout << "NO Minimum Page Fault: Both Algorithms have " << MinFIFO << " Faults" << endl;
    else if (FifoFaults > LruFaults)
        cout << "Minimum Page Fault: Algorithm FIFO with " << MinFIFO << " Frame number " << MinFIFOFrameNum;
    else 
        cout << "Minimum Page Fault: Algorithm LRU with " << MinLRU << " Frame number " << MinLRUFrameNum;

    cout << endl;
    return 0;
}

int faultsFIFO(int pageRef[], int frameNum, int cases)
{
    unordered_set<int> set;
    queue<int> que;
    int faults = 0;
    
    for(int i = 0; i < 42; i++)
    {
        if (set.size() < cases)
        {
            if (set.find(pageRef[i]) == set.end())
            {
                set.insert(pageRef[i]);
                que.push(pageRef[i]);
                faults++;
            }
        }
        else
        {
            if (set.find(pageRef[i]) == set.end())
            {
                int x = que.front();
                que.pop();

                set.erase(x);
                set.insert(pageRef[i]);

                que.push(pageRef[i]);

                faults++;
            }
        }
    }
    if (faults < MinFIFO)
    {
        MinFIFO = faults;
        MinFIFOFrameNum = cases;
    }
    FifoFaults += faults;
    return faults;
}

int faultsLRU(int pageRef[], int frameNum, int cases)
{
    unordered_set<int> set;
    unordered_map<int, int> que;
    int faults = 0;

    for(int i = 0; i < frameNum; i++)
    {
        if (set.size() < cases)
        {
            if (set.find(pageRef[i]) == set.end())
            {
                set.insert(pageRef[i]);
                faults++;
            }
            que[pageRef[i]] = i;
        }
        else
        {
            if (set.find(pageRef[i]) == set.end())
            {
                int x = INT_MAX, y;
                for (auto j = set.begin(); j != set.end(); j++)
                {
                    if (que[*j] < x)
                    {
                        x = que[*j];
                        y = *j;
                    }
                }

                set.erase(y);
                set.insert(pageRef[i]);

                faults++;
            }
            que[pageRef[i]] = i;
        }
    }

    if (faults < MinLRU)
    {
        MinLRU = faults;
        MinLRUFrameNum = cases;
    }
    LruFaults += faults;
    return faults;
}