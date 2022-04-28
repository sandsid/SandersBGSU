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
  int fileDescriptor; 
  char buf [123];

  fileDescriptor = open ( argv[1], O_RDONLY ); 
  read ( fileDescriptor, buf, 123 ); 
  cout << "read from pipe: " << buf << endl;
  close (fileDescriptor);
} 

