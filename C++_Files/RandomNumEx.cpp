#include <iostream>
#include <cstdlib> //for random numbers rand() and srand()

int main() {
  for (int x = 1; x <= 10; x++) {
    cout << rand() << endl;
  }

  //to generate numbers within range such as from 1 to 6:
  for (int y = 1; y <= 10; y++) {
  cout << 1 + (rand() % 6) << endl;
  }
}

/* Output: 
41
18467
6334
26500
19169
15724
11478
29358
26962
24464
*/

//srand() => for truly random numbers (bal77777)