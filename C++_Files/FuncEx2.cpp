//example for a default values in functions

#include <iostream>
#include <string>
#include <cstdlib>

int volume(int l=1, int w=1, int h=1) {
  return l*w*h;
}

int main() {
  cout << volume() << endl;
  cout << volume(5) << endl;
  cout << volume(2, 3) << endl;
  cout << volume(3, 7, 6) << endl;
}

/* Output
1
5
6
126
*/