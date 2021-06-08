//firstly, you create a seperate file called MyClass.h
class MyClass
{
  public:
   MyClass();
   void myPrint();
};

//MyClass.h

//then, in the source file MyClass.cpp, you call the class

#include "MyClass.h"
#include <iostream>
using namespace std;

MyClass::MyClass() {
}

void MyClass::myPrint() {
  cout <<"Hello"<<endl;
}

