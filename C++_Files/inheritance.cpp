/*Inheritance is one of the most important concepts of object-oriented programming.
Inheritance allows us to define a class based on another class. This facilitates 
greater ease in creating and maintaining an application. */

#include <iostream>
using namespace std;

class Mother
{
 public:
  Mother() {};
  void sayHi() {
   cout << "Hi";
  }
};

class Daughter: public Mother
{
 public:
  Daughter() {};
};

int main() {
  Daughter d;
  d.sayHi();
}
//Outputs "Hi"


//A protected member variable or function is very similar to a private member, 
//with one difference - it can be accessed in the derived classes.



/* Constructors
The base class constructor is called first.

Destructors
The derived class destructor is called first, 
and then the base class destructor gets called. */