#include <stdio.h> //not working
#include <math.h>

int main() {
  int digit[10];
  int No_even , No_odd, zero;
  int i,c;

  No_even = No_odd = zero = 0;
  printf("Enter 10 Number\n");

  for (i=0; i<10; i++){
    scanf("%d", &digit[i]);
  }

  for(c=0; c<10; c++){ //syntax error
    if(digit[c] == '1' || digit[c] == '3' || digit[c] == '5' || digit[c] == '7' || digit[c] == '9' ){
      No_odd = No_odd + 1;
    }
    else if(digit[c] == '0'){
      zero = zero +1;
    }
    else {
      No_even = No_even + 1;
    }
  }

  printf("Number of odd number is %d\n", No_odd);
  printf("Number of even Numbers is %d\n", No_even);
  printf("Number of zeros is %d\n", zero);
  return 0;
}
