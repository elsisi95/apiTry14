#include <stdio.h> //not working
int main () {

  char s;
  int co = 0;

  printf("Enter the sentence\n");
  s = getchar();
  while((s=getchar()) != EOF){
    if( s == '\n' || s == '\t'){
      co = co + 1;
    }
  }
  printf("%d", co);
  return 0;
}
