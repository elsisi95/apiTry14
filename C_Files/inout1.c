#include <stdio.h>
int main ()
{
  int inp;
  printf("enter the age\n");
  scanf("%d\n", &inp);

  if (inp<21){
    printf("underage\n");
  }
  else if(inp>21 && inp<49){
    printf("adult\n");
  }
  else if(inp>49){
    printf("overaged\n");
  }
  else{
    printf("wrong input\n");
  }
  return 0; //mesh sha3'al s7
}
