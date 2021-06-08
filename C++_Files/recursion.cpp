#include <iostream>
using namespace std;

void factorial(int n) {
  if (n==1) {
    return 1;
  }
  else {
    return n * factorial(n-1);
  }
}

int main() {
    int n;
    cin >> n >> endl; 
    cout << factorial(5);

  return 0;
}
