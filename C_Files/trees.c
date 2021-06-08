#include <stdio.h>
int main()
{
  float l;
  float w;
  float area;
  int trees;

  printf("Enter the width\n");
  scanf("%f", &w);

  printf("Enter the lenght\n");
  scanf("%f", &l);

  area = w*l;
  trees = area/4;

  printf("the number of trees in this area is %d\n", trees);

  return 0;
}
