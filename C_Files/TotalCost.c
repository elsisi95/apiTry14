#include <stdio.h>

int main() {

  int price;
  float TotalCost;
  printf("enter the purchase value\n");
  scanf("%d", &price);
  
  if(price>100){
    TotalCost = (price*0.75)+10; 
  }
  else{
    TotalCost = (price*0.85)+5;
  }
  
  printf("The total cost is %f\n", TotalCost);
  return 0;
}
