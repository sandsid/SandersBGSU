
using namespace std;

// Function to find page faults using FIFO
int pageFaults(int pages[], int n, int capacity)
{
   // To represent set of current pages.
   unordered_set<int> s;

   // To store the pages in FIFO manner
   queue<int> indexes;

   // Start from initial page
   int page_faults = 0;
   for (int i=0; i<n; i++)
   {
       // Check if the set can hold more pages
       if (s.size() < capacity)
       {
           // Insert it into set if not present
           if (s.find(pages[i])==s.end())
           {
               s.insert(pages[i]);
               page_faults++;

               // Push the current page into the queue
               indexes.push(pages[i]);
           }
       }

       // If the set is full then need to perform FIFO
       else
       {
           // Check if current page is not already present in the set
           if (s.find(pages[i]) == s.end())
           {
               int val = indexes.front();
               indexes.pop();

               // Remove the indexes page from the set
               s.erase(val);

               // insert the current page in the set
               s.insert(pages[i]);

               // push the current page into the queue
               indexes.push(pages[i]);
               page_faults++;
           }
       }
   }

   return page_faults;
}

int main()
{
   int pages[] = {1, 2, 3, 4, 5, 6, 7, 2, 1, 2, 1, 2, 1, 2, 6, 3, 4, 6, 3, 4,
   6, 2, 1, 2, 1, 8, 7, 9, 8, 7, 9, 8, 7, 9, 3, 4, 3, 4, 1, 4, 1, 5, 6, 7, 8,
   7, 8, 9, 7, 8, 3, 3, 4, 3, 5, 3, 5, 3, 2, 1, 2, 1, 5, 6, 3, 2, 7, 3, 9, 5,
   6, 7, 8, 7, 8, 9, 1, 2, 1, 3};
   int n = sizeof(pages)/sizeof(pages[0]);
   int capacity = 5;
   cout << pageFaults(pages, n, capacity);
   return 0;
}