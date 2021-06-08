//contstructing and distructing a class MyClass

#include "MyClass.h"
#include <iostream>
using namespace std;

MyClass::MyClass() //MyClass() function is connected to the MyClass Class
{
  cout<<"Constructor"<<endl;
}

MyClass::~MyClass() //~ is the distruction symbol 
{
  cout<<"Destructor"<<endl;
}

//Since destructors can't take parameters, they also can't be overloaded.
//Each class will have just one destructor.


#ifndef MYCLASS_H
#define MYCLASS_H

class MyClass
{
  public:
  MyClass();
  protected:
  private:
};

#endif // MYCLASS_H 

/*ifndef stands for "if not defined". The first pair of statements tells the program to 
define the MyClass header file if it has not been defined already.
endif ends the condition. */