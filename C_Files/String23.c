#include <stdio.h>
#include <string.h>
int main()
{
  char name[10];
  int x;
  printf("Enter the name\n");
  gets(name);
  x=strlen(name);
  printf("the lenght of the name is %d\n", x);
  
  return 0;
}
