#include <stdio.h>

  void sort(int a, int b)
  {
    if (a>b)
    printf("%d %d\n", a,b);
    else
    printf("%d %d\n", b,a);
  }

  int main()
  {
    sort(10,9);
    sort(4,16);
    return 0;
  }
