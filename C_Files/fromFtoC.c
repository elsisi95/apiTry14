#include <stdio.h>
int main(){
  int f;
  float c;
  printf("Enter the temp in F \n");
  scanf("%d", &f);
  c=(5*(f-32))/9;
  printf("the Temp in C is %f \n", c);
  return 0;
}
