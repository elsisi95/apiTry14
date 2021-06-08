//public encapsulation example

//A public member is accessible from 
//outside the class, and anywhere within the scope of the class object.

#include <iostream>
#include <string>
using namespace std;

class myClass {
  public:
    string name;
};

int main() {
  myClass myObj;
  myObj.name = "SoloLearn";
  cout << myObj.name;
  return 0;
}
//Outputs "SoloLearn"