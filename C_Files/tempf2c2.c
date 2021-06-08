#include <stdio.h>
int main(){

int lower = 0;
int step = 20;
int higher = 300;
int f;
float c;
f = lower;
while (f <= higher){
c = (5*(f-32))/9;
printf("The temp in C is %f\n", c);
f = f + step;
    }
    return 0 ;
}
