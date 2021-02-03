#include <stdio.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/stat.h>
#include <fcntl.h>
#include <unistd.h>

#include <string.h>
#include <iostream> 

using namespace std;
int main (int argc, char *argv[]) {
  int descriptor; 
  descriptor = open ( argv[1], O_WRONLY ); 
  write (descriptor, "Hello World", strlen ( "Hello World") ); 
  write (descriptor, "Hello World", strlen ( "Hello World") ); 
  close (descriptor);
}
