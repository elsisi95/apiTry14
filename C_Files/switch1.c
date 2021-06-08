#include <stdio.h>
int main() 
{
  char i;
  printf("enter the grade character\n");
  scanf("%c", &i);
  switch(i)
  {
    case 'a': printf("Excellent\n");
    break;
    case 'b': printf("Very good\n");
    break;
    case 'c': printf("Good\n");
    break;
    case 'd': printf("Acceptable\n");
    break;
    case 'f': printf("Faild\n");
    break;
    default: printf("Wrong input\n");
  }
  return 0;
}
