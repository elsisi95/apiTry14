#include <stdio.h>

int main() {
int array[]={23,43,5,7,18,5,2,76,8,3,9,51};
int i;
for (i=0; i<12; i++) {
  if(array[i]<10 || array[i]>25){

    printf("number out of range\n");
  }
  else{
  printf("%d\n", array[i]);
   }
 }
return 0;
}
