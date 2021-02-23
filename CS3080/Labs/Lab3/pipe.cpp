#include <pthread.h>
#include <stdio.h>
#include <stdlib.h>
#include <iostream>

using namespace std;
#define NUM_THREADS 2

#define BSIZE 10        // buffer size is 10
#define NUM_ITEMS 10    // num items to produce/consume

int buf[BSIZE];
int NextIn = 0, NextOut = 0;

void * producer(void *);
void * consumer(void *);

pthread_t tid[NUM_THREADS];     // array of thread IDs
pthread_mutex_t lock;
pthread_cond_t empty, full;


int main(int argc, char *argv[])
{
        int i;
        int j;
        int max = buf[0];
        int min = 1000;
        int avg = 0;
        int total = 0;

        pthread_create(&tid[0], NULL, producer, NULL);
        pthread_create(&tid[1], NULL, consumer, NULL);

        for(i = 0; i < NUM_THREADS; i++)
        {
                pthread_join(tid[i], NULL);
        }

        for(j = 0; j < BSIZE; j++)
        {
                if(buf[j] > max)
                {
                        max = buf[j];
                }
                if(buf[j] < min)
                {
                        min = buf[j];
                }
                total = total + buf[j];

        }
        avg = total / BSIZE;

        printf("\n *** main() reporting: all %d threads terminated *** \n\n", i);

        cout << "Max item: " << max << endl;
        cout << "Min item: " << min << endl;
        cout << "Average item: " << avg << endl;

        return 0;
}

void * producer(void * parm)
{

        int num;

        printf("\n ++++ Producer Started ++++ \n");

        // produce item

        while(NextIn < NUM_ITEMS)
        {
                num = rand() % 1000;
                buf[NextIn++] = num;
                printf(" Produced item: %d\n", num);
        }
//      pthread_cond_signal(&full);
        printf("\n +++ Producer Exiting +++ \n");
        pthread_exit(0);
}

void * consumer(void * parm)
{
//      pthread_cond_wait((&full), &lock);
        int num;
        int i;
        int status;

        i = wait(&status);
        printf("\n --- Consumer Started --- \n");

        // consume item

        while(NextOut < NUM_ITEMS)
        {
                num = buf[NextOut++];
                printf("Consuming item: %d\n", num);
        }

//      pthread_cond_signal(&empty);
        printf("\n --- Consumer Exiting --- \n");
        pthread_exit(0);
}
