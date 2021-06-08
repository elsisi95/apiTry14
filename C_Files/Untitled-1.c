#include <stdio.h>
#include <math.h>

int main() {
double log10();
double X;
float powerIn;
float K; //kardashev scale

printf("Enter the amount of energy (in Watts)\n");
scanf("%f", &powerIn);

X = powerIn - 6 ;

K = log10(X)/10;

printf("The Civilization Type is %f\n", K);

return 0;
}
