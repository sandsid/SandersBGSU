#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main(int argc, char *argv[])
{
   //check if arg count is correct
   if (argc < 5)
   {
       printf("Error: Expected number of arguments are: 5 \n");
       exit(0);
   }
   //char instead of string
   char fileName[100];
   strcpy(fileName, argv[1]);           //use strcpy to copy the filename
   int numItems = atoi(argv[2]);
   int rangeNum = atoi(argv[3]);
   int seedNum = atoi(argv[4]);
   int i = 0;

   //initialize rand with seed
   srand(seedNum);

   //working with the file
   FILE *fptr = fopen(fileName, "w");

   //loop to write to file
   for (i = 0; i < numItems; i++){
       fprintf(fptr, "%d\n", rand() % rangeNum);
   }
   fclose(fptr);
  
   //read from the file
   FILE *inpfile = fopen(fileName,"r");
  
   int n;
   if(!inpfile){
       printf("Error reading File!\n");   //just to catch an error
   }
  
   else{
       int i = 0;
       while(fscanf(inpfile, "%d", &n) != EOF){   //read until EOF
           i++;                                   //count of the number read
           printf("%d\t", n);
           if(i % 5 == 0){                           //new line on every 5th number
               printf("\n");
           }  
       }
   }
   fclose(inpfile);
   return 0;
}