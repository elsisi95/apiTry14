//private encapsulation example
//A private member cannot be accessed, 
//or even viewed, from outside the class; it can be accessed only from within the class.

#include <iostream>
#include <string>
using namespace std;

class myClass {
  public:
    void setName(string x) {
      name = x;
    }
  private:
    string name;
};

int main() {
  myClass myObj;
  myObj.setName("John");

  return 0;
}