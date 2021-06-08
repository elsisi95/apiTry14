#include <stdio.h>

int main()
{
  int n = 0;
  int *pointer_to_n = &n;

  for (int i=0; i<13; i++) {
    *pointer_to_n +=1;
    printf("%d\n",n);
  }
  
  return 0;
}
