#include <stdio.h>
int main()
{
  int numbs[10]= {0,1,2,3,4,5,6,7,8,9};
  int sum=0;
  int i;
  float avg;
  for(i=0;i<10;i++){
    sum=sum+numbs[i];
  }
  avg = sum/10;
  printf("%f", &avg);
  return 0;
}
