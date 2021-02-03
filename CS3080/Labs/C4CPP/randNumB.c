


#include <stdio.h>
#include <stdlib.h>
#include <string.h>



int main(int argc, char* argv[])
{
    //check if arg count is correct
    if (argc < 5)
    {
       printf("Error: Expected number of arguments are: 5 \n");
       exit(0);
    }

    //initialize Variables
    //char instead of string
    char fileName[50];
    strcpy(fileName, argv[1]);     
    int numItems = atoi(argv[2]);
    int rangeNum = atoi(argv[3]);
    int seedNum = atoi(argv[4]);
    int i = 0;
  

    //initialize rand
    srand(seedNum);

    //working with the file
    FILE *fptr = fopen(fileName, "w");

    //loop to write to file
    for (i = 0; i < numItems; i++){
        fprintf(fptr, "%d\n", rand()%rangeNum);
    }
    fclose.(fptr);
    
    //open file to read
    
    //read from the file and put in array
    int numAry[100];

    for (i = 0; i <numItems; i++){
        fscanf(fptr, "%1d", &numAry[i]);
    }

    //print
    for ( i = 0; i < numItems; i++){
        if( i%5 == 0)
        {
            printf("%d", "\n");
            printf("%d", numAry[i]);
        }
        else
        {
            printf("%d", numAry[i]);
        }
        
    }

    fclose(fptr);
    
    return 0;
}
