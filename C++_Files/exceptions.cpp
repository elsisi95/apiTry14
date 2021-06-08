/* Problems that occur during program execution are called exceptions.
In C++ exceptions are responses to anomalies that arise while the program is running, 
such as an attempt to divide by zero. */


//C++ exception handling is built upon three keywords: try, catch, and throw.

//throw is used to throw an exception when a problem shows up.

int motherAge = 29;
int sonAge = 36;
if (sonAge > motherAge) {
  throw "Wrong age values";
}

/* A try block identifies a block of code that will activate specific exceptions. 
It's followed by one or more catch blocks. The catch keyword represents a block of 
code that executes when a particular exception is thrown. */

try {
  int motherAge = 29;
  int sonAge = 36;
  if (sonAge > motherAge) {
   throw 99;
  }
} 
catch (int x) {
  cout<<"Wrong age values - Error "<<x;
}

//Outputs "Wrong age values - Error 99"

//exception handelling for unwanted user inputs

int main() {
  int num1;
  cout <<"Enter the first number:";
  cin >> num1;

  int num2;
  cout <<"Enter the second number:";
  cin >> num2;

  if(num2 == 0) {
   throw 0;
  } 

  cout <<"Result:"<<num1 / num2;  
}


//whole program example

int main() {
 try {
  int num1;
  cout <<"Enter the first number:";
  cin >> num1;

  int num2;
  cout <<"Enter the second number:";
  cin >> num2;

  if(num2 == 0) {
   throw 0;
  } 

  cout <<"Result:"<<num1 / num2; 
 }
 catch(int x) {
  cout <<"Division by zero!";
 }
}

/* In our case, we catch exceptions of type integer only. 
It's possible to specify that your catch block handles any 
type of exception thrown in a try block. To accomplish this, 
add an ellipsis (...) between the parentheses of catch: */

try {
  // code
} catch(...) {
  // code to handle exceptions
}